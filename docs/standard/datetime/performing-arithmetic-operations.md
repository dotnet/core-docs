---
title: Performing Arithmetic Operations with Dates and Times
description: Performing Arithmetic Operations with Dates and Times
keywords: .NET, .NET Core
author: shoag
manager: wpickett
ms.date: 06/20/2016
ms.topic: article
ms.prod: .net-core
ms.technology: .net-core-technologies
ms.devlang: dotnet
ms.assetid: 72beac2f-5296-4727-a176-b2fcc74a0725
---

# Performing Arithmetic Operations with Dates and Times

Although both the [System.DateTime](https://docs.microsoft.com/dotnet/core/api/System.DateTime) and the [System.DateTimeOffset](https://docs.microsoft.com/dotnet/core/api/System.DateTimeOffset) structures provide members that perform arithmetic operations on their values, the results of arithmetic operations are very different. This article examines those differences, relates them to degrees of time zone awareness in date and time data, and discusses how to perform fully time zone aware operations using date and time data.

## Comparisons and Arithmetic Operations with DateTime Values

[System.DateTime](https://docs.microsoft.com/dotnet/core/api/System.DateTime) values possess a limited degree of time zone awareness. The [DateTime.Kind](https://docs.microsoft.com/dotnet/core/api/System.DateTime#System_DateTime_Kind) property allows a [System.DateTimeKind](https://docs.microsoft.com/dotnet/core/api/System.DateTimeKind) value to be assigned to the date and time to indicate whether it represents local time, Coordinated Universal Time (UTC), or the time in an unspecified time zone. However, this limited time zone information is ignored when comparing or performing date and time arithmetic on `DateTime` values. The following example, which compares the current local time with the current UTC time, illustrates this.

```csharp
using System;

public enum TimeComparison
{
   EarlierThan = -1,
   TheSameAs = 0,
   LaterThan = 1
}

public class DateManipulation
{
   public static void Main()
   {
      DateTime localTime = DateTime.Now;
      DateTime utcTime = DateTime.UtcNow;

      Console.WriteLine("Difference between {0} and {1} time: {2}:{3} hours", 
                        localTime.Kind.ToString(), 
                        utcTime.Kind.ToString(), 
                        (localTime - utcTime).Hours, 
                        (localTime - utcTime).Minutes);
      Console.WriteLine("The {0} time is {1} the {2} time.", 
                        localTime.Kind.ToString(), 
                        Enum.GetName(typeof(TimeComparison), localTime.CompareTo(utcTime)), 
                        utcTime.Kind.ToString());  
   }
}
// If run in the U.S. Pacific Standard Time zone, the example displays 
// the following output to the console:
//    Difference between Local and Utc time: -7:0 hours
//    The Local time is EarlierThan the Utc time.
```

The [DateTime.CompareTo(DateTime)](https://docs.microsoft.com/dotnet/core/api/System.DateTime#System_DateTime_CompareTo_System_DateTime_) method reports that the local time is earlier than (or less than) the UTC time, and the subtraction operation indicates that the difference between UTC and the local time for a system in the U.S. Pacific Standard Time zone is seven hours. But because these two values provide different representations of a single point in time, it is clear in this case that this time interval is completely attributable to the local time zone's offset from UTC. 

More generally, the `DateTime.Kind` property does not affect the results returned by `DateTime` comparison and arithmetic methods (as the comparison of two identical points in time indicates), although it can affect the interpretation of those results. For example:

* The result of any arithmetic operation performed on two date and time values whose `DateTime.Kind` properties both equal [DateTimeKind.Utc](https://docs.microsoft.com/dotnet/core/api/System.DateTimeKind#System_DateTimeKind_Utc) reflects the actual time interval between the two values. Similarly, the comparison of two such date and time values accurately reflects the relationship between times.

* The result of any arithmetic or comparison operation performed on two date and time values whose `DateTime.Kind` properties both equal [DateTimeKind.Local](https://docs.microsoft.com/dotnet/core/api/System.DateTimeKind#System_DateTimeKind_Local) or on two date and time values with different `DateTime.Kind` property values reflects the difference in clock time between the two values. 

* Arithmetic or comparison operations on local date and time values do not consider whether a particular value is ambiguous or invalid, nor do they take account of the effect of any adjustment rules that result from the local time zone's transition to or from daylight saving time.

* Any operation that compares or calculates the difference between UTC and a local time includes a time interval equal to the local time zone's offset from UTC in the result. 

* Any operation that compares or calculates the difference between an unspecified time and either UTC or the local time reflects simple clock time. Time zone differences are not considered, and the result does not reflect the application of time zone adjustment rules. 

* Any operation that compares or calculates the difference between two unspecified times may include an unknown interval that reflects the difference between the time in two different time zones.

There are many scenarios in which time zone differences do not affect date and time calculations or in which the context of the date and time data defines the meaning of comparison or arithmetic operations. For a discussion of some of these, see [Choosing Between DateTime, DateTimeOffset, TimeSpan, and TimeZoneInfo](choosing-between-datetime.md).

## Comparisons and Arithmetic Operations with DateTimeOffset Values

A [System.DateTimeOffset](https://docs.microsoft.com/dotnet/core/api/System.DateTimeOffset) value includes not only a date and time, but also an offset that unambiguously defines that date and time relative to UTC. This makes it possible to define equality somewhat differently than for [System.DateTime](https://docs.microsoft.com/dotnet/core/api/System.DateTime) values. Whereas `DateTime` values are equal if they have the same date and time value, `DateTimeOffset` values are equal if they both refer to the same point in time. This makes a `DateTimeOffset` value more accurate and less in need of interpretation when used in comparisons and in most arithmetic operations that determine the interval between two dates and times. The following example, which is the `DateTimeOffset` equivalent to the previous example that compared local and UTC DateTime values, illustrates this difference in behavior.

```csharp
using System;

public enum TimeComparison
{
   EarlierThan = -1,
   TheSameAs = 0,
   LaterThan = 1
}

public class DateTimeOffsetManipulation
{
   public static void Main()
   {
      DateTimeOffset localTime = DateTimeOffset.Now;
      DateTimeOffset utcTime = DateTimeOffset.UtcNow;

      Console.WriteLine("Difference between local time and UTC: {0}:{1:D2} hours", 
                        (localTime - utcTime).Hours, 
                        (localTime - utcTime).Minutes);
      Console.WriteLine("The local time is {0} UTC.", 
                        Enum.GetName(typeof(TimeComparison), localTime.CompareTo(utcTime)));  
   }
}
// Regardless of the local time zone, the example displays 
// the following output to the console:
//    Difference between local time and UTC: 0:00 hours.
//    The local time is TheSameAs UTC.
```

In this example, the [DateTimeOffset.CompareTo](https://docs.microsoft.com/dotnet/core/api/System.DateTimeOffset#System_DateTimeOffset_CompareTo_System_DateTimeOffset_) method indicates that the current local time and the current UTC time are equal, and subtraction of `DateTimeOffset` values indicates that the difference between the two times is [TimeSpan.Zero](https://docs.microsoft.com/dotnet/core/api/System.TimeSpan#System_TimeSpan_Zero). 

The chief limitation of using `DateTimeOffset` values in date and time arithmetic is that although `DateTimeOffset` values have some time zone awareness, they are not fully time zone aware. Although the `DateTimeOffset` value's offset reflects a time zone's offset from UTC when a `DateTimeOffset` variable is first assigned a value, it becomes disassociated from the time zone thereafter. Because it is no longer directly associated with an identifiable time, the addition and subtraction of date and time intervals does not consider a time zone's adjustment rules. 

To illustrate, the transition to daylight saving time in the U.S. Central Standard Time zone occurs at 2:00 A.M. on March 9, 2008. This means that adding a two and a half hour interval to a Central Standard time of 1:30 A.M. on March 9, 2008, should produce a date and time of 5:00 A.M. on March 9, 2008. However, as the following example shows, the result of the addition is 4:00 A.M. on March 9, 2008. Note that this result of this operation does represent the correct point in time, although it is not the time in the time zone in which we are interested (that is, it does not have the expected time zone offset).

```csharp
using System;

public class IntervalArithmetic
{
   public static void Main()
   {
      DateTime generalTime = new DateTime(2008, 3, 9, 1, 30, 0);
      const string tzName = "Central Standard Time";
      TimeSpan twoAndAHalfHours = new TimeSpan(2, 30, 0);

      // Instantiate DateTimeOffset value to have correct CST offset
      try
      {
         DateTimeOffset centralTime1 = new DateTimeOffset(generalTime, 
                    TimeZoneInfo.FindSystemTimeZoneById(tzName).GetUtcOffset(generalTime));

         // Add two and a half hours      
         DateTimeOffset centralTime2 = centralTime1.Add(twoAndAHalfHours);
         // Display result
         Console.WriteLine("{0} + {1} hours = {2}", centralTime1, 
                                                    twoAndAHalfHours.ToString(), 
                                                    centralTime2);  
      }
      catch (TimeZoneNotFoundException)
      {
         Console.WriteLine("Unable to retrieve Central Standard Time zone information.");
      }
   }
}
// The example displays the following output to the console:
//    3/9/2008 1:30:00 AM -06:00 + 02:30:00 hours = 3/9/2008 4:00:00 AM -06:00
```

## Arithmetic Operations with Times in Time Zones

The [System.TimeZoneInfo](https://docs.microsoft.com/dotnet/core/api/System.TimeZoneInfo) class does not provide any methods that automatically apply adjustment rules when you perform date and time arithmetic. However, you can do this by converting the time in a time zone to UTC, performing the arithmetic operation, and then converting from UTC back to the time in the time zone. For details, see [How to: Use Time Zones in Date and Time Arithmetic](use-time-zones-in-arithmetic.md).

For example, the following code is similar to the previous code that added two-and-a-half hours to 2:00 A.M. on March 9, 2008. However, because it converts a Central Standard time to UTC before it performs date and time arithmetic, and then converts the result from UTC back to Central Standard time, the resulting time reflects the Central Standard Time Zone's transition to daylight saving time.

```csharp
using System;

public class TimeZoneAwareArithmetic
{
   public static void Main()
   {
      const string tzName = "Central Standard Time";

      DateTime generalTime = new DateTime(2008, 3, 9, 1, 30, 0);
      TimeZoneInfo cst = TimeZoneInfo.FindSystemTimeZoneById(tzName);
      TimeSpan twoAndAHalfHours = new TimeSpan(2, 30, 0);

      // Instantiate DateTimeOffset value to have correct CST offset
      try
      {
         DateTimeOffset centralTime1 = new DateTimeOffset(generalTime, 
                                       cst.GetUtcOffset(generalTime));

         // Add two and a half hours
         DateTimeOffset utcTime = centralTime1.ToUniversalTime();
         utcTime += twoAndAHalfHours;

         DateTimeOffset centralTime2 = TimeZoneInfo.ConvertTime(utcTime, cst);
         // Display result
         Console.WriteLine("{0} + {1} hours = {2}", centralTime1, 
                                                    twoAndAHalfHours.ToString(), 
                                                    centralTime2);  
      }
      catch (TimeZoneNotFoundException)
      {
         Console.WriteLine("Unable to retrieve Central Standard Time zone information.");
      }
   }
}
// The example displays the following output to the console:
//    3/9/2008 1:30:00 AM -06:00 + 02:30:00 hours = 3/9/2008 5:00:00 AM -05:00
```

## See Also

[Dates, Times, and Time Zones](index.md)

[How to: Use Time Zones in Date and Time Arithmetic](use-time-zones-in-arithmetic.md)


