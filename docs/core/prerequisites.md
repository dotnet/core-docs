---
title: Prerequisites for .NET Core on Windows, Linux, and macOS
description: Supported Windows, Linux, and macOS versions and .NET Core dependencies to develop, deploy, and run .NET Core applications.
author: leecow
ms.author: leecow
ms.date: 10/30/2019
zone_pivot_groups: operating-systems-set-one
---

# Prerequisites for .NET Core

This article provides information on what is required to install .NET Core. .NET Core can be installed on Windows, Linux, and macOS. You can code in your favorite text editor and produce cross-platform libraries and applications.

.NET Core is made up of two components, the runtime and the SDK. The **runtime** is required to run a .NET Core application that doesn't include the runtime. The **SDK** is required to build .NET Core applications.

There are different kinds of ways to develop .NET Core apps:

::: zone pivot="os-windows"

- [Command-line with your favorite editor](tutorials/using-with-xplat-cli.md)
- [Visual Studio](https://www.visualstudio.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2019)
- [Visual Studio Code](https://code.visualstudio.com/)

::: zone-end

::: zone pivot="os-linux"

- [Command-line with your favorite editor](tutorials/using-with-xplat-cli.md)
- [Visual Studio Code](https://code.visualstudio.com/)

::: zone-end

::: zone pivot="os-macos"

- [Command-line with your favorite editor](tutorials/using-with-xplat-cli.md)
- [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link).
- [Visual Studio Code](https://code.visualstudio.com/)

::: zone-end

You can download a standalone installer for each OS from the following links:

- [.NET Core 3.0 downloads](https://dotnet.microsoft.com/download/dotnet-core/3.0).
- [.NET Core 2.2 downloads](https://dotnet.microsoft.com/download/dotnet-core/2.2).
- [.NET Core 2.1 downloads](https://dotnet.microsoft.com/download/dotnet-core/2.1).

It's important to understand the [.NET Core support policy](https://dotnet.microsoft.com/platform/support/policy/dotnet-core) when choosing which version of .NET Core to develop apps for.

## Check if .NET Core installed

It's possible that the .NET Core SDK may already be installed on your OS. The .NET Core SDK might have been installed if you installed a development IDE, such as Visual Studio or Visual Studio for Mac. You can check what is installed by opening a terminal and running the `dotnet --list-sdks` command:

::: zone pivot="os-windows"

```console
dotnet --list-sdks

2.1.500 [C:\program files\dotnet\sdk]
2.1.502 [C:\program files\dotnet\sdk]
2.1.504 [C:\program files\dotnet\sdk]
2.1.600 [C:\program files\dotnet\sdk]
2.1.602 [C:\program files\dotnet\sdk]
2.2.101 [C:\program files\dotnet\sdk]
3.0.100 [C:\program files\dotnet\sdk]
```

::: zone-end

::: zone pivot="os-linux"

```bash
dotnet --list-sdks

2.1.500 [/home/user/dotnet/sdk]
2.1.502 [/home/user/dotnet/sdk]
2.1.504 [/home/user/dotnet/sdk]
2.1.600 [/home/user/dotnet/sdk]
2.1.602 [/home/user/dotnet/sdk]
2.2.101 [/home/user/dotnet/sdk]
3.0.100 [/home/user/dotnet/sdk]
```

::: zone-end

::: zone pivot="os-macos"

```bash
dotnet --list-sdks

2.1.500 [/usr/local/share/dotnet/sdk]
2.1.502 [/usr/local/share/dotnet/sdk]
2.1.504 [/usr/local/share/dotnet/sdk]
2.1.600 [/usr/local/share/dotnet/sdk]
2.1.602 [/usr/local/share/dotnet/sdk]
2.2.101 [/usr/local/share/dotnet/sdk]
3.0.100 [/usr/local/share/dotnet/sdk]
```

::: zone-end

You can also see what runtimes are installed with the command `dotnet --list-runtimes`.

## Dependencies

Depending on the OS you're using, you may need to install additional dependencies.

::: zone pivot="os-windows"

<!-- markdownlint-disable MD025 -->
<!-- markdownlint-disable MD024 -->

# [.NET Core 3.0](#tab/netcore30)

The following Windows operating systems are supported with .NET Core 3.0:

> [!NOTE]
> A `+` symbol represents the minimum version.

| OS                            | Version                        | Architectures   |
| ----------------------------- | ------------------------------ | --------------- |
| Windows Client                | 7 SP1+, 8.1                    | x64, x86        |
| Windows 10 Client             | Version 1607+                  | x64, x86        |
| Windows Server                | 2012 R2+                       | x64, x86        |
| Nano Server                   | Version 1803+                  | x64, ARM32      |

For more information about .NET Core 3.0 supported OS, distributions, and lifecycle policy, see [.NET Core 3.0 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/3.0/3.0-supported-os.md).

# [.NET Core 2.2](#tab/netcore22)

The following Windows operating systems are supported with .NET Core 2.2:

> [!NOTE]
> A `+` symbol represents the minimum version.

| OS                            | Version                        | Architectures   |
| ----------------------------- | ------------------------------ | --------------- |
| Windows Client                | 7 SP1+, 8.1                    | x64, x86        |
| Windows 10 Client             | Version 1607+                  | x64, x86        |
| Windows Server                | 2008 R2 SP1+                   | x64, x86        |
| Nano Server                   | Version 1709+                  | x64, ARM32      |

For more information about .NET Core 2.2 supported OS, distributions, and lifecycle policy, see [.NET Core 2.2 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/2.2/2.2-supported-os.md).

# [.NET Core 2.1](#tab/netcore21)

The following Windows operating systems are supported with .NET Core 2.1:

> [!NOTE]
> A `+` symbol represents the minimum version.

| OS                            | Version                        | Architectures   |
| ----------------------------- | ------------------------------ | --------------- |
| Windows Client                | 7 SP1+, 8.1                    | x64, x86        |
| Windows 10 Client             | Version 1607+                  | x64, x86        |
| Windows Server                | 2008 R2 SP1+                   | x64, x86        |

For more information about .NET Core 2.1 supported OS, distributions, and lifecycle policy, see [.NET Core 2.1 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/2.1/2.1-supported-os.md).

---

<!-- markdownlint-disable MD001 -->

### Windows 7 / 8.1 / Server 2008 R2

Additional dependencies are required if you're installing the .NET SDK or Runtime on the following Windows operating systems:

- Windows 7 SP1
- Windows 8.1
- Windows Server 2008 R2
- Windows Server 2012 R2

Install the following:

- [Microsoft Visual C++ 2015 Redistributable Update 3](https://www.microsoft.com/download/details.aspx?id=52685).
- [KB2533623](https://support.microsoft.com/help/2533623/microsoft-security-advisory-insecure-library-loading-could-allow-remot)

The requirements above are also required if you come across one of the following errors:

> The program can't start because api-ms-win-crt-runtime-l1-1-0.dll is missing from your computer. Try reinstalling the program to fix this problem.
>
> \- or -
>
> The library hostfxr.dll was found, but loading it from C:\\\<path_to_app>\\hostfxr.dll failed.

### Visual Studio

If you're using Visual Studio to develop .NET Core applications, the following table describes the minimum required version of Visual Studio based on the target .NET Core runtime.

| .NET Core SDK version | Visual Studio version                      |
| --------------------- | ------------------------------------------ |
| 3.0                   | Visual Studio 2019 version 16.3 or higher. |
| 2.2                   | Visual Studio 2017 version 15.9 or higher. |
| 2.1                   | Visual Studio 2017 version 15.7 or higher. |

To verify your Visual Studio version:

01. Open Visual Studio.
01. Select the **Help** menu > **About Microsoft Visual Studio**.
01. Read the version number from the **About** dialog.

::: zone-end

::: zone pivot="os-linux"

# [.NET Core 3.0](#tab/netcore30)

.NET Core 3.0 treats Linux as a single operating system. There's a single Linux build (per chip architecture) for supported Linux distributions.

.NET Core 3.0 is supported on the following Linux distributions/versions:

> [!NOTE]
> A `+` symbol represents the minimum version.

| OS                             | Version               | Architectures    |
| ------------------------------ | --------------------- | ---------------- |
| Red Hat Enterprise Linux       | 6, 7, 8               | x64 |
| CentOS                         | 7+                    | x64 |
| Oracle Linux                   | 7+                    | x64 |
| Fedora                         | 29+                   | x64 |
| Debian                         | 9+                    | x64, ARM32, ARM64 |
| Ubuntu                         | 16.04+                | x64, ARM32, ARM64 |
| Linux Mint                     | 18+                   | x64 |
| openSUSE                       | 15+                   | x64 |
| SUSE Enterprise Linux (SLES)   | 12 SP2+               | x64 |
| Alpine Linux                   | 3.8+                  | x64, ARM64 |

For more information about .NET Core 3.0 supported OS, distributions, and lifecycle policy, see [.NET Core 3.0 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/3.0/3.0-supported-os.md).

For more information about how to install .NET Core 3.0 on ARM64, see [Installing .NET Core 3.0 on Linux ARM64](https://gist.github.com/richlander/467813274cea8abc624553ee72b28213).

# [.NET Core 2.2](#tab/netcore22)

.NET Core 2.2 treats Linux as a single operating system. There's a single Linux build (per chip architecture) for supported Linux distributions.

.NET Core 2.2 is supported on the following Linux distributions/versions:

> [!NOTE]
> A `+` symbol represents the minimum version.

| OS                             |  Version                |  Architectures   |
| ------------------------------ | ----------------------- | ---------------- |
| Red Hat Enterprise Linux       |  6, 7                   | x64 |
| CentOS                         |  7                      | x64 |
| Oracle Linux                   |  7                      | x64 |
| Fedora                         |  29, 30                 | x64 |
| Debian                         |  9                      | x64, ARM32 |
| Ubuntu                         |  16.04, 18.04, 18.10, 19.04    | x64, ARM32 |
| Linux Mint                     |  17, 18                 | x64 |
| openSUSE                       |  15+                    | x64 |
| SUSE Enterprise Linux (SLES)   |  12 SP2+                | x64 |
| Alpine Linux                   |  3.7+                   | x64 |

For more information about .NET Core 2.2 supported OS, distributions, and lifecycle policy, see [.NET Core 2.2 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/2.2/2.2-supported-os.md).

# [.NET Core 2.1](#tab/netcore21)

.NET Core 2.1 treats Linux as a single operating system. There's a single Linux build (per chip architecture) for supported Linux distributions.

.NET Core 2.1 is supported on the following Linux distributions/versions:

> [!NOTE]
> A `+` symbol represents the minimum version.

| OS                             |  Version                |  Architectures   |
| ------------------------------ | ----------------------- | ---------------- |
| Red Hat Enterprise Linux       |  6, 7, 8                | x64 |
| CentOS                         |  7+                     | x64 |
| Oracle Linux                   |  7+                     | x64 |
| Fedora                         |  29+                    | x64 |
| Debian                         |  9                      | x64, ARM32 |
| Ubuntu                         |  16.04, 18.04, 19.04, 19.10    | x64, ARM32 |
| Linux Mint                     |  17+                    | x64 |
| openSUSE                       |  15+                    | x64 |
| SUSE Enterprise Linux (SLES)   |  12 SP2+                | x64 |
| Alpine Linux                   |  3.7+                   | x64 |

For more information about .NET Core 2.1 supported OS, distributions, and lifecycle policy, see [.NET Core 2.1 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/2.1/2.1-supported-os.md).

---

## Linux distribution dependencies

Based on your linux distribution, you may need to install additional dependencies.

> [!IMPORTANT]
> The exact versions and names may vary slightly on your Linux distribution of choice.

### Ubuntu

Ubuntu distributions require the following libraries installed:

- liblttng-ust0
- libcurl3 (for 14.x and 16.x)
- libcurl4 (for 18.x)
- libssl1.0.0
- libkrb5-3
- zlib1g
- libicu52 (for 14.x)
- libicu55 (for 16.x)
- libicu57 (for 17.x)
- libicu60 (for 18.x)

For .NET Core 2.0, following dependencies are also required:

- libunwind8
- libuuid1

For .NET Core applications that use the *System.Drawing.Common* assembly, you also need the following dependency:

- libgdiplus (version 6.0.1 or later)

> [!WARNING]
> Most versions of Ubuntu include an earlier version of libgdiplus. You can install a recent version
> of libgdiplus by adding the Mono repository to your system. For more information,
> see <https://www.mono-project.com/download/stable/>.

### CentOS and Fedora

CentOS distributions require the following libraries installed:

- lttng-ust
- libcurl
- openssl-libs
- krb5-libs
- libicu
- zlib

Fedora users: If your openssl's version >= 1.1, you'll need to install compat-openssl10.

For .NET Core 2.0, following dependencies are also required:

- libunwind
- libuuid

For more information about the dependencies, see [Self-contained Linux applications](https://github.com/dotnet/core/blob/master/Documentation/self-contained-linux-apps.md).

For .NET Core applications that use the *System.Drawing.Common* assembly, you'll also need the following dependency:

- libgdiplus (version 6.0.1 or later)

> [!WARNING]
> Most versions of CentOS and Fedora include an earlier version of libgdiplus. You can install a recent version
> of libgdiplus by adding the Mono repository to your system. For more information,
> see <https://www.mono-project.com/download/stable/>.

::: zone-end

::: zone pivot="os-macos"

# [.NET Core 3.0](#tab/netcore30)

.NET Core 3.0 is supported on **macOS High Sierra (version 10.13)** and later versions. An **x64** CPU architecture is required.

For more information about .NET Core 3.0 supported OS, distributions, and lifecycle policy, see [.NET Core 3.0 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/3.0/3.0-supported-os.md).

# [.NET Core 2.2](#tab/netcore22)

.NET Core 2.2 is supported on **macOS Sierra (version 10.12)** and later versions. An **x64** CPU architecture is required.

For more information about .NET Core 2.2 supported OS, distributions, and lifecycle policy, see [.NET Core 2.2 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/2.2/2.2-supported-os.md).

# [.NET Core 2.1](#tab/netcore21)

.NET Core 2.1 is supported on **macOS Sierra (version 10.12)** and later versions. An **x64** CPU architecture is required.

For more information about .NET Core 2.1 supported OS, distributions, and lifecycle policy, see [.NET Core 2.1 Supported OS Versions](https://github.com/dotnet/core/blob/master/release-notes/2.1/2.1-supported-os.md).

---

::: zone-end

::: zone pivot="os-windows"

## Install with Visual Studio

Visual Studio installs the latest .NET Core SDK tools, and one or more runtimes so you can target your app to run on the .NET Core runtime version of your choice.

Selecting any of the managed workloads for **Web**, **Desktop**, or **Azure development**, will install the .NET Core development tools and runtime. Specifically choosing the **.NET Core** workload also installs .NET Core.

[![Windows Visual Studio 2019 with .NET Core workload](media/prerequisites/windows-install-visual-studio-2019.png)](media/prerequisites/windows-install-visual-studio-2019.png#lightbox)

After you've installed Visual Studio, create your first app by following the [C# Hello World tutorial](tutorials/with-visual-studio.md) or the [Visual Basic Hello World tutorial](tutorials/vb-with-visual-studio.md).

::: zone-end

::: zone pivot="os-macos"

## Install with Visual Studio for Mac

Visual Studio for Mac installs the .NET Core SDK when the **.NET Core workload** is selected. To get started with .NET Core development on macOS, see [Install Visual Studio 2019 for Mac](https://docs.microsoft.com/visualstudio/mac/installation?view=vsmac-2019).

[![macOS Visual Studio 2019 for Mac with .NET Core workload feature](media/prerequisites/mac-install-selection.png)](media/prerequisites/mac-install-selection.png#lightbox)

After you've installed Visual Studio for Mac, create your first app by following the [Get started on macOS](tutorials/using-on-mac-vs.md) tutorial.

::: zone-end

## Install with Visual Studio Code

Visual Studio Code is a powerful and lightweight source code editor that runs on your desktop. VS Code is available for Windows, macOS, and Linux.

While VS Code doesn't come with .NET Core support, adding .NET Core support is simple.

01. [Download and install Visual Studio Code](https://code.visualstudio.com/Download).
01. [Download and install the .NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core/3.0).
01. [Install the C# extension from the VS Code marketplace](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp).

After you've installed .NET Core support for VS Code, create your first app by following the [Using .NET Core in Visual Studio Code](https://code.visualstudio.com/docs/languages/dotnet) tutorial.

::: zone pivot="os-windows"

## Install with PowerShell automation

The [dotnet-install scripts](./tools/dotnet-install-script.md) are used for a non-admin install of the CLI toolchain and the shared runtime. You can download the script from [dotnet-install script reference page](tools/dotnet-install-script.md).

The script defaults to installing the latest "LTS" version, which is currently .NET Core 2.1. To install the current release of .NET Core (3.0), run the script with the following switch:

```powershell
dotnet-install.ps1 -Channel LTS
```

The installer PowerShell script is used in automation scenarios and non-admin installations.

::: zone-end

::: zone pivot="os-linux"

## Install with native installers

.NET Core native installers are available for supported Linux distributions/versions. The native installers require admin (sudo) access to the server. The advantage of using a native installer is that all of the .NET Core native dependencies are installed. Native installers also install the .NET Core SDK system-wide.

On Linux, there are two installer package choices:

- Using a feed-based package manager, such as apt-get for Ubuntu, or yum for CentOS/RHEL.
- Using the packages themselves, DEB or RPM.

## Install with bash automation

The [dotnet-install scripts](./tools/dotnet-install-script.md) are used for a non-admin install of the CLI toolchain and the shared runtime. You can download the script from [dotnet-install script reference page](tools/dotnet-install-script.md).

The script defaults to installing the latest "LTS" version, which is currently .NET Core 2.1. To install the current release of .NET Core, which is 3.0, run the script with the following switch:

```bash
./dotnet-install.sh -c Current
```

The installer bash script is used in automation scenarios and non-admin installations.

::: zone-end


## Next steps

- [Get started with .NET Core](get-started.md)
