---
title: Networking config settings
description: Learn about run-time settings that configure networking for .NET Core apps.
ms.date: 11/27/2019
ms.topic: reference
---
# Run-time configuration options for networking

## HTTP/2 protocol

- Configures whether support for the HTTP/2 protocol is enabled.
- Default: Disabled (`false`).
- Introduced in .NET Core 3.0.

| | Setting name | Values |
| - | - | - |
| **runtimeconfig.json** | `System.Net.Http.SocketsHttpHandler.Http2Support` | `false` - disabled<br/>`true` - enabled |
| **Environment variable** | `DOTNET_SYSTEM_NET_HTTP_SOCKETSHTTPHANDLER_HTTP2SUPPORT` | `0` - disabled<br/>`1` - enabled |

## UseSocketsHttpHandler

- Configures whether high-level networking APIs, such as <xref:System.Net.Http.HttpClient>, use <xref:System.Net.Http.SocketsHttpHandler?displayProperty=nameWithType> or older HTTP protocol stacks (<xref:System.Net.Http.WinHttpHandler> on Windows and `CurlHandler`, an internal class implemented on top of [libcurl](https://curl.haxx.se/libcurl/), on Linux).
- Default: Use <xref:System.Net.Http.SocketsHttpHandler?displayProperty=nameWithType> (`true`).
- You can configure this setting programmatically by calling the <xref:System.AppContext.SetSwitch%2A?displayProperty=nameWithType> method.

| | Setting name | Values |
| - | - | - |
| **runtimeconfig.json** | `System.Net.Http.UseSocketsHttpHandler` | `true` - enables the use of <xref:System.Net.Http.SocketsHttpHandler><br/>`false` - enables the use of <xref:System.Net.Http.HttpClientHandler> |
| **Environment variable** | `DOTNET_SYSTEM_NET_HTTP_USESOCKETSHTTPHANDLER` | `1` - enables the use of <xref:System.Net.Http.SocketsHttpHandler><br/>`0` - enables the use of <xref:System.Net.Http.HttpClientHandler> |

> [!NOTE]
> Starting in .NET 5, the `System.Net.Http.UseSocketsHttpHandler` setting is no longer available.
