---
title: "Migrate from Newtonsoft Json.NET to System.Text.Json - .NET"
author: tdykstra
ms.author: tdykstra
ms.date: "12/02/2019"
helpviewer_keywords: 
  - "JSON serialization"
  - "serializing objects"
  - "serialization"
  - "objects, serializing"
---

# How to migrate from Newtonsoft Json.NET to System.Text.Json

This article shows how to migrate from [Newtonsoft Json.NET](https://www.newtonsoft.com/json) to the JSON serialization tools in the [System.Text.Json namespace](system-text-json-overview.md).

`System.Text.Json` is relatively new, and its initial focus is on performance, security, and standards compliance. It lacks built-in features to handle some common scenarios, and some default behaviors differ from Newtonsoft. For some scenarios, `System.Text.Json` has no built-in functionality, but workarounds are recommended. For other scenarios,  workarounds are impractical. If your application depends on a missing feature that has no workaround, consider delaying your migration to `System.Text.Json`. For information about which features might be added in future releases, see the [Roadmap](https://github.com/dotnet/runtime/tree/master/src/libraries/System.Text.Json/roadmap/README.md).

Most of this article is about how to use the <xref:System.Text.Json.JsonSerializer> API, but it also includes guidance on how to use the <xref:System.Text.Json.JsonDocument> Document Object Model (DOM) API and the <xref:System.Text.Json.Utf8JsonReader> and <xref:System.Text.Json.Utf8JsonWriter> API. The article is organized into sections in the following order:

* Differences in default `System.Text.Json.JsonSerializer` behavior compared to Newtonsoft.
* Scenarios that `JsonSerializer` doesn't support, but workarounds might be feasible. [Go to the first of these sections.](#deserialize-inferred-types-to-object-properties)
* Scenarios that `JsonSerializer` doesn't support, and workarounds are relatively difficult or impractical. [Go to the first of these sections.](#types-without-built-in-support).
* [Utf8JsonReader and Utf8JsonWriter](#utf8jsonreader-and-utf8jsonwriter).
* [JsonDocument](#jsondocument).

## Case-insensitive deserialization 

During deserialization, Newtonsoft does case-insensitive property name matching by default. The `System.Text.Json` default is case-sensitive, which gives better performance. For information about how to do case-insensitive matching, see [Case-insensitive property matching](system-text-json-how-to.md#case-insensitive-property-matching).

If you're using `System.Text.Json` indirectly by using ASP.NET Core, you don't need to do anything to get behavior like Newtonsoft. ASP.NET Core specifies the case-insensitive setting when it uses `System.Text.Json`.

## Comments

During deserialization, Newtonsoft ignores comments in the JSON by default. The `System.Text.Json` default is to throw exceptions for comments because the [RFC 8259](https://tools.ietf.org/html/rfc8259) specification doesn't include them. For information about how to allow comments, see [Allow comments and trailing commas](system-text-json-how-to.md#allow-comments-and-trailing-commas).

## Trailing commas

During deserialization, Newtonsoft ignores trailing commas by default. In some cases, it ignores multiple trailing commas (for example, `[{"Color":"Red"},{"Color":"Green"},,]`). The `System.Text.Json` default is to throw exceptions for trailing commas because the [RFC 8259](https://tools.ietf.org/html/rfc8259) specification doesn't include them. For information about how to allow trailing commas, see [Allow comments and trailing commas](system-text-json-how-to.md#allow-comments-and-trailing-commas). There's no way to allow multiple trailing commas.

## Character escaping

During serialization, Newtonsoft is relatively permissive about letting characters through without escaping them. (That is, it doesn't replace them with `\uxxxx` where `xxxx` is the Unicode code of the character.) `System.Text.Json` escapes more characters by default to provide defense-in-depth protections against cross-site scripting (XSS) or information disclosure attacks. For information about how to override the default `System.Text.Json` behavior, see [Customize character encoding](system-text-json-how-to.md#customize-character-encoding).

## Converter registration precedence

The Newtonsoft registration precedence for custom converters is as follows:

* Attribute on property
* Attribute on type
* `Converters` collection

This order means that a custom converter in the `Converters` collection is overridden by a converter that is registered by applying an attribute at the type level. Both of those registrations are overridden by an attribute at the property level.

The `System.Text.Json` registration precedence is different:

* Attribute on property
* `Converters` collection
* Attribute on type

The difference here is that a custom converter in the `Converters` collection overrides an attribute at the type level. The intention behind this order of precedence is to make run-time changes override design-time choices. There's no way to change the precedence.

## Newtonsoft [JsonProperty] attribute

Newtonsoft has a `[JsonProperty]` attribute that is used for a variety of functions. `System.Text.Json` has single-purpose attributes instead of a multi-purpose attribute. The following attributes serve purposes similar to some of the Newtonsoft attribute functions:

* [[JsonPropertyName]](system-text-json-how-to.md#customize-individual-property-names)
* [[JsonConverter]](system-text-json-converters-how-to.md#register-a-custom-converter)

Other functions of the Newtonsoft `[JsonProperty]` attribute have no equivalent attribute in `System.Text.Json`. For some of those functions, there are other ways to accomplish the same purpose, as detailed in the following sections of this article.

## Deserialize inferred types to Object properties

When deserializing JSON data to a property of type `Object`, Newtonsoft infers the type of a property based on the JSON property value. For example, if a JSON property has "01/01/2020", the deserializer infers that it's a `DateTime`. When `System.Text.Json` deserializes to type `Object`, it always creates a `JsonElement` object.

The `System.Text.Json` deserializer doesn't guess what type a given property value represents because type inference can be inaccurate. If the deserializer parses a JSON number that has no decimal point as a `long`, that might result in out-of-range issues if the value was originally serialized as a `ulong` or `BigInteger`. Parsing a number that has a decimal point as a `double` might lose precision if the number was originally serialized as a `decimal`.

If your scenario requires type inference for `Object` properties, you can implement a custom converter. The following sample code converts:

* `true` and `false` to `Boolean`
* Numbers without a decimal to `long`
* Numbers with a decimal to `double`
* Dates to `DateTime`
* Strings to `string`
* Everything else to `JsonElement`

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/ObjectToInferredTypesConverter.cs)]

The following code registers the converter:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/DeserializeInferredTypesToObject.cs?name=SnippetRegister)]

Here's an example type with `Object` properties:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/WeatherForecast.cs?name=SnippetWFWithObjectProperties)]

The following example of JSON to deserialize contains values that will be deserialized as `DateTime`, `long`, and `string`:

```json
{
  "Date": "2019-08-01T00:00:00-07:00",
  "TemperatureCelsius": 25,
  "Summary": "Hot",
}
```

Without the custom converter, deserialization puts a `JsonElement` in each property.

The [unit tests folder](https://github.com/dotnet/corefx/blob/master/src/System.Text.Json/tests/Serialization/) in the `System.Text.Json.Serialization` namespace has more examples of custom converters that handle deserialization to Object properties. For more information, see issue [38713](https://github.com/dotnet/corefx/issues/38713) in the dotnet/corefx GitHub repository.

## Dictionary with non-string key

Newtonsoft supports collections of type `Dictionary<TKey, TValue>`. The built-in support for dictionary collections in `System.Text.Json` is limited to `Dictionary<string, TValue>`. That is, the key must be a string. To support a dictionary with an integer or some other type as the key, a custom converter is required.

The following code shows a custom converter that works with `Dictionary<Enum,TValue>`:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/DictionaryTKeyEnumTValueConverter.cs)]

The following code registers the converter:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/RoundtripDictionaryTkeyEnumTValue.cs?name=SnippetRegister)]

The converter can serialize and deserialize the `TemperatureRanges` property of the following class that uses the following `Enum`:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/WeatherForecast.cs?name=SnippetWFWithEnumDictionary)]

The JSON output from serialization looks like the following example:

```json
{
  "Date": "2019-08-01T00:00:00-07:00",
  "TemperatureCelsius": 25,
  "Summary": "Hot",
  "TemperatureRanges": {
    "Cold": 20,
    "Hot": 40
  }
}
```

The [unit tests folder](https://github.com/dotnet/corefx/blob/master/src/System.Text.Json/tests/Serialization/) in the `System.Text.Json.Serialization` namespace has more examples of custom converters that handle non-string-key dictionaries. For more information, see issue [40120](https://github.com/dotnet/corefx/issues/40120) in the dotnet/corefx GitHub repository.

## Polymorphic deserialization

Newtonsoft can do polymorphic serialization and deserialization. Suppose, for example, you have a `Person` abstract base class, with `Employee` and `Customer` derived classes. Polymorphic deserialization means that at design time you can specify `Person` as the deserialization target, and `Customer` and `Employee` objects in the JSON are correctly deserialized at runtime. To do that, the deserializer has to find clues that identify the required type in the JSON. For example, a discriminator property might be available or you might have to rely on the presence or absence of a particular property. Newtonsoft provides attributes that specify how to handle polymorphic deserialization scenarios. The current release of `System.Text.Json` doesn't provide such attributes. If there's no need for polymorphic deserialization, `System.Text.Json` can do [polymorphic serialization](system-text-json-how-to.md#serialize-properties-of-derived-classes). But the ability to do polymorphic deserialization or convert the same data in both directions requires a custom converter.

The following code shows a base class, two derived classes, and a custom converter for them. The converter uses a discriminator property to do polymorphic deserialization. The type discriminator isn't in the class definitions but is created during serialization and is read during deserialization.

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/Person.cs?name=SnippetPerson)]

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/PersonConverterWithTypeDiscriminator.cs)]

The following code registers the converter:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/RoundtripPolymorphic.cs?name=SnippetRegister)]

The converter can deserialize JSON that was created by using the same converter to serialize, for example:

```json
[
  {
    "TypeDiscriminator": 1,
    "CreditLimit": 10000,
    "Name": "John"
  },
  {
    "TypeDiscriminator": 2,
    "OfficeNumber": "555-1234",
    "Name": "Nancy"
  }
]
```

For more information, see issue [37787](https://github.com/dotnet/corefx/issues/37787) in the dotnet/corefx GitHub repository.

## Quoted numbers

Newtonsoft can serialize or deserialize numbers in quotes, for example, it can accept: `{ "DegreesCelsius":"23" }` instead of `{ "DegreesCelsius":23 }`. To enable that behavior in `System.Text.Json`, implement a custom converter like the following example, which uses quotes for properties defined as `long`.

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/LongToStringConverter.cs)]

[Register this custom converter](system-text-json-converters-how-to.md#register-a-custom-converter) by using an attribute on individual `long` properties or by adding the converter to the `Converters` collection.

## Required properties

During deserialization, `System.Text.Json` doesn't throw an exception if no value is received in the JSON for one of the properties of the target type. For example, if you have a `WeatherForecast` class:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/WeatherForecast.cs?name=SnippetWeatherForecast)]

The following JSON is deserialized without error:

```json
{
    "TemperatureCelsius": 25,
    "Summary": "Hot"
}
```

To make deserialization fail if no `Date` property is in the JSON, implement a custom converter. The following sample converter code throws an exception if the `Date` property isn't set after deserialization is complete:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/WeatherForecastPropertyRequiredConverter.cs)]

[Register this custom converter](system-text-json-converters-how-to.md#register-a-custom-converter) by using an attribute on the POCO class or by adding the converter to the `Converters` collection.

If you follow this pattern, don't pass in the options object when recursively calling `Serialize` or `Deserialize`. The options object contains the `Converters` collection. If you pass it in to `Serialize` or `Deserialize`, the custom converter calls into itself, making an infinite loop that results in a stack overflow exception.

This is a simplified example. More complex code would be required if you need to handle attributes (such as `[JsonIgnore]`) or options (such as custom encoders).

For more information, see issue [38492](https://github.com/dotnet/corefx/issues/38492) in the dotnet/corefx GitHub repository.

## Deserialize null to non-nullable type 

Newtonsoft doesn't throw an exception in the following scenario:

* `NullValueHandling` is set to `Ignore`
* During deserialization, the JSON contains a null value for a non-nullable type.

In the same scenario, `System.Text.Json` does throw an exception. (The corresponding null handling setting is <xref:System.Text.Json.JsonSerializerOptions.IgnoreNullValues?displayProperty=nameWithType>.)

If you own the target type, the easiest workaround is to make the property in question nullable (for example, change `int` to `int?`).

Another workaround is to make a converter for the type, such as the following example that handles null values for `DateTimeOffset` types:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/DateTimeOffsetNullHandlingConverter.cs)]

[Register this custom converter](system-text-json-converters-how-to.md#register-a-custom-converter) by using an attribute on the property or by adding the converter to the `Converters` collection.

For more information, see issue [40922](https://github.com/dotnet/corefx/issues/40922) in the dotnet/corefx GitHub repository.

## Deserialize to immutable classes and structs

Newtonsoft can deserialize to immutable classes and structs because it can use constructors that have parameters. The current release of `System.Text.Json` supports only parameterless constructors. But you can use a constructor with a parameters in a custom converter.

Here's an immutable struct with multiple constructor parameters:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/ImmutablePoint.cs#ImmutablePoint)]

And here's a converter that serializes and deserializes this struct:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/ImmutablePointConverter.cs)]

[Register this custom converter](system-text-json-converters-how-to.md#register-a-custom-converter) by adding the converter to the `Converters` collection.

For an example of a similar converter that handles open generic properties, see the [built-in converter for key-value pairs](https://github.com/dotnet/runtime/blob/master/src/libraries/System.Text.Json/src/System/Text/Json/Serialization/Converters/JsonValueConverterKeyValuePair.cs).

For more information, see issues [38569](https://github.com/dotnet/corefx/issues/38569) and [38163](https://github.com/dotnet/corefx/issues/38163) in the dotnet/corefx GitHub repository. Issue 

## Ignore a property at run-time

The Newtonsoft `DefaultContractResolver` lets you select properties to include or exclude during serialization, based on criteria that are evaluated at run time. `System.Text.Json` provides the following ways to omit properties while serializing:

* A [[JsonIgnore]](system-text-json-how-to.md#exclude-individual-properties) attribute on a property causes the property to be omitted from the JSON during serialization.
* The [IgnoreNullValues](system-text-json-how-to.md#exclude-all-null-value-properties) flag lets you exclude all null-value properties during serialization.

These options don't let you selectively omit properties from serialization based on criteria evaluated at run time. For that functionality, you can write a custom converter. Here's a sample POCO and a custom converter for it that illustrates this approach:

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/WeatherForecast.cs#WeatherForecast)]

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/WeatherForecastRuntimeIgnoreConverter.cs)]

The converter causes the `TemperatureCelsius` property to be omitted from serialization if its value is outside of a specified range. 

[Register this custom converter](system-text-json-converters-how-to.md#register-a-custom-converter) by adding the converter to the `Converters` collection or by applying the `[JsonConvert]` attribute to the class.

This approach requires complex code if:

* The POCO includes complex properties.
* You need to handle attributes such as `[JsonIgnore]` or options such as custom encoders.

For more information, see issue [42001](https://github.com/dotnet/corefx/issues/42001) in the dotnet/corefx GitHub repository.

## Specify date format

Newtonsoft provides a `DateTimeZoneHandling` option that lets you specify the serialization format used for `DateTime` and `DateTimeOffset` properties. In `System.Text.Json`, the only format that has built-in support is ISO 8601-1:2019. To use any other format, create a custom converter. For more information, see [DateTime and DateTimeOffset support in System.Text.Json](../datetime/system-text-json-support.md).

## Callbacks

Newtonsoft lets you execute custom code at several points in the serialization or deserialization process:

* OnDeserializing (when beginning to deserialize an object)
* OnDeserialized (when finished deserializing an object)
* OnSerializing (when beginning to serialize an object)
* OnSerialized (when finished serializing an object)

In `System.Text.Json`, you can simulate callbacks by writing a custom converter. The following example shows a custom converter for a POCO. The converter includes code that displays a message at each point that corresponds to a Newtonsoft callback.

[!code-csharp[](~/samples/snippets/core/system-text-json/csharp/WeatherForecastCallbacksConverter.cs)]

[Register the converter](system-text-json-converters-how-to.md#register-a-custom-converter) by adding the converter to the `Converters` collection or by applying the `[JsonConvert]` attribute to the class.

If you use a custom converter that follows this example:

* The `OnDeserializing` code doesn't have access to the new POCO instance. To manipulate the new POCO instance at the start of deserialization, put that code in the POCO constructor.
* Don't pass in the options object when recursively calling `Serialize` or `Deserialize`. The options object contains the `Converters` collection. If you pass it in to `Serialize` or `Deserialize`, the converter will be used, making an infinite loop that results in a stack overflow exception.

For more information, see issue [36639](https://github.com/dotnet/corefx/issues/36639) in the dotnet/corefx GitHub repository.

## Types without built-in support

The following list shows some of the types that the current release of `System.Text.Json` doesn't provide built-in support for:

* <xref:System.Data.DataTable> and related types. For more information, see issue [38712](https://github.com/dotnet/corefx/issues/38712) in the dotnet/corefx GitHub repository.
* F# types, such as [discriminated unions](../../fsharp/language-reference/discriminated-unions.md), [record types](../../fsharp/language-reference/records.md), and [anonymous record types](../../fsharp/language-reference/anonymous-records.md). For more information, see issue [38348](https://github.com/dotnet/corefx/issues/38348).
* Collections in the <xref:System.Collections.Specialized> namespace. For more information, see issue [40370](https://github.com/dotnet/corefx/issues/40370).
* The <xref:System.Dynamic.ExpandoObject> type.  For more information, see issue [38007](https://github.com/dotnet/corefx/issues/38007).

## Private setters

Newtonsoft can use private property setters. The current release of `System.Text.Json` supports only public setters. For more information, see issue [38163](https://github.com/dotnet/corefx/issues/38163) in the dotnet/corefx GitHub repository.

## System.Runtime.Serialization attributes

`System.Text.Json` doesn't support attributes from the `System.Runtime.Serialization` namespace, such as `DataMemberAttribute` and `IgnoreDataMemberAttribute`. This lack of support is a design decision that is not likely to change in the future.

For more information, see issue [38758](https://github.com/dotnet/corefx/issues/38758) in the dotnet/corefx GitHub repository.

## Octal numbers

Newtonsoft treats numbers with a leading zero as octal numbers. `System.Text.Json` doesn't allow leading zeroes because the [RFC 8259](https://tools.ietf.org/html/rfc8259) specification doesn't allow them. The lack of support for octal numbers is by design and is not expected to change in future versions of `System.Text.Json`. Options for handling JSON that deviates from the specification are offered for only a few high-priority scenarios, such as comments and trailing commas.

## Object reference handling

By default, both Newtonsoft and `System.Text.Json` serialize objects by value. For example, if an object contains two properties that contain a reference to the same `Person` object, the values of that `Person` object's properties are duplicated in the JSON. Newtonsoft offers the option of serializing by reference:

* A token is added to the JSON created for the first `Person` object.
* The JSON that is created for the second `Person` object contains that token instead of property values.

For more information, see issues [37786](https://github.com/dotnet/corefx/issues/37786) and [38579](https://github.com/dotnet/corefx/issues/38579) in the dotnet/corefx GitHub repository.

## Type name handling

Newtonsoft can add type name metadata to the JSON while serializing, and it uses the metadata while deserializing. The current release of `System.Text.Json` lacks this feature.

## Populate existing objects

Newtonsoft can deserialize to an existing instance of a class, instead of creating a new instance. The current release of `System.Text.Json` always creates a new instance of the target type by using the default parameterless constructor. For more information, see issue [37627](https://github.com/dotnet/corefx/issues/37627) and [42515](https://github.com/dotnet/corefx/issues/42515) in the dotnet/corefx GitHub repository.

## Fields

Newtonsoft can serialize and deserialize fields as well as properties. The current release of `System.Text.Json` only works with properties. For more information, see issue [36505](https://github.com/dotnet/corefx/issues/36505) in the dotnet/corefx GitHub repository.

## MissingMemberHandling

Newtonsoft can be configured to throw exceptions during deserialization if the JSON includes properties that are missing in the target type. `System.Text.Json` ignores extra properties in the JSON, except when you use [the [JsonExtensionData] attribute](system-text-json-how-to.md#handle-overflow-json). There's no workaround for the missing member feature.

## TraceWriter

Newtonsoft lets you debug by using a `TraceWriter` to view logs that are generated by serialization or deserialization. The current release of `System.Text.Json` doesn't do logging.

## Utf8JsonReader and Utf8JsonWriter

<xref:System.Text.Json.Utf8JsonReader?displayProperty=fullName> is a high-performance, low allocation, forward-only reader for UTF-8 encoded JSON text, read from a `ReadOnlySpan<byte>`. The `Utf8JsonReader` is a low-level type that can be used to build custom parsers and deserializers.

<xref:System.Text.Json.Utf8JsonWriter?displayProperty=fullName> is a high-performance way to write UTF-8 encoded JSON text from common .NET types like `String`, `Int32`, and `DateTime`. The writer is a low-level type that can be used to build custom serializers.

The following sections explain recommended programming patterns for using `Utf8JsonReader` and `Utf8JsonWriter`.

### Ref structs

The `Utf8JsonReader` and `Utf8JsonWriter` types are *ref structs*, which means they have certain limitations. For example, they can't be stored as a field on a class or struct other than a ref struct. To achieve high performance, these types must be `ref structs` since they need to cache the input or output `Span<byte>`, which itself is a ref struct. In addition, these types are mutable since they hold state. Therefore, you should **pass them by ref** rather than by value. Passing them by value would result in a struct copy and the state changes would not be visible to the caller. This differs from Newtonsoft since the Newtonsoft `JsonTextReader` and `JsonTextWriter` are classes. For more information about how to use ref structs, see [Write safe and efficient C# code](../../csharp/write-safe-efficient-code.md).

### Read with a Stream or PipeReader

The `Utf8JsonReader` supports reading from a UTF-8 encoded `ReadOnlySpan<byte>` or `ReadOnlySequence<byte>` (which is the result of reading from a `PipeReader`). For synchronous reading, you could read the JSON payload until the end of the stream into a byte array and pass that into the reader. For reading from a string (which is encoded as UTF-16), you should use the `Encoding.UTF8.GetBytes` API to first transcode the string to a UTF-8 encoded byte array. Then pass that to the `Utf8JsonReader`. For code examples, see [Use Utf8JsonReader](system-text-json-how-to.md#use-utf8jsonreader).

### Read with multi-segment ReadOnlySequence

If your JSON input is a `ReadOnlySpan<byte>`, each JSON element can be accessed from the `ValueSpan` property on the reader as you go through the read loop. However, if your input is a `ReadOnlySequence<byte>` (which is the result of reading from a `PipeReader`), some JSON elements might straddle multiple segments of the `ReadOnlySequence<byte>` object. These elements would not be accessible from `ValueSpan` in a contiguous memory block. Instead, whenever you have a multi-segment `ReadOnlySequence<byte>` as input, you should always poll the `HasValueSequence` property on the reader to figure out how to access the current JSON element. Here's a recommended pattern:

```csharp
while (reader.Read())
{
  switch (reader.TokenType)
  {
    // ...
    ReadOnlySpan<byte> jsonElement = reader.HasValueSequence ?
                reader.ValueSequence.ToArray() :
                reader.ValueSpan;
    // ...
  }
}
```

## Read and write with UTF-8 text

To achieve the best possible performance while using the `Utf8JsonReader` and `Utf8JsonWriter`, read and write JSON payloads already encoded as UTF-8 text rather than as UTF-16 strings. For example, if you're writing string literals, consider caching them as static byte arrays, and write those instead. For a code example, see [Filter data using Utf8JsonReader](system-text-json-how-to.md#filter-data-using-utf8jsonreader).

### Read and write null values

Code that uses the Newtonsoft reader can compare a value token type of String to null, as in the following example:

```csharp
public static string ReadAsString(this JsonTextReader reader)
{
    reader.Read();

    if (reader.TokenType != JsonToken.String)
    {
        throw new InvalidDataException();
    }

    return reader.Value?.ToString();
}
```

This code doesn't work correctly in `System.Text.Json`, which considers the `null` literal to be its own token type. When using `Utf8JsonReader`, check for the `JsonTokenType.Null` token type, as shown in the following example:

```csharp
public static string ReadAsString(this ref Utf8JsonReader reader)
{
    reader.Read();

    if (reader.TokenType == JsonTokenType.Null)
    {
        return null;
    }

    if (reader.TokenType != JsonTokenType.String)
    {
        throw new InvalidDataException();
    }

    return reader.GetString();
}
```

To write null values by using `Utf8JsonWriter`, call:

* <xref:System.Text.Json.Utf8JsonWriter.WriteNull%2A> to write a key-value pair with null as the value.
* <xref:System.Text.Json.Utf8JsonWriter.WriteNullValue%2A> to write null as an element of a JSON array.

For a string property, if the string is null, <xref:System.Xml.XmlDictionaryWriter.WriteString%2A> and <xref:System.Xml.XmlDictionaryWriter.WriteStringValue%2A> are equivalent to `WriteNull` and `WriteNullValue`.

## Multi-targeting

If you need to continue to use Newtonsoft for certain target frameworks, you can multi-target and have two implementations. However, this is not trivial and would require some `#ifdefs` and source duplication. One way to share as much code as possible is to create a `ref struct` wrapper around `Utf8JsonReader` and Newtonsoft `JsonTextReader`, and a wrapper around `Utf8JsonWriter` and `JsonTextWriter`. This wrapper would unify the public surface area while isolating the behavioral differences. This lets you isolate the changes mainly to the construction of the type, along with passing the new type around by reference. This is the pattern that the [.NET Core installer](https://github.com/dotnet/runtime/tree/master/src/installer) follows:

* [UnifiedJsonReader.JsonTextReader.cs](https://github.com/dotnet/runtime/blob/master/src/installer/managed/Microsoft.Extensions.DependencyModel/UnifiedJsonReader.JsonTextReader.cs)
* [UnifiedJsonReader.Utf8JsonReader.cs](https://github.com/dotnet/runtime/blob/master/src/installer/managed/Microsoft.Extensions.DependencyModel/UnifiedJsonReader.Utf8JsonReader.cs)
* [UnifiedJsonWriter.JsonTextWriter.cs](https://github.com/dotnet/runtime/blob/master/src/installer/managed/Microsoft.Extensions.DependencyModel/UnifiedJsonWriter.JsonTextWriter.cs)
* [UnifiedJsonWriter.Utf8JsonWriter.cs](https://github.com/dotnet/runtime/blob/master/src/installer/managed/Microsoft.Extensions.DependencyModel/UnifiedJsonWriter.Utf8JsonWriter.cs)

## JsonDocument

<xref:System.Text.Json.JsonDocument?displayProperty=fullName> provides the ability to build a read-only Document Object Model (DOM). The DOM provides random access to data in a JSON payload. The JSON elements that compose the payload can be accessed via the <xref:System.Text.Json.JsonElement> type. The `JsonElement` type provides APIs to convert JSON text to common .NET types. `JsonDocument` exposes a <xref:System.Text.Json.JsonDocument.RootElement> property.

### IDisposable

`JsonDocument` builds an in-memory view of the data into a pooled buffer. Therefore, unlike Newtonsoft `JObject` or `JArray`, the `JsonDocument` type implements `IDisposable` and needs to be used inside a using block.

### Read-only

Since the `System.Text.Json` DOM can't add, remove, or modify JSON elements. If your scenario currently uses a writable DOM, one of the following workarounds might be feasible:

* To build a `JsonDocument` from scratch, write JSON text by using the `Utf8JsonWriter` and parse the output from that to make a new `JsonDocument`.
* To modify an existing `JsonDocument`, use it to write JSON text, making changes while you write, and parse the output from that to make a new `JsonDocument`. For more information, see issue [38589](https://github.com/dotnet/corefx/issues/38589) in the dotnet/corefx GitHub repository.

### JsonElement

`JsonDocument` exposes the `RootElement` as a property of type <xref:System.Text.Json.JsonElement>, which is the type that encompasses any JSON element. Newtonsoft uses dedicated types like `JObject`,`JArray`, `JToken`, and so forth. `JsonElement` is what you can search and enumerate over, and you can use `JsonElement` to materialize JSON elements into .NET types.

### Search a JsonDocument

Searches that use Newtonsoft `JObject` or `JArray` tend to be relatively fast because they're lookups in some dictionary. By comparison, a sequential search through JSON elements stored as `JsonElement` is relatively slow. `System.Text.Json` is designed to minimize initial parse time rather than look-up time. Therefore, use the following approaches to optimize performance when searching through a `JsonDocument` object:

* Use the built-in enumerators (<xref:System.Text.Json.JsonElement.EnumerateArray%2A> and <xref:System.Text.Json.JsonElement.EnumerateObject%2A>) rather than doing your own indexing or loops.
* Don't do a sequential search of every `JsonElement`. Search on nested JSON objects based on the known structure of the JSON data. For example, if you're looking for a `Grade` property in `Student` objects, loop through the `Student` objects and get the value of `Grade` for each, rather than searching through all `JsonElement` objects looking for `Grade` properties.

For a code example, see [Use JsonDocument for access to data](system-text-json-how-to.md#use-jsondocument-for-access-to-data).

## Additional resources

* [System.Text.Json overview](system-text-json-overview.md)
* [System.Text.Json API reference](xref:System.Text.Json)
* [How to use System.Text.Json](system-text-json-how-to.md)
* [How to write custom converters](system-text-json-converters-how-to.md)
* [Roadmap](https://github.com/dotnet/corefx/blob/master/src/System.Text.Json/roadmap/README.md)
