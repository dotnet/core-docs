---
title: How to: Strip Invalid Characters from a String
description: How to: Strip Invalid Characters from a String
keywords: .NET, .NET Core
author: shoag
manager: wpickett
ms.date: 06/20/2016
ms.topic: article
ms.prod: .net-core
ms.technology: .net-core-technologies
ms.devlang: dotnet
ms.assetid: 96a2cd0b-4f86-41a1-893b-460d31933fa6
---

# How to: Strip Invalid Characters from a String


The following example uses the static [Regex.Replace](https://docs.microsoft.com/dotnet/core/api/System.Text.RegularExpressions.Regex#System_Text_RegularExpressions_Regex_Replace_System_String_System_String_System_String_System_Text_RegularExpressions_RegexOptions_System_TimeSpan_) method to strip invalid characters from a string. 

## Example

You can use the `CleanInput` method defined in this example to strip potentially harmful characters that have been entered into a text field that accepts user input. In this case, `CleanInput` strips out all nonalphanumeric characters except periods (.), at symbols (@), and hyphens (-), and returns the remaining string. However, you can modify the regular expression pattern so that it strips out any characters that should not be included in an input string.

```csharp
using System;
using System.Text.RegularExpressions;

public class Example
{
    static string CleanInput(string strIn)
    {
        // Replace invalid characters with empty strings.
        try {
           return Regex.Replace(strIn, @"[^\w\.@-]", "", 
                                RegexOptions.None, TimeSpan.FromSeconds(1.5)); 
        }
        // If we timeout when replacing invalid characters, 
        // we should return Empty.
        catch (RegexMatchTimeoutException) {
           return String.Empty;   
        }
    }
}
```

The regular expression pattern `[^\w\.@-]` matches any character that is not a word character, a period, an @ symbol, or a hyphen. A word character is any letter, decimal digit, or punctuation connector such as an underscore. Any character that matches this pattern is replaced by [String.Empty](https://docs.microsoft.com/dotnet/core/api/System.String#System_String_Empty), which is the string defined by the replacement pattern. To allow additional characters in user input, add those characters to the character class in the regular expression pattern. For example, the regular expression pattern `[^\w\.@-\\%]`also allows a percentage symbol and a backslash in an input string.

## See Also

[Regular Expression Examples](index.md)
