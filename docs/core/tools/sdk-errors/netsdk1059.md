---
title: "NETSDK1059: Project contains obsolete .NET CLI tool"
description: How to resolve the issue of a project containing an obsolete .NET CLI tool.
author: sfoslund
ms.topic: error-reference
ms.date: 10/09/2020
f1_keywords:
- NETSDK1059
---
# NETSDK1059: Project contains obsolete .NET CLI tool

**This article applies to:** ✔️ .NET Core 2.1.100 SDK and later versions

When the .NET SDK issues warning NETSDK1059, your project contains an obsolete .NET CLI tool. As of .NET Core 2.1, these tools are included in the .NET SDK and do not need to be explicitly referenced by the project. More information for migrating to .NET Core 2.1 can be found [here](https://aka.ms/dotnetclitools-in-box).
