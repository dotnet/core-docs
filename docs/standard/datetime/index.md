---
title: Dates, Times, and Time Zones
description: Dates, Times, and Time Zones
keywords: .NET, .NET Core
author: shoag
manager: wpickett
ms.date: 06/20/2016
ms.topic: article
ms.prod: .net-core
ms.technology: .net-core-technologies
ms.devlang: dotnet
ms.assetid: f7c9a2db-ba7e-417a-bd47-6490bdfec7d2
---

# Dates, Times, and Time Zones

In addition to the basic [System.DateTime](https://docs.microsoft.com/dotnet/core/api/System.DateTime) structure, .NET Core provides the following classes that support working with time zones:

* [System.TimeZoneInfo](https://docs.microsoft.com/dotnet/core/api/System.TimeZoneInfo)
    
  Use this class to work with the system's local time zone and the Coordinated Universal Time (UTC) zone.
  
* [System.DateTimeOffset](https://docs.microsoft.com/dotnet/core/api/System.DateTimeOffset)  

  Use this structure to work with dates and times whose offset (or difference) from UTC is known. The `DateTimeOffset` structure combines a date and time value with that time's offset from UTC. Because of its relationship to UTC, an individual date and time value unambiguously identifies a single point in time. This makes a `DateTimeOffset` value more portable from one computer to another than a `DateTime` value. 
  
This section of the documentation provides the information that you need to work with time zones and to create time zone-aware applications that can convert dates and times from one time zone to another.

## In This Section

[Time Zone Overview](time-zone-overview.md) - Discusses the terminology, concepts, and issues involved in creating time zone-aware applications.
    
[Choosing Between DateTime, DateTimeOffset, TimeSpan, and TimeZoneInfo](choosing-between-datetime.md) - Discusses when to use the `DateTime`, `DateTimeOffset`, and `TimeZoneInfo` types when working with date and time data.
    
[Finding the Time Zones Defined on a Local System](finding-the-time-zones-on-local-system.md) - Describes how to enumerate the time zones found on a local system.

[Instantiating a DateTimeOffset Object](instantiating-a-datetimeoffset-object.md) - Discusses the ways in which a `DateTimeOffset` object can be instantiated, and the ways in which a `DateTime` value can be converted to a `DateTimeOffset` value.

[Performing Arithmetic Operations with Dates and Times](performing-arithmetic-operations.md) - Discusses the issues involved in adding, subtracting, and comparing `DateTime` and `DateTimeOffset` values.

[Converting Between DateTime and DateTimeOffset](converting-between-datetime-and-offset.md) - Describes how to convert between `DateTime` and `DateTimeOffset` values.

[Converting Times Between Time Zones](converting-between-time-zones.md) - Describes how to convert times from one time zone to another.

## Related Topics

[How to: Enumerate Time Zones Present on a Computer](enumerate-time-zones.md) - Provides examples that enumerate the time zones defined in a computer's registry and that let users select a predefined time zone from a list.

[How to: Access the Predefined UTC and Local Time Zone Objects](access-utc-and-local.md) - Describes how to access Coordinated Universal Time and the local time zone.

[How to: Instantiate a TimeZoneInfo Object](instantiate-time-zone-info.md) - Describes how to instantiate a `TimeZoneInfo` object from the local system registry.

[How to: Use Time Zones in Date and Time Arithmetic](use-time-zones-in-arithmetic.md) - Discusses how to perform date and time arithmetic that reflects a time zone's adjustment rules.

[How to: Resolve Ambiguous Times](resolve-ambiguous-times.md) - Describes how to resolve an ambiguous time by mapping it to the time zone's standard time.

[How to: Let Users Resolve Ambiguous Times](let-users-resolve-ambiguous-times.md) - Describes how to let a user determine the mapping between an ambiguous local time and Coordinated Universal Time.

## Reference

[System.TimeZoneInfo](https://docs.microsoft.com/dotnet/core/api/System.TimeZoneInfo)

[System.DateTimeOffset](https://docs.microsoft.com/dotnet/core/api/System.DateTimeOffset)

[System.DateTime](https://docs.microsoft.com/dotnet/core/api/System.DateTime)
