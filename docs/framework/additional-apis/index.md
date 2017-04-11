---
title: "Additional Class Libraries and APIs | Microsoft Docs"
ms.custom: ""
ms.date: "03/30/2017"
ms.prod: ".net-framework-oob"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "dotnet-clr"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Additional class libraries"
  - "Additional managed libraries"
  - ".NET Framework out-of-band releases"
  - "out-of-band releases"
ms.assetid: cf2d9006-b631-4e5d-81cd-20aab78c60f1
caps.latest.revision: 12
author: "mairaw"
ms.author: "mairaw"
manager: "wpickett"
---
# Additional Class Libraries and APIs
The .NET Framework is constantly evolving and in order to improve cross-platform development or to introduce new functionality early to our customers, we release new features out of band (OOB). This topic lists the OOB projects that we provide documentation for.  
  
 In addition, some libraries target specific platforms or implementations of the .NET Framework. For example, the
 [CodePagesEncodingProvider Class](CodePagesEncodingProvider.xml) class  makes code page encodings available to UWP apps developed using the .NET Framework. This topic lists these libraries as well.  
  
## OOB projects  
  
|Project|Description|  
|-------------|-----------------|  
|[System.Collections.Immutable](System.Collections.Immutable.xml)|Provides collections that are thread safe and guaranteed to never change their contents.|  
|[System.Net.Http.WinHttpHandler](http://go.microsoft.com/fwlink/p/?LinkId=624833)|Provides a message handler for [HttpClient Class](HttpClient.xml) based on the WinHTTP interface of Windows.|  
<!-- todo: fix link -->
|`System.Numerics.Vectors1`|Provides a library of vector types that can take advantage of SIMD hardware-based acceleration.| 
<!-- restore this when the doc is found 
|[TPL Dataflow Library](../Topic/TPL%20Dataflow%20Library.md)|The TPL Dataflow Library provides dataflow components to help increase the robustness of concurrency-enabled applications.|  
-->

## Platform-specific libraries  
  
|Project|Description|  
|-------------|-----------------|  
|<xref:System.Text.CodePagesEncodingProvider>|Extends the <xref:System.Text.EncodingProvider> class to make code page encodings available to apps that target the Universal Windows Platform.|  
  
## Private APIs  
 These APIs support the product infrastructure and are not intended/supported to be used directly from your code.  
  
|API Name|  
|--------------|  
|[s_isDebuggerCheckDisabledForTestPurposes Field](../../../docs/framework/additional-apis/s-isdebuggercheckdisabledfortestpurposes-field.md)|  
|[DataMemberFieldEditor Class](../../../docs/framework/additional-apis/datamemberfieldeditor-class.md)|  
|[DataMemberListEditor Class](../../../docs/framework/additional-apis/datamemberlisteditor-class.md)|  
  
## See Also  
 [The .NET Framework and Out-of-Band Releases](../../../docs/framework/get-started/the-net-framework-and-out-of-band-releases.md)