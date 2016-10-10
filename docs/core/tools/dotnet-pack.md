---
title: dotnet-pack
description: dotnet-pack
keywords: .NET, .NET Core
author: mairaw
manager: wpickett
ms.date: 09/27/2016
ms.topic: article
ms.prod: .net-core
ms.technology: .net-core-technologies
ms.devlang: dotnet
ms.assetid: 8b4b8cef-f56c-4a10-aa01-fde8bfaae53e
---

dotnet-pack
===========

## NAME

`dotnet-pack` - Packs the code into a NuGet package

## SYNOPSIS

`dotnet pack [--output]  
    [--no-build] [--build-base-path]  
    [--configuration]  [--version-suffix]
    [<project>]`  

## DESCRIPTION

The `dotnet pack` command builds the project and creates NuGet packages. The result of this operation is two packages with the `nupkg` extension. One package contains the code and the other contains the debug symbols. 

NuGet dependencies of the project being packed are added to the nuspec file, so they are able to be resolved when the package is installed. 
Project-to-project references are not packaged inside the project. Currently, you need to have a package per project if you have project-to-project dependencies.

`dotnet pack` by default first builds the project. If you wish to avoid this, pass the `--no-build` option. This can be useful in Continuous Integration (CI) build scenarios in which you know the code was just previously built, for example. 

## OPTIONS

`[project]` 
    
The project to pack. It can be either a path to a `project.json` file or to a directory. If omitted, it will
default to the current directory. 

`-o`, `--output` [DIR]

Places the built packages in the directory specified. 

`--no-build`

Skips the building phase of the packing process. 

`--build-base-path`

Places the temporary build artifacts in the specified directory. By default, they go to the obj directory in the current directory. 

`-c`, `--configuration [Debug|Release]`

Configuration to use when building the project. If not specified, will default to "Debug".

`--version-suffix`

Updates the star in `-*` package version suffix with a specified string.

## EXAMPLES

`dotnet pack`

Packs the current project.

`dotnet pack ~/projects/app1/project.json`
    
Packs the app1 project.
	
`dotnet pack --output nupkgs`
    
Packs the current project and place the resulting packages into the specified folder.

`dotnet pack --no-build --output nupkgs`

Packs the current project into the specified folder and skips the build step.

`dotnet pack --version-suffix "ci-1234"`

Packs the current project and updates the resulting packages version with the given suffix. For example, version `1.0.0-*` will be updated to `1.0.0-ci-1234`.