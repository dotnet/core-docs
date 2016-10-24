---
title: "C# Compiler Options Listed Alphabetically"
ms.custom: ""
ms.date: "2015-07-20"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "CSharp"
helpviewer_keywords: 
  - "compiler options [C#], listed alpabetically"
  - "C# language, compiler options listed alphabitically"
  - "Visual C# compiler, options listed alphabetically"
  - "Visual C#, compiler options listed alphabetically"
ms.assetid: 43535ea0-ca47-4a15-b528-615087a86092
caps.latest.revision: 25
author: "BillWagner"
ms.author: "wiwagn"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# C# Compiler Options Listed Alphabetically
The following compiler options are sorted alphabetically. For a categorical list, see [C# Compiler Options Listed by Category](../compiler-options/csharp-compiler-options-listed-by-category.md).  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../compiler-options/@--csharp-compiler-options-.md)|Reads a response file for more options.|  
|[/?](../compiler-options/-help------csharp-compiler-options-.md)|Displays a usage message to stdout.|  
|`/additionalfile`|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
|[/addmodule](../compiler-options/-addmodule--csharp-compiler-options-.md)|Links the specified modules into this assembly|  
|`/analyzer`|Run the analyzers from this assembly (Short form: /a)|  
|[/appconfig](../compiler-options/-appconfig--csharp-compiler-options-.md)|Specifies the location of app.config at assembly binding time.|  
|[/baseaddress](../compiler-options/-baseaddress--csharp-compiler-options-.md)|Specifies the base address for the library to be built.|  
|[/bugreport](../compiler-options/-bugreport--csharp-compiler-options-.md)|Creates a 'Bug Report' file. This file will be sent together with any crash information if it is used with **/errorreport:prompt** or **/errorreport:send**.|  
|[/checked](../compiler-options/-checked--csharp-compiler-options-.md)|Causes the compiler to generate overflow checks.|  
|`/checksumalgorithm:<alg>`|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
|[/codepage](../compiler-options/-codepage--csharp-compiler-options-.md)|Specifies the codepage to use when opening source files.|  
|[/debug](../compiler-options/-debug--csharp-compiler-options-.md)|Emits debugging information.|  
|[/define](../compiler-options/-define--csharp-compiler-options-.md)|Defines conditional compilation symbols.|  
|[/delaysign](../compiler-options/-delaysign--csharp-compiler-options-.md)|Delay-signs the assembly by using only the public part of the strong name key.|  
|[/doc](../compiler-options/-doc--csharp-compiler-options-.md)|Specifies an XML Documentation file to generate.|  
|[/errorreport](../compiler-options/-errorreport--csharp-compiler-options-.md)|Specifies how to handle internal compiler errors: prompt, send, or none. The default is none.|  
|[/filealign](../compiler-options/-filealign--csharp-compiler-options-.md)|Specifies the alignment used for output file sections.|  
|[/fullpaths](../compiler-options/-fullpaths--csharp-compiler-options-.md)|Causes the compiler to generate fully qualified paths.|  
|[/help](../compiler-options/-help------csharp-compiler-options-.md)|Displays a usage message to stdout.|  
|[/highentropyva](../compiler-options/-highentropyva--csharp-compiler-options-.md)|Specifies that high entropy ASLR is supported.|  
|**/incremental**|Enables incremental compilation [obsolete].|  
|[/keycontainer](../compiler-options/-keycontainer--csharp-compiler-options-.md)|Specifies a strong name key container.|  
|[/keyfile](../compiler-options/-keyfile--csharp-compiler-options-.md)|Specifies a strong name key file.|  
|[/langversion:\<string>](../compiler-options/-langversion--csharp-compiler-options-.md)|Specify language version mode: ISO-1, ISO-2, 3, 4, 5, 6, or Default|  
|[/lib](../compiler-options/-lib--csharp-compiler-options-.md)|Specifies additional directories in which to search for references.|  
|[/link](../compiler-options/-link--csharp-compiler-options-.md)|Makes COM type information in specified assemblies available to the project.|  
|[/linkresource](../compiler-options/-linkresource--csharp-compiler-options-.md)|Links the specified resource to this assembly.|  
|[/main](../compiler-options/-main--csharp-compiler-options-.md)|Specifies the type that contains the entry point (ignore all other possible entry points).|  
|[/moduleassemblyname](../compiler-options/-moduleassemblyname--csharp-compiler-option-.md)|Specifies an assembly whose non-public types a .netmodule can access.|  
|`/modulename:<string>`|Specify the name of the source module|  
|[/noconfig](../compiler-options/-noconfig--csharp-compiler-options-.md)|Instructs the compiler not to auto include CSC.RSP file.|  
|[/nologo](../compiler-options/-nologo--csharp-compiler-options-.md)|Suppresses compiler copyright message.|  
|[/nostdlib](../compiler-options/-nostdlib--csharp-compiler-options-.md)|Instructs the compiler not to reference standard library (mscorlib.dll).|  
|[/nowarn](../compiler-options/-nowarn--csharp-compiler-options-.md)|Disables specific warning messages|  
|[/nowin32manifest](../compiler-options/-nowin32manifest--csharp-compiler-options-.md)|Instructs the compiler not to embed an application manifest in the executable file.|  
|[/optimize](../compiler-options/-optimize--csharp-compiler-options-.md)|Enables/disables optimizations.|  
|[/out](../compiler-options/-out--csharp-compiler-options-.md)|Specifies the output file name (default: base name of file with main class or first file).|  
|`/parallel[+&#124;-]`|Specifies whether to use concurrent build (+).|  
|[/pdb](../compiler-options/-pdb--csharp-compiler-options-.md)|Specifies the file name and location of the .pdb file.|  
|[/platform](../compiler-options/-platform--csharp-compiler-options-.md)|Limits which platforms this code can run on: x86, Itanium, x64, anycpu, or anycpu32bitpreferred. The default is anycpu.|  
|[/preferreduilang](../compiler-options/-preferreduilang--csharp-compiler-options-.md)|Specifies the language to be used for compiler output.|  
|[/recurse](../compiler-options/-recurse--csharp-compiler-options-.md)|Includes all files in the current directory and subdirectories according to the wildcard specifications.|  
|[/reference](../compiler-options/-reference--csharp-compiler-options-.md)|References metadata from the specified assembly files.|  
|[/resource](../compiler-options/-resource--csharp-compiler-options-.md)|Embeds the specified resource.|  
|`/ruleset:<file>`|Specify a ruleset file that disables specific diagnostics.|  
|[/subsystemversion](../compiler-options/-subsystemversion--csharp-compiler-options-.md)|Specifies the minimum version of the subsystem that the executable file can use.|  
|[/target](../compiler-options/-target--csharp-compiler-options-.md)|Specifies the format of the output file by using one of four options:[/target:appcontainerexe](../compiler-options/-target-appcontainerexe--csharp-compiler-options-.md), [/target:exe](../compiler-options/-target-exe--csharp-compiler-options-.md), [/target:library](../compiler-options/-target-library--csharp-compiler-options-.md), [/target:module](../compiler-options/-target-module--csharp-compiler-options-.md), [/target:winexe](../compiler-options/-target-winexe--csharp-compiler-options-.md),  [/target:winmdobj](../compiler-options/-target-winmdobj--csharp-compiler-options-.md).|  
|[/unsafe](../compiler-options/-unsafe--csharp-compiler-options-.md)|Allows [unsafe](../keywords/unsafe--csharp-reference-.md) code.|  
|[/utf8output](../compiler-options/-utf8output--csharp-compiler-options-.md)|Outputs compiler messages in UTF-8 encoding.|  
|[/warn](../compiler-options/-warn--csharp-compiler-options-.md)|Sets the warning level (0-4).|  
|[/warnaserror](../compiler-options/-warnaserror--csharp-compiler-options-.md)|Reports specific warnings as errors.|  
|[/win32icon](../compiler-options/-win32icon--csharp-compiler-options-.md)|Uses this icon for the output.|  
|[/win32manifest](../compiler-options/-win32manifest--csharp-compiler-options-.md)|Specifies a custom win32 manifest file.|  
|[/win32res](../compiler-options/-win32res--csharp-compiler-options-.md)|Specifies the win32 resource file (.res).|  
  
## See Also  
 [C# Compiler Options](../compiler-options/csharp-compiler-options.md)   
 [C# Compiler Options Listed by Category](../compiler-options/csharp-compiler-options-listed-by-category.md)   
 [How to: Set Environment Variables for the Visual Studio Command Line](../compiler-options/how-to--set-environment-variables-for-the-visual-studio-command-line.md)   
 [\<compiler> Element](../Topic/%3Ccompiler%3E%20Element.md)