---
title: Debugging deadlock - .NET Core
description: A tutorial walk-through, debugging locking issues in .NET Core.
author: sdmaclea
ms.author: stmaclea
ms.date: 10/14/2019
---
# Debugging deadlock

**This article applies to:** .NET Core 3.0 SDK and later versions

In this scenario, the endpoint will experience a hang and thread accumulation. We'll show how you can use the tools to analyze the problem.

## Preparing

The tutorial uses:

- [Sample debug target](sample-debug-target.md) to trigger the scenario.
- [dotnet-trace](dotnet-trace.md) to list processes.
- [dotnet-dump](dotnet-dump.md) to collect and analyze a dump file.

The tutorial assumes the sample and tools are ready to use and you are running on **Linux**.

## Core dump generation

To investigate hung application, a memory dump allows us to inspect the state of its threads and any possible locks that may have contention issues.

Lets run the [Sample debug target](sample-debug-target.md).

```dotnetcli
dotnet run
```

Then find the process ID using:

```dotnetcli
dotnet-trace list-processes
```

Navigate to the following URL:

[http://localhost:5000/api/diagscenario/deadlock](http://localhost:5000/api/diagscenario/deadlock)

Let the request run for about 10-15 seconds then create the dump:

```dotnetcli
sudo dotnet-dump collect -p 4807
```

## Analyzing the core dump

To start our investigation, let's open the core dump using dotnet-dump analyze:

```dotnetcli
dotnet-dump analyze  ~/.dotnet/tools/core_20190513_143916
```

Since we're looking at a potential hang, we want an overall feel for the thread activity in the process. We can use the threads command as shown below:

```console
> threads
*0 0x1DBFF (121855)
 1 0x1DC01 (121857)
 2 0x1DC02 (121858)
 3 0x1DC03 (121859)
 4 0x1DC04 (121860)
 5 0x1DC05 (121861)
 6 0x1DC06 (121862)
 7 0x1DC07 (121863)
 8 0x1DC08 (121864)
 9 0x1DC09 (121865)
 10 0x1DC0A (121866)
 11 0x1DC0D (121869)
 12 0x1DC0E (121870)
 13 0x1DC10 (121872)
 14 0x1DC11 (121873)
 15 0x1DC12 (121874)
 16 0x1DC13 (121875)
 17 0x1DC14 (121876)
 18 0x1DC15 (121877)
 19 0x1DC1C (121884)
 20 0x1DC1D (121885)
 21 0x1DC1E (121886)
 22 0x1DC21 (121889)
 23 0x1DC22 (121890)
 24 0x1DC23 (121891)
 25 0x1DC24 (121892)
 26 0x1DC25 (121893)

...

...

 317 0x1DD48 (122184)
 318 0x1DD49 (122185)
 319 0x1DD4A (122186)
 320 0x1DD4B (122187)
 321 0x1DD4C (122188)
 ```

The output shows all the threads currently running in the process with their associated debugger thread ID and operating system thread ID.

Based on the output above it looks like we have a little over 300 threads.

The next step is to get a better understanding of what the threads are currently doing by getting their callstacks. There's a command called `clrstack` that can be used to output callstacks. It can either output a single callstack or all the callstacks.

Run:

```console
> clrstack -all
```

A representative portion of the output looks like:

```console
  ...
  ...
  ...
        Child SP               IP Call Site
00007F2AE37B5680 00007f305abc6360 [GCFrame: 00007f2ae37b5680]
00007F2AE37B5770 00007f305abc6360 [GCFrame: 00007f2ae37b5770]
00007F2AE37B57D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2ae37b57d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2AE37B5920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2AE37B5950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2AE37B5CA0 00007f30593044af [GCFrame: 00007f2ae37b5ca0]
00007F2AE37B5D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2ae37b5d70]
OS Thread Id: 0x1dc82
        Child SP               IP Call Site
00007F2AE2FB4680 00007f305abc6360 [GCFrame: 00007f2ae2fb4680]
00007F2AE2FB4770 00007f305abc6360 [GCFrame: 00007f2ae2fb4770]
00007F2AE2FB47D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2ae2fb47d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2AE2FB4920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2AE2FB4950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2AE2FB4CA0 00007f30593044af [GCFrame: 00007f2ae2fb4ca0]
00007F2AE2FB4D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2ae2fb4d70]
OS Thread Id: 0x1dc83
        Child SP               IP Call Site
00007F2AE27B3680 00007f305abc6360 [GCFrame: 00007f2ae27b3680]
00007F2AE27B3770 00007f305abc6360 [GCFrame: 00007f2ae27b3770]
00007F2AE27B37D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2ae27b37d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2AE27B3920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2AE27B3950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2AE27B3CA0 00007f30593044af [GCFrame: 00007f2ae27b3ca0]
00007F2AE27B3D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2ae27b3d70]
OS Thread Id: 0x1dc84
        Child SP               IP Call Site
00007F2AE1FB2680 00007f305abc6360 [GCFrame: 00007f2ae1fb2680]
00007F2AE1FB2770 00007f305abc6360 [GCFrame: 00007f2ae1fb2770]
00007F2AE1FB27D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2ae1fb27d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2AE1FB2920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2AE1FB2950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2AE1FB2CA0 00007f30593044af [GCFrame: 00007f2ae1fb2ca0]
00007F2AE1FB2D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2ae1fb2d70]
OS Thread Id: 0x1dc85
        Child SP               IP Call Site
00007F2AE17B1680 00007f305abc6360 [GCFrame: 00007f2ae17b1680]
00007F2AE17B1770 00007f305abc6360 [GCFrame: 00007f2ae17b1770]
00007F2AE17B17D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2ae17b17d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2AE17B1920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2AE17B1950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2AE17B1CA0 00007f30593044af [GCFrame: 00007f2ae17b1ca0]
00007F2AE17B1D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2ae17b1d70]
OS Thread Id: 0x1dc86
        Child SP               IP Call Site
00007F2AE0FB0680 00007f305abc6360 [GCFrame: 00007f2ae0fb0680]
00007F2AE0FB0770 00007f305abc6360 [GCFrame: 00007f2ae0fb0770]
00007F2AE0FB07D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2ae0fb07d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2AE0FB0920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2AE0FB0950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2AE0FB0CA0 00007f30593044af [GCFrame: 00007f2ae0fb0ca0]
00007F2AE0FB0D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2ae0fb0d70]
OS Thread Id: 0x1dc87
        Child SP               IP Call Site
00007F2AE07AF680 00007f305abc6360 [GCFrame: 00007f2ae07af680]
00007F2AE07AF770 00007f305abc6360 [GCFrame: 00007f2ae07af770]
00007F2AE07AF7D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2ae07af7d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2AE07AF920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2AE07AF950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2AE07AFCA0 00007f30593044af [GCFrame: 00007f2ae07afca0]
00007F2AE07AFD70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2ae07afd70]
OS Thread Id: 0x1dc88
        Child SP               IP Call Site
00007F2ADFFAE680 00007f305abc6360 [GCFrame: 00007f2adffae680]
00007F2ADFFAE770 00007f305abc6360 [GCFrame: 00007f2adffae770]
00007F2ADFFAE7D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2adffae7d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2ADFFAE920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2ADFFAE950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2ADFFAECA0 00007f30593044af [GCFrame: 00007f2adffaeca0]
00007F2ADFFAED70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2adffaed70]
...
...
...
```

Eye balling the callstacks for all 300+ threads shows a pattern where a majority of the threads share a common callstack:

```console
OS Thread Id: 0x1dc88
        Child SP               IP Call Site
00007F2ADFFAE680 00007f305abc6360 [GCFrame: 00007f2adffae680]
00007F2ADFFAE770 00007f305abc6360 [GCFrame: 00007f2adffae770]
00007F2ADFFAE7D0 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2adffae7d0] System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
00007F2ADFFAE920 00007F2FE392B31F testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_1() [/home/marioh/webapi/Controllers/diagscenario.cs @ 36]
00007F2ADFFAE950 00007F2FE392B46D System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 201]
00007F2ADFFAECA0 00007f30593044af [GCFrame: 00007f2adffaeca0]
00007F2ADFFAED70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2adffaed70]
```

The callstack seems to show that the request arrived in our deadlock method that in turn makes a call to `Monitor.ReliableEnter`. This method indicates that the threads are trying to enter a monitor lock. They're waiting on the availability of the lock. It's likely locked by a different thread.

The next step then is to find out which thread is actually holding the monitor lock. Since monitors typically store lock information in the sync block table, we can use the `syncblk` command to get more information:

```console
> syncblk
Index         SyncBlock MonitorHeld Recursion Owning Thread Info          SyncBlock Owner
   41 000000000143D038          603         1 00007F2B542D28C0 1dc1d  20   00007f2e90080fb8 System.Object
   42 000000000143D080            3         1 00007F2B400016A0 1dc1e  21   00007f2e90080fd0 System.Object
-----------------------------
Total           264
Free            0

```

The two interesting columns are the `MonitorHeld` and the `Owning Thread Info` columns. The `MonitorHeld` shows whether a monitor lock is acquired by a thread and the number of waiting threads. The `Owning Thread Info` shows which thread currently owns the monitor lock. The thread info has three different sub-columns. The second sub-column shows operating system thread ID.

At this point, we know two different threads (0x1dc1d and 0x1dc1e) hold a monitor lock. The next step is to take a look at what those threads are doing. We need to check if they're stuck indefinitely holding the lock. Let's use the `setthread` and `clrstack` commands to switch to each of the threads and display the callstacks:

```console
> setthread 0x1dc1d
> clrstack
OS Thread Id: 0x1dc1d (20)
        Child SP               IP Call Site
00007F2B862B9610 00007f305abc6360 [GCFrame: 00007f2b862b9610]
00007F2B862B9700 00007f305abc6360 [GCFrame: 00007f2b862b9700]
00007F2B862B9760 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2b862b9760] System.Threading.Monitor.Enter(System.Object)
00007F2B862B98B0 00007F2FE392A9E5 testwebapi.Controllers.DiagScenarioController.DeadlockFunc() [/home/marioh/webapi/Controllers/diagscenario.cs @ 57]
00007F2B862B98F0 00007F2FE392A8FC testwebapi.Controllers.DiagScenarioController.<deadlock>b__3_0() [/home/marioh/webapi/Controllers/diagscenario.cs @ 27]
00007F2B862B9910 00007F2FE02B7BA2 System.Threading.ThreadHelper.ThreadStart_Context(System.Object) [/__w/3/s/src/System.Private.CoreLib/src/System/Threading/Thread.CoreCLR.cs @ 51]
00007F2B862B9930 00007F2FE02C1021 System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 172]
00007F2B862B9980 00007F2FE02B7CBE System.Threading.ThreadHelper.ThreadStart() [/__w/3/s/src/System.Private.CoreLib/src/System/Threading/Thread.CoreCLR.cs @ 101]
00007F2B862B9CA0 00007f30593044af [GCFrame: 00007f2b862b9ca0]
00007F2B862B9D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2b862b9d70]
```

Lets look at the first thread. The deadlock function is waiting to acquire a lock, but it already owns the lock. It's in deadlock waiting for the lock it already holds.

```console
> setthread 0x1dc1e
> clrstack
OS Thread Id: 0x1dc1e (21)
        Child SP               IP Call Site
00007F2B85AB8640 00007f305abc6360 [GCFrame: 00007f2b85ab8640]
00007F2B85AB8730 00007f305abc6360 [GCFrame: 00007f2b85ab8730]
00007F2B85AB8790 00007f305abc6360 [HelperMethodFrame_1OBJ: 00007f2b85ab8790] System.Threading.Monitor.Enter(System.Object)
00007F2B85AB88E0 00007F2FE392AAAE testwebapi.Controllers.DiagScenarioController.<DeadlockFunc>b__4_0() [/home/marioh/webapi/Controllers/diagscenario.cs @ 53]
00007F2B85AB8910 00007F2FE02B7BA2 System.Threading.ThreadHelper.ThreadStart_Context(System.Object) [/__w/3/s/src/System.Private.CoreLib/src/System/Threading/Thread.CoreCLR.cs @ 51]
00007F2B85AB8930 00007F2FE02C1021 System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object) [/__w/3/s/src/System.Private.CoreLib/shared/System/Threading/ExecutionContext.cs @ 172]
00007F2B85AB8980 00007F2FE02B7CBE System.Threading.ThreadHelper.ThreadStart() [/__w/3/s/src/System.Private.CoreLib/src/System/Threading/Thread.CoreCLR.cs @ 101]
00007F2B85AB8CA0 00007f30593044af [GCFrame: 00007f2b85ab8ca0]
00007F2B85AB8D70 00007f30593044af [DebuggerU2MCatchHandlerFrame: 00007f2b85ab8d70]

```

The second thread is similar. It's also trying to acquire a lock that it already owns.

The remaining 300+ threads that are all waiting are most likely also waiting on one of the locks that caused the deadlock.
