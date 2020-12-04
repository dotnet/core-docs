---
title: "How to serialize and deserialize JSON using C# - .NET"
description: "Learn how to use the System.Text.Json namespace to serialize to and deserialize from JSON in .NET. Includes sample code."
ms.date: 11/30/2020
ms.custom: contperfq2
no-loc: [System.Text.Json, Newtonsoft.Json]
zone_pivot_groups: dotnet-version
helpviewer_keywords:
  - "JSON serialization"
  - "serializing objects"
  - "serialization"
  - "objects, serializing"
---

# How to serialize and deserialize (marshal and unmarshal) JSON in .NET

This article shows how to use the <xref:System.Text.Json?displayProperty=fullName> namespace to serialize to and deserialize from JavaScript Object Notation (JSON). If you're porting existing code from `Newtonsoft.Json`, see [How to migrate to `System.Text.Json`](system-text-json-migrate-from-newtonsoft-how-to.md).

The directions and sample code use the library directly, not through a framework such as [ASP.NET Core](/aspnet/core/).

Most of the serialization sample code sets <xref:System.Text.Json.JsonSerializerOptions.WriteIndented?displayProperty=nameWithType> to `true` to "pretty-print" the JSON (with indentation and whitespace for human readability). For production use, you would typically accept the default value of `false` for this setting.

The code examples refer to the following class and variants of it:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/WeatherForecast.cs" id="WF":::

## Namespaces

The <xref:System.Text.Json> namespace contains all the entry points and the main types. The <xref:System.Text.Json.Serialization> namespace contains attributes and APIs for advanced scenarios and customization specific to serialization and deserialization. The code examples shown in this article require `using` directives for one or both of these namespaces:

```csharp
using System.Text.Json;
using System.Text.Json.Serialization;
```

> [!IMPORTANT]
> Attributes from the <xref:System.Runtime.Serialization> namespace aren't supported in `System.Text.Json`.

## How to write .NET objects as JSON (serialize)

To write JSON to a string or to a file, call the <xref:System.Text.Json.JsonSerializer.Serialize%2A?displayProperty=nameWithType> method.

The following example creates JSON as a string:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToString.cs" id="Serialize":::

The following example uses synchronous code to create a JSON file:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToFile.cs" id="Serialize":::

The following example uses asynchronous code to create a JSON file:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToFileAsync.cs" id="Serialize":::

The preceding examples use type inference for the type being serialized. An overload of `Serialize()` takes a generic type parameter:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToString.cs" id="SerializeWithGenericParameter":::

### Serialization example

Here's an example class that contains collection-type properties and a user-defined type:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/WeatherForecast.cs" id="WFWithPOCOs":::

> [!TIP]
> "POCO" stands for [plain old CLR object](https://en.wikipedia.org/wiki/Plain_old_CLR_object). A POCO is a .NET type that doesn't depend on any framework-specific types, for example, through inheritance or attributes.

The JSON output from serializing an instance of the preceding type looks like the following example. The JSON output is minified (whitespace, indentation, and new-line characters are removed) by default:

```json
{"Date":"2019-08-01T00:00:00-07:00","TemperatureCelsius":25,"Summary":"Hot","DatesAvailable":["2019-08-01T00:00:00-07:00","2019-08-02T00:00:00-07:00"],"TemperatureRanges":{"Cold":{"High":20,"Low":-10},"Hot":{"High":60,"Low":20}},"SummaryWords":["Cool","Windy","Humid"]}
```

The following example shows the same JSON, but formatted (that is, pretty-printed with whitespace and indentation):

```json
{
  "Date": "2019-08-01T00:00:00-07:00",
  "TemperatureCelsius": 25,
  "Summary": "Hot",
  "DatesAvailable": [
    "2019-08-01T00:00:00-07:00",
    "2019-08-02T00:00:00-07:00"
  ],
  "TemperatureRanges": {
    "Cold": {
      "High": 20,
      "Low": -10
    },
    "Hot": {
      "High": 60,
      "Low": 20
    }
  },
  "SummaryWords": [
    "Cool",
    "Windy",
    "Humid"
  ]
}
```

## Serialize to UTF-8

To serialize to UTF-8, call the <xref:System.Text.Json.JsonSerializer.SerializeToUtf8Bytes%2A?displayProperty=nameWithType> method:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToUtf8.cs" id="Serialize":::

A <xref:System.Text.Json.JsonSerializer.Serialize%2A> overload that takes a <xref:System.Text.Json.Utf8JsonWriter> is also available.

Serializing to UTF-8 is about 5-10% faster than using the string-based methods. The difference is because the bytes (as UTF-8) don't need to be converted to strings (UTF-16).

## Serialization behavior

::: zone pivot="dotnet-5-0"

* By default, all public properties are serialized. You can [specify properties to ignore](system-text-json-ignore-properties.md).
* The [default encoder](xref:System.Text.Encodings.Web.JavaScriptEncoder.Default) escapes non-ASCII characters, HTML-sensitive characters within the ASCII-range, and characters that must be escaped according to [the RFC 8259 JSON spec](https://tools.ietf.org/html/rfc8259#section-7).
* By default, JSON is minified. You can [pretty-print the JSON](#serialize-to-formatted-json).
* By default, casing of JSON names matches the .NET names. You can [customize JSON name casing](system-text-json-customize-properties.md).
* By default, circular references are detected and exceptions thrown. You can [preserve references and handle circular references](system-text-json-preserve-references.md).
* By default, [fields](../../csharp/programming-guide/classes-and-structs/fields.md) are ignored. You can [include fields](#include-fields).

When you use System.Text.Json indirectly in an ASP.NET Core app, some default behaviors are different. For more information, see [Web defaults for JsonSerializerOptions](system-text-json-configure-options.md#web-defaults-for-jsonserializeroptions).
::: zone-end

::: zone pivot="dotnet-core-3-1"

* By default, all public properties are serialized. You can [specify properties to ignore](system-text-json-ignore-properties.md).
* The [default encoder](xref:System.Text.Encodings.Web.JavaScriptEncoder.Default) escapes non-ASCII characters, HTML-sensitive characters within the ASCII-range, and characters that must be escaped according to [the RFC 8259 JSON spec](https://tools.ietf.org/html/rfc8259#section-7).
* By default, JSON is minified. You can [pretty-print the JSON](#serialize-to-formatted-json).
* By default, casing of JSON names matches the .NET names. You can [customize JSON name casing](system-text-json-customize-properties.md).
* Circular references are detected and exceptions thrown.
* [Fields](../../csharp/programming-guide/classes-and-structs/fields.md) are ignored.
::: zone-end

Supported types include:
::: zone pivot="dotnet-5-0"

* .NET primitives that map to JavaScript primitives, such as numeric types, strings, and Boolean.
* User-defined [plain old CLR objects (POCOs)](https://en.wikipedia.org/wiki/Plain_old_CLR_object).
* One-dimensional and jagged arrays (`T[][]`).
* Collections and dictionaries from the following namespaces.
  * <xref:System.Collections>
  * <xref:System.Collections.Generic>
  * <xref:System.Collections.Immutable>
  * <xref:System.Collections.Concurrent>
  * <xref:System.Collections.Specialized>
  * <xref:System.Collections.ObjectModel>
::: zone-end

::: zone pivot="dotnet-core-3-1"

* .NET primitives that map to JavaScript primitives, such as numeric types, strings, and Boolean.
* User-defined [plain old CLR objects (POCOs)](https://en.wikipedia.org/wiki/Plain_old_CLR_object).
* One-dimensional and jagged arrays (`ArrayName[][]`).
* `Dictionary<string,TValue>` where `TValue` is `object`, `JsonElement`, or a POCO.
* Collections from the following namespaces.
  * <xref:System.Collections>
  * <xref:System.Collections.Generic>
  * <xref:System.Collections.Immutable>
  * <xref:System.Collections.Concurrent>
  * <xref:System.Collections.Specialized>
  * <xref:System.Collections.ObjectModel>
::: zone-end

You can [implement custom converters](system-text-json-converters-how-to.md) to handle additional types or to provide functionality that isn't supported by the built-in converters.

## How to read JSON as .NET objects (deserialize)

To deserialize from a string or a file, call the <xref:System.Text.Json.JsonSerializer.Deserialize%2A?displayProperty=nameWithType> method.

The following example reads JSON from a string and creates an instance of the `WeatherForecastWithPOCOs` class shown earlier for the [serialization example](#serialization-example):

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToString.cs" id="Deserialize":::

To deserialize from a file by using synchronous code, read the file into a string, as shown in the following example:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToFile.cs" id="Deserialize":::

To deserialize from a file by using asynchronous code, call the <xref:System.Text.Json.JsonSerializer.DeserializeAsync%2A> method:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToFileAsync.cs" id="Deserialize":::

## Deserialize from UTF-8

To deserialize from UTF-8, call a <xref:System.Text.Json.JsonSerializer.Deserialize%2A?displayProperty=nameWithType> overload that takes a `ReadOnlySpan<byte>` or a `Utf8JsonReader`, as shown in the following examples. The examples assume the JSON is in a byte array named jsonUtf8Bytes.

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToUtf8.cs" id="Deserialize1":::

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToUtf8.cs" id="Deserialize2":::

## Deserialization behavior

The following behaviors apply when deserializing JSON:

::: zone pivot="dotnet-5-0"

* By default, property name matching is case-sensitive. You can [specify case-insensitivity](system-text-json-character-casing.md).
* If the JSON contains a value for a read-only property, the value is ignored and no exception is thrown.
* Non-public constructors are ignored by the serializer.
* Deserialization to immutable objects or read-only properties is supported. See [Immutable types and Records](system-text-json-immutability.md).
* By default, enums are supported as numbers. You can [serialize enum names as strings](system-text-json-customize-properties.md#enums-as-strings).
* By default, fields are ignored. You can [include fields](#include-fields).
* By default, comments or trailing commas in the JSON throw exceptions. You can [allow comments and trailing commas](system-text-json-invalid-json.md).
* The [default maximum depth](xref:System.Text.Json.JsonReaderOptions.MaxDepth) is 64.

When you use System.Text.Json indirectly in an ASP.NET Core app, some default behaviors are different. For more information, see [Web defaults for JsonSerializerOptions](system-text-json-configure-options.md#web-defaults-for-jsonserializeroptions).
::: zone-end

::: zone pivot="dotnet-core-3-1"

* By default, property name matching is case-sensitive. You can [specify case-insensitivity](system-text-json-character-casing.md). ASP.NET Core apps [specify case-insensitivity by default](system-text-json-configure-options.md#web-defaults-for-jsonserializeroptions).
* If the JSON contains a value for a read-only property, the value is ignored and no exception is thrown.
* A parameterless constructor, which can be public, internal, or private, is used for deserialization.
* Deserialization to immutable objects or read-only properties isn't supported.
* By default, enums are supported as numbers. You can [serialize enum names as strings](system-text-json-customize-properties.md#enums-as-strings).
* Fields aren't supported.
* By default, comments or trailing commas in the JSON throw exceptions. You can [allow comments and trailing commas](system-text-json-invalid-json.md).
* The [default maximum depth](xref:System.Text.Json.JsonReaderOptions.MaxDepth) is 64.

When you use System.Text.Json indirectly in an ASP.NET Core app, some default behaviors are different. For more information, see [Web defaults for JsonSerializerOptions](system-text-json-configure-options.md#web-defaults-for-jsonserializeroptions).
::: zone-end

You can [implement custom converters](system-text-json-converters-how-to.md) to provide functionality that isn't supported by the built-in converters.

## Serialize to formatted JSON

To pretty-print the JSON output, set <xref:System.Text.Json.JsonSerializerOptions.WriteIndented?displayProperty=nameWithType> to `true`:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/RoundtripToString.cs" id="SerializePrettyPrint":::

Here's an example type to be serialized and pretty-printed JSON output:

:::code language="csharp" source="snippets/system-text-json-how-to/csharp/WeatherForecast.cs" id="WF":::

```json
{
  "Date": "2019-08-01T00:00:00-07:00",
  "TemperatureCelsius": 25,
  "Summary": "Hot"
}
```

## Include fields

::: zone pivot="dotnet-5-0"
Use the <xref:System.Text.Json.JsonSerializerOptions.IncludeFields?displayProperty=nameWithType> global setting or the [[JsonInclude]](xref:System.Text.Json.Serialization.JsonIncludeAttribute) attribute to include fields when serializing or deserializing, as shown in the following example:

:::code language="csharp" source="snippets/system-text-json-how-to-5-0/csharp/Fields.cs" highlight="16,18,20,32-35":::

To ignore read-only fields, use the <xref:System.Text.Json.JsonSerializerOptions.IgnoreReadOnlyFields%2A?displayProperty=nameWithType> global setting.
::: zone-end

::: zone pivot="dotnet-core-3-1"
Fields are not supported in System.Text.Json in .NET Core 3.1. [Custom converters](system-text-json-converters-how-to.md) can provide this functionality.
::: zone-end

## HttpClient and HttpContent extension methods

::: zone pivot="dotnet-5-0"

Serializing and deserializing JSON payloads from the network are common operations. Extension methods on [HttpClient](xref:System.Net.Http.Json.HttpClientJsonExtensions) and [HttpContent](xref:System.Net.Http.Json.HttpContentJsonExtensions) let you do these operations in a single line of code. These extension methods use [web defaults for JsonSerializerOptions](system-text-json-configure-options.md#web-defaults-for-jsonserializeroptions).

The following example illustrates use of <xref:System.Net.Http.Json.HttpClientJsonExtensions.GetFromJsonAsync%2A?displayProperty=nameWithType> and <xref:System.Net.Http.Json.HttpClientJsonExtensions.PostAsJsonAsync%2A?displayProperty=nameWithType>:

:::code language="csharp" source="snippets/system-text-json-how-to-5-0/csharp/HttpClientExtensionMethods.cs" highlight="26,33":::

There are also extension methods for System.Text.Json on [HttpContent](xref:System.Net.Http.Json.HttpContentJsonExtensions).
::: zone-end

::: zone pivot="dotnet-core-3-1"
Extension methods on `HttpClient` and `HttpContent` are not available in System.Text.Json in .NET Core 3.1.
::: zone-end

## See also

* [System.Text.Json overview](system-text-json-overview.md)
* [How to write custom converters](system-text-json-converters-how-to.md)
* [How to migrate from Newtonsoft.Json](system-text-json-migrate-from-newtonsoft-how-to.md)
* [DateTime and DateTimeOffset support in System.Text.Json](../datetime/system-text-json-support.md)
* [System.Text.Json API reference](xref:System.Text.Json)
<!-- * [System.Text.Json roadmap](https://github.com/dotnet/runtime/blob/81bf79fd9aa75305e55abe2f7e9ef3f60624a3a1/src/libraries/System.Text.Json/roadmap/README.md)-->
