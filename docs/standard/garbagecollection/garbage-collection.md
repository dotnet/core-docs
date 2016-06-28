---
title: Garbage Collection
description: Garbage Collection
keywords: .NET, .NET Core
author: shoag
manager: wpickett
ms.date: 06/20/2016
ms.topic: article
ms.prod: .net-core
ms.technology: .net-core-technologies
ms.devlang: dotnet
ms.assetid: fc93a2f8-58ff-4648-a534-33911b3efadb

---

# Garbage Collection

The .NET garbage collector manages the allocation and release of memory for your application. Each time you create a new object, the Common Language Runtime allocates memory for the object from the managed heap. As long as address space is available in the managed heap, the runtime continues to allocate space for new objects. However, memory is not infinite. Eventually the garbage collector must perform a collection in order to free some memory. The garbage collector's optimizing engine determines the best time to perform a collection, based upon the allocations being made. When the garbage collector performs a collection, it checks for objects in the managed heap that are no longer being used by the application and performs the necessary operations to reclaim their memory.

## Related Topics

Title | Description
----- | ----------- 
[Fundamentals of Garbage Collection](fundamentals.md) | Describes how garbage collection works, how objects are allocated on the managed heap, and other core concepts.
[Induced Collections](induced.md) | Describes how to make a garbage collection occur.
[Latency Modes](latency.md) | Describes the modes that determine the intrusiveness of garbage collection.
[Weak References](weak-references.md) | Describes features that permit the garbage collector to collect an object while still allowing the application to access that object.
 
## Reference

[System.GC](https://docs.microsoft.com/dotnet/core/api/System.GC)

[System.GCCollectionMode](https://docs.microsoft.com/dotnet/core/api/System.GCCollectionMode)

[System.Runtime.GCLatencyMode](https://docs.microsoft.com/dotnet/core/api/System.Runtime.GCLatencyMode)

[System.Runtime.GCSettings](https://docs.microsoft.com/dotnet/core/api/System.Runtime.GCSettings)

[GCSettings.LargeObjectHeapCompactionMode](https://docs.microsoft.com/dotnet/core/api/System.Runtime.GCSettingsGCSettings.LargeObjectHeapCompactionMode)

[Object.Finalize](https://docs.microsoft.com/dotnet/core/api/System.Object#System_Object_Finalize)

[System.IDisposable](https://docs.microsoft.com/dotnet/core/api/System.IDisposable)

## See Also

[Cleaning Up Unmanaged Resources](unmanaged.md)
