---
title: C# language versioning - C# Guide
description: Learn about how the C# language version is determined based on your project and the reasons behind that choice. Learn how to override the default manually.
ms.date: 02/21/2020
---

# C# language versioning

The latest C# compiler determines a default language version based on your project's target framework or frameworks. Visual Studio doesn't provide a UI to change the value, but you can change it by editing the *csproj* file. The choice of default ensures that you use the latest language version compatible with your target framework. You benefit from access to the latest language features compatible with your project's target. This default choice also ensures you don't use a language that requires types or runtime behavior not available in your target framework. Choosing a language version newer than the default can cause hard to diagnose compile-time and runtime errors.

The rules in this article apply to the compiler delivered with Visual Studio 2019 or the .NET Core 3.0 SDK. The C# compilers that are part of the Visual Studio 2017 installation or earlier .NET Core SDK versions target C# 7.0 by default.

C# 8.0 (and higher) is supported only on .NET Core 3.x and newer versions. Many of the newest features require library and runtime features introduced in .NET Core 3.x:

- Default interface member implementation requires new features in the .NET Core 3.0 CLR.
- Async streams require the new types <xref:System.IAsyncDisposable?displayProperty=nameWithType>, <xref:System.Collections.Generic.IAsyncEnumerable%601?displayProperty=nameWithType>, and <xref:System.Collections.Generic.IAsyncEnumerator%601?displayProperty=nameWithType>.
- Indexes and Ranges require the new types <xref:System.Index?displayProperty=nameWithType> and <xref:System.Range?displayProperty=nameWithType>.
- Nullable reference types make use of several [attributes](attributes/nullable-analysis.md) to provide better warnings. Those attributes were added in .NET Core 3.0. Other target frameworks haven't been annotated with any of these attributes. That means nullable warnings may not accurately reflect potential issues.

## Defaults

The compiler determines a default based on these rules:

|Target framework|version|C# language version default|
|----------------|-------|---------------------------|
|.NET Core|3.x|C# 8.0|
|.NET Core|2.x|C# 7.3|
|.NET Standard|2.1|C# 8.0|
|.NET Standard|2.0|C# 7.3|
|.NET Standard|1.x|C# 7.3|
|.NET Framework|all|C# 7.3|

When your project targets a preview framework that has a corresponding preview language version, the language version used is the preview language version. You use the latest features with that preview in any environment, without affecting projects that target a released .NET Core version.

## Override a default

If you must specify your C# version explicitly, you can do so in several ways:

- Manually edit your [project file](#edit-the-project-file).
- Set the language version [for multiple projects in a subdirectory](#configure-multiple-projects).
- Configure the [`-langversion` compiler option](compiler-options/langversion-compiler-option.md).

### Edit the project file

You can set the language version in your project file. For example, if you explicitly want access to preview features, add an element like this:

```xml
<PropertyGroup>
   <LangVersion>preview</LangVersion>
</PropertyGroup>
```

The value `preview` uses the latest available preview C# language version that your compiler supports.

### Configure multiple projects

To configure multiple projects, you can create a **Directory.Build.props** file that contains the `<LangVersion>` element. You typically do that in your solution directory. Add the following to a **Directory.Build.props** file in your solution directory:

```xml
<Project>
 <PropertyGroup>
   <LangVersion>preview</LangVersion>
 </PropertyGroup>
</Project>
```

Builds in all subdirectories of the directory containing that file will use the preview C# version. For more information, see the article on [Customize your build](/visualstudio/msbuild/customize-your-build).

## C# language version reference

The following table shows all current C# language versions. Your compiler may not necessarily understand every value if it's older. If you install .NET Core 3.0 or later, then you have access to everything listed.

|Value|Meaning|
|------------|-------------|
|preview|The compiler accepts all valid language syntax from the latest preview version.|
|latest|The compiler accepts syntax from the latest released version of the compiler (including minor version).|
|latestMajor|The compiler accepts syntax from the latest released major version of the compiler.|
|8.0|The compiler accepts only syntax that is included in C# 8.0 or lower.|
|7.3|The compiler accepts only syntax that is included in C# 7.3 or lower.|
|7.2|The compiler accepts only syntax that is included in C# 7.2 or lower.|
|7.1|The compiler accepts only syntax that is included in C# 7.1 or lower.|
|7|The compiler accepts only syntax that is included in C# 7.0 or lower.|
|6|The compiler accepts only syntax that is included in C# 6.0 or lower.|
|5|The compiler accepts only syntax that is included in C# 5.0 or lower.|
|4|The compiler accepts only syntax that is included in C# 4.0 or lower.|
|3|The compiler accepts only syntax that is included in C# 3.0 or lower.|
|ISO-2|The compiler accepts only syntax that is included in ISO/IEC 23270:2006 C# (2.0). |
|ISO-1|The compiler accepts only syntax that is included in ISO/IEC 23270:2003 C# (1.0/1.2). |
