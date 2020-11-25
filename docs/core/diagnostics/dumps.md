---
title: Dumps - .NET
description: An introduction to dumps in .NET.
ms.date: 10/12/2020
---

# Dumps

A dump is a file that contains snapshot of the process at the time it was created and can be useful for examining the state of your application. Dumps can be used for post-mortem debugging of your .NET application when it is difficult to attach a debugger to it such as production or CI environments. Using dumps allows you to capture the state of the problematic process and examine it without having to stop the application.

## Collect dumps

Dumps can be collected in a variety of ways depending on which platform you are running your app on.

> [!NOTE]
> Collecting a dump inside a container requires PTRACE capability, which can be added via `--cap-add=SYS_PTRACE` or `--privileged`.

### Using dotnet-dump

`dotnet-dump` is a CLI tool that allows you to collect and analyze dumps. For more information on how to use it to collect dumps with `dotnet-dump`, see [Dump collection and analysis utility](dotnet-dump.md)

### Using environment variables

For some situations, it may be more desirable to use environment variables to collect dumps. For example, capturing a dump when an exception is thrown helps you identify an issue by examining the state of the app when it crashed.

The following table shows the environment variables you can configure for collecting dumps.

|Environment variable|Description|Default value|
|-------|---------|---|
|`COMPlus_DbgEnableMiniDump`|If set to 1, enable core dump generation.|0|
|`COMPlus_DbgMiniDumpType`|Type of dump to be collected. For more information, see [Types of dumps](#types-of-dumps-in-.net).|2 (`MiniDumpWithPrivateReadWriteMemory`)|
|`COMPlus_DbgMiniDumpName`|Path to a file to write the dump to.|`/tmp/coredump.<pid>`|
|`COMPlus_CreateDumpDiagnostics`|If set to 1, enable diagnostic logging of dump process.|0|

### Types of dumps in .NET

You can collect different types of the dump depending on the purpose. This can be configured with the `COMPlus_DbgMiniDumpType` when using environment variable, or the `--type` flag when you are using `dotnet-dump`. The following table shows the types of dumps you can collect in .NET.

|Value|Name|Description|
|-----|----|-----------|
|1|`MiniDumpNormal`|Include just the information necessary to capture stack traces for all existing threads in a process. Limited GC heap memory and information.|
|2|`MiniDumpWithPrivateReadWriteMemory`|Includes the GC heaps and information necessary to capture stack traces for all existing threads in a process.|
|3|`MiniDumpFilterTriage`|Include just the information necessary to capture stack traces for all existing threads in a process. Limited GC heap memory and information.|
|4|`MiniDumpWithFullMemory`|Include all accessible memory in the process. The raw memory data is included at the end, so that the initial structures can be mapped directly without the raw memory information. This option can result in a very large file.|

## Analyze dumps

Dumps can be analyzed using [`dotnet-dump`](dotnet-dump.md).

## See also

Learn more about how you can leverage dumps to help diagnosing problems in your .NET application.

* [Debug Linux dumps](debug-linux-dumps.md) tutorial walks you through how to debug a dump that was collected in Linux.

* [Debug deadlock](debug-deadlock.md) tutorial walks you through how to debug a deadlock in your .NET application using dumps.
