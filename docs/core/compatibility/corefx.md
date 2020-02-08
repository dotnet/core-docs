---
title: Base class library breaking changes
description: Lists the breaking changes in .NET CoreFx, the base class library.
ms.date: "09/20/2019"
---
# CoreFx breaking changes

CoreFx provides the primitives and other general types used by .NET Core.

The following breaking changes are documented on this page:

- [APIs that report version now report product and not file version](#apis-that-report-version-now-report-product-and-not-file-version)
- [Custom EncoderFallbackBuffer instances cannot fall back recursively](#custom-encoderfallbackbuffer-instances-cannot-fall-back-recursively)
- [Floating point formatting and parsing behavior changes](#floating-point-formatting-and-parsing-behavior-changed)
- [Floating-point parsing operations no longer fail or throw an OverflowException](#floating-point-parsing-operations-no-longer-fail-or-throw-an-overflowexception)
- [InvalidAsynchronousStateException moved to another assembly](#invalidasynchronousstateexception-moved-to-another-assembly)
- [NET Core 3.0 follows Unicode best practices when replacing ill-formed UTF-8 byte sequences](#net-core-30-follows-unicode-best-practices-when-replacing-ill-formed-utf-8-byte-sequences)
- [TypeDescriptionProviderAttribute moved to another assembly](#typedescriptionproviderattribute-moved-to-another-assembly)
- [ZipArchiveEntry no longer handles archives with inconsistent entry sizes](#ziparchiveentry-no-longer-handles-archives-with-inconsistent-entry-sizes)
- [JSON serializer exception type changed from JsonException to NotSupportedException](#json-serializer-exception-type-changed-from-jsonexception-to-notsupportedexception)
- [Change in semantics of (string)null in Utf8JsonWriter](#change-in-semantics-of-stringnull-in-utf8jsonwriter)
- [JsonEncodedText.Encode methods have an additional JavaScriptEncoder argument](#jsonencodedtextencode-methods-have-an-additional-javascriptencoder-argument)
- [JsonFactoryConverter.CreateConverter signature changed](#jsonfactoryconvertercreateconverter-signature-changed)
- [JsonElement API changes](#jsonelement-api-changes)
- [Private fields added to built-in struct types](#private-fields-added-to-built-in-struct-types)
- [Change in default value of UseShellExecute](#change-in-default-value-of-useshellexecute)

## .NET Core 3.0

[!INCLUDE[APIs that report version now report product and not file version](~/includes/core-changes/corefx/3.0/version-information-changes.md)]

***

[!INCLUDE[Custom EncoderFallbackBuffer instances cannot fall back recursively](~/includes/core-changes/corefx/3.0/custom-encoderfallbackbuffer-cannot-be-recursive.md)]

***

[!INCLUDE[Floating point formatting and parsing behavior changes](~/includes/core-changes/corefx/3.0/floating-point-changes.md)]

***

[!INCLUDE[Floating-point parsing operations no longer fail or throw an OverflowException](~/includes/core-changes/corefx/3.0/floating-point-parsing-does-not-overflow.md)]

***

[!INCLUDE[InvalidAsynchronousStateException moved to another assembly](~/includes/core-changes/corefx/3.0/move-invalidasynchronousstateexception.md)]

***

[!INCLUDE[NET Core 3.0 follows Unicode best practices when replacing ill-formed UTF-8 byte sequences](~/includes/core-changes/corefx/3.0/net-core-3-0-follows-unicode-utf8-best-practices.md)]

***

[!INCLUDE[TypeDescriptionProviderAttribute moved to another assembly](~/includes/core-changes/corefx/3.0/move-typedescriptionproviderattribute.md)]

***

[!INCLUDE[ZipArchiveEntry no longer handles archives with inconsistent entry sizes](~/includes/core-changes/corefx/3.0/ziparchiveentry-and-inconsistent-entry-sizes.md)]

***

## .NET Core 3.0 Preview 9

[!INCLUDE[JSON serializer exception type changed from JsonException to NotSupportedException](~/includes/core-changes/corefx/3.0/serializer-throws-notsupportedexception.md)]

***

## .NET Core 3.0 Preview 8

[!INCLUDE[Change in semantics of (string)null in Utf8JsonWriter](~/includes/core-changes/corefx/3.0/change-in-null-in-utf8jsonwriter.md)]

***

[!INCLUDE[JsonEncodedText.Encode methods have an additional JavaScriptEncoder argument](~/includes/core-changes/corefx/3.0/jsonencodedtext-encode-has-additional-argument.md)]

***

[!INCLUDE[JsonFactoryConverter.CreateConverter signature changed](~/includes/core-changes/corefx/3.0/jsonfactoryconverter-createconverter.md)]

***

## .NET Core 3.0 Preview 7

[!INCLUDE[JsonElement API changes](~/includes/core-changes/corefx/3.0/jsonelement-api-changes.md)]

***

## .NET Core 2.1

[!INCLUDE[Private fields added to built-in struct types](~/includes/core-changes/corefx/2.1/instantiate-struct.md)]

***

[!INCLUDE[Change in default value of UseShellExecute](~/includes/core-changes/corefx/2.1/process-start-changes.md)]

***
