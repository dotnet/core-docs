---
title: How to articles (C# Guide)
description: A collection of quick tips and short, focused code samples
author: billwagner
ms.author: wiwagn
ms.date: 12/20/2017
ms.topic: article
ms.prod: .net
ms.devlang: devlang-csharp
---

# How to (C#)

The How to section of the C# Guide is where you can find quick answers
to common questions. There are cases on this page were one article may
be listed in multiple sections. We wanted to make them easy to find
for multiple search paths. 

## General C# concepts

There are several tips and tricks that are common C# developer practices.

- Using many libraries can introduce name conflicts. You can resolve them by knowing [how to use the global namespace alias](../programming-guide/namespaces/how-to-use-the-global-namespace-alias.md).
- Even C# programmers may want to [use the `My` namespace from VB](../programming-guide/namespaces/how-to-use-the-my-namespace.md).
- Lambda expressions are useful to pass code as data. Learn [how to use lambda expressions](
../programming-guide/statements-expressions-operators/how-to-use-lambda-expressions-outside-linq.md).
- Learn [how to use operator overloading](../programming-guide/statements-expressions-operators/how-to-use-operator-overloading-to-create-a-complex-number-class.md) in this complex number class example.
- You can [initialize objects using an object initializer](../programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer.md).
- There are [differences between passing a struct and a class to a method](../programming-guide/classes-and-structs/how-to-know-the-difference-passing-a-struct-and-passing-a-class-to-a-method.md).
- You can [implement and call a custom extension method](../programming-guide/classes-and-structs/how-to-implement-and-call-a-custom-extension-method.md) on any type you create.

### Class and struct members

You create classes and structs to implement your program. These techniques are common tasks when writing classes or structs.

- Many types [override the `ToString` method](../programming-guide/classes-and-structs/how-to-override-the-tostring-method.md) to provide a string representation of the object.
- Learn [how to define constants](../programming-guide/classes-and-structs/how-to-define-constants.md).
- [Declare and use read/write properties](../programming-guide/classes-and-structs/how-to-declare-and-use-read-write-properties.md).
- Use [auto implemented properties](../programming-guide/classes-and-structs/how-to-implement-a-lightweight-class-with-auto-implemented-properties.md) to declare data members of a `class` or `struct`.
- Use extension methods to [create a new method for an `enum` type](../programming-guide/classes-and-structs/how-to-create-a-new-method-for-an-enumeration.md).
- Learn [how to define abstract properties](../programming-guide/classes-and-structs/how-to-define-abstract-properties.md).
- Learn techniques to [explicitly implement members of two interfaces](../programming-guide/interfaces/how-to-explicitly-implement-members-of-two-interfaces.md).
- You can [explicitly implement interface members](../programming-guide/interfaces/how-to-explicitly-implement-interface-members.md) to keep your public interface more clear.
- [Use the xml documentation features](../programming-guide/xmldoc/how-to-use-the-xml-documentation-features.md) to document your code.

### Working with collections

These articles help you work with collections of data.

- You can [initialize a dictionary with a collection initializer](../programming-guide/classes-and-structs/how-to-initialize-a-dictionary-with-a-collection-initializer.md).
- You can [access all the elements in a collection using `foreach`](../programming-guide/classes-and-structs/how-to-access-a-collection-class-with-foreach.md).

## strings

Strings are the fundamental data type used to display or manipulate text. These articles demonstrate common practices with strings.

- See how to [compare strings](../programming-guide/strings/how-to-compare-strings.md).
- Learn techniques to [modify the contents of a string](../programming-guide/strings/how-to-modify-string-contents.md).
- Learn to [search strings using regular expressions](../programming-guide/strings/how-to-search-strings-using-regular-expressions.md).
- [Use <xref:System.String.Split%2A> to separate strings](../programming-guide/strings/how-to-parse-strings-using-string-split.md).
- [Combine multiple strings into one](../programming-guide/strings/how-to-concatenate-multiple-strings.md).
- Learn how to [determine if a string represents a number](../programming-guide/strings/how-to-determine-whether-a-string-represents-a-numeric-value.md).
- Learn to [search for text in a string](../programming-guide/strings/how-to-search-strings-using-string-methods.md).

## Converting between types

You may need to convert an object to a different type.

- Learn how to [determine if a string represents a number](../programming-guide/strings/how-to-determine-whether-a-string-represents-a-numeric-value.md).
- [Convert a string to a <xref:System.DateTime>](../programming-guide/strings/how-to-convert-a-string-to-a-datetime.md).
- See [how to convert a byte array to an int](../programming-guide/types/how-to-convert-a-byte-array-to-an-int.md).
- Learn to [convert between strings that represent hexadecimal numbers and the number](../programming-guide/types/how-to-convert-between-hexadecimal-strings-and-numeric-types.md).
- Learn [how to convert a string to a number](../programming-guide/types/how-to-convert-a-string-to-a-number.md).
- Use `as` and `is` to [safely cast to a different type](../programming-guide/types/how-to-safely-cast-by-using-as-and-is-operators.md).
- You can [define conversion operators for `struct` types](../programming-guide/statements-expressions-operators/how-to-implement-user-defined-conversions-between-structs.md).
- See techniques to [convert between nullable and non-nullable value types](../programming-guide/nullable-types/how-to-safely-cast-from-bool-to-bool.md).
- Learn to [determine if a type is a nullable type](../programming-guide/nullable-types/how-to-identify-a-nullable-type.md).

## Equality and ordering comparisons

You may create types that define their own rules for equality or define a
natural ordering among objects of that type.

- Learn to [define value based equality for a type](../programming-guide/statements-expressions-operators/how-to-define-value-equality-for-a-type.md)
- Learn how to [test for reference based equality](../programming-guide/statements-expressions-operators/how-to-test-for-reference-equality-identity.md)

## Exception handling

Throwing exceptions is how .NET programs report that methods did not
successfully complete their work. In these articles you'll learn to work
with exceptions.

- Learn how to [handle exceptions using `try` and `catch`](../programming-guide/exceptions/how-to-handle-an-exception-using-try-catch.md)
- Learn how to [cleanup using `finally` clauses](../programming-guide/exceptions/how-to-execute-cleanup-code-using-finally.md)
- Learn to work with [non-CLS (Common Language Specification) exceptions](../programming-guide/exceptions/how-to-catch-a-non-cls-exception.md)

## Delegates and events

Delegates and events provide a capability for strategies that involve
loosely coupled blocks of code.

- Learn how to [declare, instantiate, and use delegates](../programming-guide/delegates/how-to-declare-instantiate-and-use-a-delegate.md)
- Learn how to [combine multicast delegates](../programming-guide/delegates/how-to-combine-delegates-multicast-delegates.md)

Events provide a mechanism to publish notifications or subscribe to notifications.

- Learn how to [subscribe and unsubscrbe from events](../programming-guide/events/how-to-subscribe-to-and-unsubscribe-from-events.md)
- Learn to [implement events declared in interfaces](../programming-guide/events/how-to-implement-interface-events.md)
- Learn to [conform to .NET Framework guidelines when your code publishes events](../programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines.md)
- Learn to [raise events defined in base classes from derived classes](../programming-guide/events/how-to-raise-base-class-events-in-derived-classes.md)
- Learn to [store event instances in a dictionarly](../programming-guide/events/how-to-use-a-dictionary-to-store-event-instances.md)
- Learn to [implement custom event accessors](../programming-guide/events/how-to-implement-custom-event-accessors.md)

## LINQ practices

LINQ enables you to write code to query any data source that supports the
LINQ query expression pattern. These articles help you understand the pattern
and work with different data sources.

- [Query a collection](../programming-guide/concepts/linq/how-to-query-an-arraylist-with-linq.md)
- [Sort elements of a data source](../programming-guide/concepts/linq/how-to-sort-elements.md)
- [Sort elements on multiple keys](../programming-guide/concepts/linq/how-to-sort-elements-on-multiple-keys.md)
- [How to use lambda expressions in a query](../programming-guide/statements-expressions-operators/how-to-use-lambda-expressions-in-a-query.md)
- [Use `var` in query expressions](../programming-guide/classes-and-structs/how-to-use-implicitly-typed-local-variables-and-arrays-in-a-query-expression.md)
- [Return subsets of element properties from a query](../programming-guide/classes-and-structs/how-to-return-subsets-of-element-properties-in-a-query.md)
- [Combine LINQ queries with regular expressions](../programming-guide/concepts/linq/how-to-combine-linq-queries-with-regular-expressions.md)
- [Learn to debug empty query results](../programming-guide/concepts/linq/how-to-debug-empty-query-results-sets.md)
- [Calculate intermediate values](../programming-guide/concepts/linq/how-to-calculate-intermediate-values.md)
- [Write queries with complex filtering](../programming-guide/concepts/linq/how-to-write-queries-with-complex-filtering.md)
- [Merge data from multiple sources](../programming-guide/concepts/linq/how-to-populate-object-collections-from-multiple-sources-linq.md)
- [Control the type of a projection](../programming-guide/concepts/linq/how-to-control-the-type-of-a-projection.md)
- [Add custom methods to LINQ queries](../programming-guide/concepts/linq/how-to-add-custom-methods-for-linq-queries.md)
- [Find the set difference between two sequences](../programming-guide/concepts/linq/how-to-find-the-set-difference-between-two-lists-linq.md)

LINQ can work with structured text data:

- [Filter structured text data on any word or field](../programming-guide/concepts/linq/how-to-sort-or-filter-text-data-by-any-word-or-field-linq.md)
- [Learn to count occurences of a word](../programming-guide/concepts/linq/how-to-count-occurrences-of-a-word-in-a-string-linq.md)
- [Query for characters in a string](../programming-guide/concepts/linq/how-to-query-for-characters-in-a-string-linq.md)
- [Combine and compare string collections](../programming-guide/concepts/linq/how-to-combine-and-compare-string-collections-linq.md)
- [Parse a string](../programming-guide/concepts/linq/how-to-parse-a-string.md)
- [query for sentences that contain a specific set of words](../programming-guide/concepts/linq/how-to-query-for-sentences-that-contain-a-specified-set-of-words-linq.md)
- [Compute values from the columns of a CSV file](../programming-guide/concepts/linq/how-to-compute-column-values-in-a-csv-text-file-linq.md)

LINQ can process folders and file contents:

- [Compare the contents of two folders](../programming-guide/concepts/linq/how-to-compare-the-contents-of-two-folders-linq.md)
- [Join content from dissimilar CSV files](../programming-guide/concepts/linq/how-to-join-content-from-dissimilar-files-linq.md)
- [Create XML fril CSV file content](../programming-guide/concepts/linq/how-to-generate-xml-from-csv-files.md)
- [Populate an XML tree from the file system](../programming-guide/concepts/linq/how-to-populate-an-xml-tree-from-the-file-system.md)
- [Read multiple files and organzie the data using groups](../programming-guide/concepts/linq/how-to-split-a-file-into-many-files-by-using-groups-linq.md)
- [Find files matching a pattern in a directory](../programming-guide/concepts/linq/how-to-query-for-files-with-a-specified-attribute-or-name.md)
- [Find the total number of bytes in a set of folders](../programming-guide/concepts/linq/how-to-query-for-the-total-number-of-bytes-in-a-set-of-folders-linq.md)
- [Reorder the fields of a delimited file](../programming-guide/concepts/linq/how-to-reorder-the-fields-of-a-delimited-file-linq.md)
- [Query for duplicate files in a directory tree](../programming-guide/concepts/linq/how-to-query-for-duplicate-files-in-a-directory-tree-linq.md)
- [Query for the largest files in a directory](../programming-guide/concepts/linq/how-to-query-for-the-largest-file-or-files-in-a-directory-tree-linq.md)
- [Query the contents of files in a folder](../programming-guide/concepts/linq/how-to-query-the-contents-of-files-in-a-folder-lin.md)

LINQ to XML is an implementation of LINQ for XML data sources:

- [Find an attribute of the parent using XPath](../programming-guide/concepts/linq/how-to-find-an-attribute-of-the-parent-xpath-linq-to-xml.md)
- [Find child elements based on position](../programming-guide/concepts/linq/how-to-find-child-elements-based-on-position-xpath-linq-to-xml.md)
- [Find the immediate preceding sibling](../programming-guide/concepts/linq/how-to-find-the-immediate-preceding-sibling-xpath-linq-to-xml.md)
- [Catch parsing errors in XML data sources](../programming-guide/concepts/linq/how-to-catch-parsing-errors.md)
- [Find related elements](../programming-guide/concepts/linq/how-to-find-related-elements-xpath-linq-to-xml.md)
- [Create a tree structure from an XML reader](../programming-guide/concepts/linq/how-to-create-a-tree-from-an-xmlreader.md)
- [Find all nodes in an XML namespace](../programming-guide/concepts/linq/how-to-find-all-nodes-in-a-namespace.md)
- [Write a method to retrieve a subset of a tree](../programming-guide/concepts/linq/how-to-write-a-linq-to-xml-axis-method.md)
- [Transform large XML documents from an input stream](../programming-guide/concepts/linq/how-to-perform-streaming-transform-of-large-xml-documents.md)
- [Find elements in an XML namespace](../programming-guide/concepts/linq/how-to-find-elements-in-a-namespace-xpath-linq-to-xml.md)
- [How to control namespace prefixes when writing XML data](../programming-guide/concepts/linq/how-to-control-namespace-prefixes-linq-to-xml.md)
- [Final descendent elements with a specific name](../programming-guide/concepts/linq/how-to-find-descendants-with-a-specific-element-name.md)
- [Read and Write encoded XML documents](../programming-guide/concepts/linq/how-to-read-and-write-an-encoded-document.md)
- [Retrieve paragraphs from an office open XML document](../programming-guide/concepts/linq/how-to-retrieve-paragraphs-from-an-office-open-xml-document.md)
- [Create XML fril CSV file content](../programming-guide/concepts/linq/how-to-generate-xml-from-csv-files.md)
- [Populate an XML tree from the file system](../programming-guide/concepts/linq/how-to-populate-an-xml-tree-from-the-file-system.md)
- [Find an element with a specific attribute](../programming-guide/concepts/linq/how-to-find-an-element-with-a-specific-attribute.md)
- [Filter on an optional element](../programming-guide/concepts/linq/how-to-filter-on-an-optional-element.md)
- [Find sibling nodes](../programming-guide/concepts/linq/how-to-find-sibling-nodes-xpath-linq-to-xml.md)
- [List all nodes in a string](../programming-guide/concepts/linq/how-to-list-all-nodes-in-a-tree.md)
- [Find descendent elements](../programming-guide/concepts/linq/how-to-find-descendant-elements-xpath-linq-to-xml.md)
- [Join two collections based on an attribute](../programming-guide/concepts/linq/how-to-join-two-collections-linq-to-xml.md)
- [Perform streaming transformations of text to XML](../programming-guide/concepts/linq/how-to-perform-streaming-transformations-of-text-to-xml.md)
- [Project a new type](../programming-guide/concepts/linq/how-to-project-a-new-type-linq-to-xml.md)
- [Change the namespace for an entire tree](../programming-guide/concepts/linq/how-to-change-the-namespace-for-an-entire-xml-tree.md)
- [Serialze using the <xref:System.Runtime.Serialization.DataContractSerializer>](../programming-guide/concepts/linq/how-to-serialize-using-datacontractserializer.md)
- [Project to anonymous types](../programming-guide/concepts/linq/how-to-project-an-anonymous-type.md)
- [Create a hierarchy using grouping](../programming-guide/concepts/linq/how-to-create-hierarchy-using-grouping.md)
- [Retrieve the shallow value from an element](../programming-guide/concepts/linq/how-to-retrieve-the-shallow-value-of-an-element.md)
- [Populate an XML tree](../programming-guide/concepts/linq/how-to-populate-an-xml-tree-with-an-xmlwriter-linq-to-xml.md)
- [Project XML data into an object graph](../programming-guide/concepts/linq/how-to-project-an-object-graph.md)
- [Filter on element names](../programming-guide/concepts/linq/how-to-filter-on-element-names-linq-to-xml.md)
- [Stream XML fragments including header information](../programming-guide/concepts/linq/how-to-stream-xml-fragments-with-access-to-header-information.md)
- [Retrieve a single attribute from an element](../programming-guide/concepts/linq/how-to-retrieve-a-single-attribute-linq-to-xml.md)
- [Find a single descendant in an XML tree](../programming-guide/concepts/linq/how-to-find-a-single-descendant-using-the-descendants-method.md)
- [Find the union of two location paths](../programming-guide/concepts/linq/how-to-find-a-union-of-two-location-paths-xpath-linq-to-xml.md)
- [Write a query that finds elements based on context in a document](../programming-guide/concepts/linq/how-to-write-a-query-that-finds-elements-based-on-context.md)
- [Find preceding siblings](../programming-guide/concepts/linq/how-to-find-preceding-siblings-xpath-linq-to-xml.md)
- [Find a child element](../programming-guide/concepts/linq/how-to-find-a-child-element-xpath-linq-to-xml.md)
- [Create a document with XML namespaces](../programming-guide/concepts/linq/how-to-create-a-document-with-namespaces-linq-to-xml.md)
- [Find descendants of a child element](../programming-guide/concepts/linq/how-to-find-descendants-of-a-child-element-xpath-linq-to-xml.md)
- [Retrieve the value of an element](../programming-guide/concepts/linq/how-to-retrieve-the-value-of-an-element-linq-to-xml.md)
- [Retrieve a collection of elements](../programming-guide/concepts/linq/how-to-retrieve-a-collection-of-elements-linq-to-xml.md)
- [Stream XML fragments](../programming-guide/concepts/linq/how-to-stream-xml-fragments-from-an-xmlreader.md)
- [Serialize using <xref:System.Xml.Serialization.XmlSerializer>](../programming-guide/concepts/linq/how-to-serialize-using-xmlserializer.md)
- [Write queries on XML in namespaces](../programming-guide/concepts/linq/how-to-write-queries-on-xml-in-namespaces.md)
- [Filter on an XML attribute](../programming-guide/concepts/linq/how-to-filter-on-an-attribute-xpath-linq-to-xml.md)
- [Chain method calls among fluent APIs](../programming-guide/concepts/linq/how-to-chain-axis-method-calls-linq-to-xml.md)
- [Find an element with a specific child element](../programming-guide/concepts/linq/how-to-find-an-element-with-a-specific-child-element.md)
- [Validate data using XSD](../programming-guide/concepts/linq/how-to-validate-using-xsd-linq-to-xml.md)
- [Retrieve the value of an attribute](../programming-guide/concepts/linq/how-to-retrieve-the-value-of-an-attribute-linq-to-xml.md)
- [Group files by extension](../programming-guide/concepts/linq/how-to-group-files-by-extension-linq.md)
- [Work with dictionaries using LINQ to XML](../programming-guide/concepts/linq/how-to-work-with-dictionaries-using-linq-to-xml.md)
- [Find a list of child elements](../programming-guide/concepts/linq/how-to-find-a-list-of-child-elements-xpath-linq-to-xml.md)
- [Query XML using XPath](../programming-guide/concepts/linq/how-to-query-linq-to-xml-using-xpath.md)
- [Find attributes of siblings with a specific name](../programming-guide/concepts/linq/how-to-find-attributes-of-siblings-with-a-specific-name-xpath-linq-to-xml.md)
- [Load XML from a file](../programming-guide/concepts/linq/how-to-load-xml-from-a-file.md)
- [Use annotations to transform XML trees into object graphs](../programming-guide/concepts/linq/how-to-use-annotations-to-transform-linq-to-xml-trees-in-an-xslt-style.md)
- [Find the root element using XPath](../programming-guide/concepts/linq/how-to-find-the-root-element-xpath-linq-to-xml.md)
- [Modify an office Open XML document](../programming-guide/concepts/linq/how-to-modify-an-office-open-xml-document.md)
- [Transform the shape of an XML tree](../programming-guide/concepts/linq/how-to-transform-the-shape-of-an-xml-tree.md)
- [Retrieve a collection of attributes](../programming-guide/concepts/linq/how-to-retrieve-a-collection-of-attributes-linq-to-xml.md)
- [Find elements with a specific attribute](../programming-guide/concepts/linq/how-to-find-elements-with-a-specific-attribute-xpath-linq-to-xml.md)
- [Retrieve a single child element](../programming-guide/concepts/linq/how-to-retrieve-a-single-child-element-linq-to-xml.md)
- [Generate text friles from XML](../programming-guide/concepts/linq/how-to-generate-text-files-from-xml.md)

## Multiple threads and async processing

Modern programs often use asynchronous operations. These articles will help you learn
to use these techniques.

- [Improve async performance using <xref:System.Thraeading.Tasks.Task.WhenAll%2A>](../programming-guide/concepts/async/how-to-extend-the-async-walkthrough-by-using-task-whenall.md)
- [Make multiple web requests in parallel using `async` and `await`](../programming-guide/concepts/async/how-to-make-multiple-web-requests-in-parallel-by-using-async-and-await.md)
- [Learn to use a thread pool](../programming-guide/concepts/threading/how-to-use-a-thread-pool.md)

## Command line args to your program

Typically, C# programs have command line arguments. These articles teach you to access and process
those command line arguments.

- [Learn to display command line arguments](../programming-guide/main-and-command-args/how-to-display-command-line-arguments.md)
- [Learn to display command line arguments using `foreach`](../programming-guide/main-and-command-args/how-to-access-command-line-arguments-using-foreach.md)
