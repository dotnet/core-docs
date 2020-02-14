---
title: dotnet tool uninstall command
description: The dotnet tool uninstall command uninstalls the specified .NET Core tool from your machine.
ms.date: 02/14/2020
---
# dotnet tool uninstall

**This article applies to:** ✔️ .NET Core 2.1 SDK and later versions

## Name

`dotnet tool uninstall` - Uninstalls the specified [.NET Core tool](global-tools.md) from your machine.

## Synopsis

```dotnetcli
dotnet tool uninstall <PACKAGE_NAME> <-g|--global>
dotnet tool uninstall <PACKAGE_NAME> <--tool-path>
dotnet tool uninstall <PACKAGE_NAME>
dotnet tool uninstall <-h|--help>
```

## Description

The `dotnet tool uninstall` command provides a way for you to uninstall .NET Core tools from your machine.  To use the command, you specify one of the following:

* A global tool installed in the default location. Use the `--global` option
* A global tool installed in a custom location. Use the `--tool-path` option.
* A local tool. Omit the `--global` and `--tool-path` options.

**Local tools are available starting with .NET Core SDK 3.0.**

## Arguments

`PACKAGE_NAME`

Name/ID of the NuGet package that contains the .NET Core tool to uninstall. You can find the package name using the [dotnet tool list](dotnet-tool-list.md) command.

## Options

`-g|--global`

Specifies that the tool to be removed is from a user-wide installation. Can't be combined with the `--tool-path` option. Omitting both `--global` and `--tool-path` specifies that the tool to be removed is a local tool. 

`-h|--help`

Prints out a short help for the command.

`--tool-path <PATH>`

Specifies the location where to uninstall the tool. PATH can be absolute or relative. Can't be combined with the `--global` option. Omitting both `--global` and `--tool-path` specifies that the tool to be removed is a local tool. 

## Examples

Uninstalls the [dotnetsay](https://www.nuget.org/packages/dotnetsay/) global tool:

`dotnet tool uninstall -g dotnetsay`

Uninstalls the [dotnetsay](https://www.nuget.org/packages/dotnetsay/) global tool from a specific Windows folder:

`dotnet tool uninstall dotnetsay --tool-path c:\global-tools`

Uninstalls the [dotnetsay](https://www.nuget.org/packages/dotnetsay/) global tool from a specific Linux/macOS folder:

`dotnet tool uninstall dotnetsay --tool-path ~/bin`

## See also

- [.NET Core tools](global-tools.md)
