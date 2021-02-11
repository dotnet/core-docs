---
title: "Breaking change: Nullable reference type annotation changes"
description: Learn about the .NET 6.0 breaking change in core .NET libraries where some nullable reference type annotations have changed.
ms.date: 02/11/2021
---
# Changes to nullable reference type annotations

In .NET 6.0, some nullability annotations in the .NET libraries have changed.

## Change description

In previous .NET versions, there are some incorrect nullable reference type annotations, and build warnings are either absent or incorrect. Starting in .NET 6.0, some annotations that were previously applied have been updated. New build warnings will be produced and incorrect build warnings will no longer be produced for the affected APIs.

Some of these changes are considered *breaking* changes because they can lead to new build-time warnings. Code that references these APIs will need to be updated when migrating to .NET 6.0. Other changes that aren't considered to be breaking are also documented here, as any referencing code may benefit from removing operators or pragmas that become unnecessary.

## Version introduced

6.0

## Reason for change

Starting in .NET Core 3.0, nullability annotations were applied to the .NET libraries. From the outset of this effort, we anticipated that mistakes would be made in these annotations and fixes would need to be made. Through feedback and further testing, the nullable annotations for the affected APIs were determined to be inaccurate. The updated annotations correctly represent the nullability contracts for the APIs.

## Recommended action

Update code that calls these APIs to reflect the revised nullability contracts.

## Affected APIs

The following table lists the affected APIs:

| API | What changed | Breaking or nonbreaking | Version added |
| - | - | - |
| <xref:System.ComponentModel.ISite.Container?displayProperty=fullName> | Property type is nullable | Breaking | Preview 1 |
| <xref:System.Xml.Linq.XContainer.Add(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XContainer.AddFirst(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XContainer.ReplaceNodes(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XDocument.%23ctor(System.Object[])> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XDocument.%23ctor(System.Xml.Linq.XDeclaration,System.Object[])> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XElement.%23ctor(System.Xml.Linq.XName,System.Object[])> | Second parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XElement.ReplaceAll(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XElement.ReplaceAttributes(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XNode.AddAfterSelf(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XNode.AddBeforeSelf(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XNode.ReplaceWith(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XStreamingElement.%23ctor(System.Xml.Linq.XName,System.Object)> | Second parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XStreamingElement.%23ctor(System.Xml.Linq.XName,System.Object[])> | Second parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Xml.Linq.XStreamingElement.Add(System.Object[])?displayProperty=fullName> | Parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Net.Http.HttpClient.PatchAsync%2A?displayProperty=fullName> | `content` parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Net.Http.HttpClient.PostAsync%2A?displayProperty=fullName> | `content` parameter type is nullable  | Nonbreaking | Preview 1 |
| <xref:System.Net.Http.HttpClient.PutAsync%2A?displayProperty=fullName> | `content` parameter type is nullable  | Nonbreaking | Preview 1 |
| <xref:System.Linq.Expressions.MethodCallExpression.Update(System.Linq.Expressions.Expression,System.Collections.Generic.IEnumerable{System.Linq.Expressions.Expression})?displayProperty=fullName> | First parameter type is nullable | Nonbreaking | Preview 1 |
| <xref:System.Linq.Expressions.Expression%601.Update(System.Linq.Expressions.Expression,System.Collections.Generic.IEnumerable{System.Linq.Expressions.ParameterExpression})?displayProperty=fullName> | Return type is not nullable | Nonbreaking | Preview 1 |
| <xref:System.Data.IDataRecord.GetBytes(System.Int32,System.Int64,System.Byte[],System.Int32,System.Int32)?displayProperty=fullName> | `buffer` parameter type is nullable | Breaking | Preview 1 |
| <xref:System.Data.IDataRecord.GetChars(System.Int32,System.Int64,System.Char[],System.Int32,System.Int32)?displayProperty=fullName> | `buffer` parameter type is nullable | Breaking | Preview 1 |
| <xref:System.Data.Common.DbDataRecord.GetBytes(System.Int32,System.Int64,System.Byte[],System.Int32,System.Int32)?displayProperty=fullName> | `buffer` parameter type is nullable | Breaking | Preview 1 |
| <xref:System.Data.Common.DbDataRecord.GetChars(System.Int32,System.Int64,System.Char[],System.Int32,System.Int32)?displayProperty=fullName> | `buffer` parameter type is nullable | Breaking | Preview 1 |

<!--

### Category

Core .NET libraries

### Affected APIs

- `P:System.ComponentModel.ISite.Container`
- `M:System.Xml.Linq.XContainer.Add(System.Object[])`
- `M:System.Xml.Linq.XContainer.AddFirst(System.Object[])`
- `M:System.Xml.Linq.XContainer.ReplaceNodes(System.Object[])`
- `M:System.Xml.Linq.XDocument.#ctor(System.Object[])`
- `M:System.Xml.Linq.XDocument.#ctor(System.Xml.Linq.XDeclaration,System.Object[])`
- `M:System.Xml.Linq.XElement.#ctor(System.Xml.Linq.XName,System.Object[])`
- `M:System.Xml.Linq.XElement.ReplaceAll(System.Object[])`
- `M:System.Xml.Linq.XElement.ReplaceAttributes(System.Object[])`
- `M:System.Xml.Linq.XNode.AddAfterSelf(System.Object[])`
- `M:System.Xml.Linq.XNode.AddBeforeSelf(System.Object[])`
- `M:System.Xml.Linq.XNode.ReplaceWith(System.Object[])`
- `M:System.Xml.Linq.XStreamingElement.#ctor(System.Xml.Linq.XName,System.Object)`
- `M:System.Xml.Linq.XStreamingElement.#ctor(System.Xml.Linq.XName,System.Object[])`
- `M:System.Xml.Linq.XStreamingElement.Add(System.Object[])`
- `O:System.Net.Http.HttpClient.PatchAsync`
- `O:System.Net.Http.HttpClient.PostAsync`
- `O:System.Net.Http.HttpClient.PutAsync`
- `M:System.Linq.Expressions.MethodCallExpression.Update(System.Linq.Expressions.Expression,System.Collections.Generic.IEnumerable{System.Linq.Expressions.Expression})`
- `M:System.Linq.Expressions.Expression%601.Update(System.Linq.Expressions.Expression,System.Collections.Generic.IEnumerable{System.Linq.Expressions.ParameterExpression})`
- `M:System.Data.IDataRecord.GetBytes(System.Int32,System.Int64,System.Byte[],System.Int32,System.Int32)`
- `M:System.Data.IDataRecord.GetChars(System.Int32,System.Int64,System.Char[],System.Int32,System.Int32)`
- `M:System.Data.Common.DbDataRecord.GetBytes(System.Int32,System.Int64,System.Byte[],System.Int32,System.Int32)`
- `M:System.Data.Common.DbDataRecord.GetChars(System.Int32,System.Int64,System.Char[],System.Int32,System.Int32)`

-->
