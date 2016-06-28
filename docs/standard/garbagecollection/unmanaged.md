---
title: Cleaning Up Unmanaged Resources
description: Cleaning Up Unmanaged Resources
keywords: .NET, .NET Core
author: shoag
manager: wpickett
ms.date: 06/20/2016
ms.topic: article
ms.prod: .net-core
ms.technology: .net-core-technologies
ms.devlang: dotnet
ms.assetid: ac685b07-c5a8-4693-b27c-1549cc8ab3e6
---

# Cleaning Up Unmanaged Resources

For the majority of the objects that your app creates, you can rely on the .NET garbage collector to handle memory management. However, when you create objects that include unmanaged resources, you must explicitly release those resources when you finish using them in your app. The most common types of unmanaged resource are objects that wrap operating system resources, such as files, windows, network connections, or database connections. Although the garbage collector is able to track the lifetime of an object that encapsulates an unmanaged resource, it doesn't know how to release and clean up the unmanaged resource. 

If your types use unmanaged resources, you should do the following: 

* Implement the dispose pattern. This requires that you provide an [IDisposable.Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) implementation to enable the deterministic release of unmanaged resources. A consumer of your type calls [Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) when the object (and the resources it uses) is no longer needed. The [Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) method immediately releases the unmanaged resources. 

* Provide for your unmanaged resources to be released in the event that a consumer of your type forgets to call [Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose). There are two ways to do this: 

	* Use a safe handle to wrap your unmanaged resource. This is the recommended technique. Safe handles are derived from the [System.Runtime.InteropServices.SafeHandle](https://docs.microsoft.com/dotnet/core/api/System.Runtime.InteropServices.SafeHandle) class and include a robust [Finalize](https://docs.microsoft.com/dotnet/core/api/System.Object#System_Object_Finalize) method. When you use a safe handle, you simply implement the [IDisposable](https://docs.microsoft.com/dotnet/core/api/System.IDisposable) interface and call your safe handle's [Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) method in your [IDisposable.Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) implementation. The safe handle's finalizer is called automatically by the garbage collector if its [Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) method is not called. 

      —or—

	* Override the [Object.Finalize](https://docs.microsoft.com/dotnet/core/api/System.Object#System_Object_Finalize) method. Finalization enables the non-deterministic release of unmanaged resources when the consumer of a type fails to call [IDisposable.Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) to dispose of them deterministically. However, because object finalization can be a complex and error-prone operation, we recommend that you use a safe handle instead of providing your own finalizer. 

Consumers of your type can then call your [IDisposable.Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) implementation directly to free memory used by unmanaged resources. When you properly implement a [Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) method, either your safe handle's [Finalize](https://docs.microsoft.com/dotnet/core/api/System.Object#System_Object_Finalize) method or your own override of the [Object.Finalize](https://docs.microsoft.com/dotnet/core/api/System.Object#System_Object_Finalize) method becomes a safeguard to clean up resources in the event that the [Dispose](https://docs.microsoft.com/dotnet/core/api/System.IDisposable#System_IDisposable_Dispose) method is not called. 

## In This Section

[Implementing a Dispose Method](implementing-dispose.md) - Describes how to implement the dispose pattern for releasing unmanaged resources.

[Using Objects That Implement IDisposable](using-objects.md) - Describes how consumers of a type ensure that its Dispose implementation is called. We recommend using the C# using statement or the Visual Basic Using statement to do this.

## Reference

[System.IDisposable](https://docs.microsoft.com/dotnet/core/api/System.IDisposable) - Defines the `Dispose` method for releasing unmanaged resources.

[Object.Finalize](https://docs.microsoft.com/dotnet/core/api/System.Object#System_Object_Finalize) - Provides for object finalization if unmanaged resources are not released by the `Dispose` method. 

[GC.SuppressFinalize](https://docs.microsoft.com/dotnet/core/api/System.GC#System_GC_SuppressFinalize_System_Object_) - Suppresses finalization. This method is customarily called from a `Dispose` method to prevent a finalizer from executing. 
