---
title: Get started with semantic analysis
description: This tutorial provides an overview of working with semantic analysis using the .NET Compiler SDK.
author: billwagner
ms.author: wiwagn
ms.date: 02/06/2018
ms.topic: conceptual
ms.prod: .net
ms.devlang: devlang-csharp
ms.custom: mvc
---

# Get started with semantic analysis

This tutorial assumes you're familiar with the Syntax API. The [get started with syntax analysis](syntax-analysis.md) article provides sufficient introduction.

In this tutorial we'll explore the **Symbol** and **Binding APIs**. These APIs provide information about the _semantic meaning_ of a program. They enable you to ask and answer questions about the types represented by any symbol in your program.

## Understanding Compilations and Symbols

As you work more with the .NET Compiler SDK you'll become familiar with the distinctions between Syntax API and the Semantic API. The **Syntax API** allows you to look at the _structure_ of a program. However, often you'll want richer information about the semantics or _meaning_ of a program. While a loose code file or snippet of VB or C# code can be syntactically analyzed in isolation it's not very meaningful to ask questions such as "what's the type of this variable" in a vacuum. The meaning of a type name may be dependent on assembly references, namespace imports, or other code files. Those questions are answered using the **Semantic API**, specifically the <xref:Microsoft.CodeAnalysis.Compilation?displayProperty=nameWithType> class.

A <xref:Microsoft.CodeAnalysis.Compilation?displayProperty=nameWithType> is analogous to a single project as seen by the compiler and represents everything needed to compile a Visual Basic or C# program. This includes the set of source files to be compiled, assembly references, compiler options. You can reason about the meaning of the code using all the other information in this context. A <xref:Microsoft.CodeAnalysis.Compilation?displayProperty=nameWithType> allows you to find **Symbols** - entities such as types, namespaces, members, and variables which names and other expressions refer to. The process of associating names and expressions with **Symbols** is called **Binding**.

Like <xref:Microsoft.CodeAnalysis.SyntaxTree?displayProperty=nameWithType>, <xref:Microsoft.CodeAnalysis.Compilation?displayProperty=nameWithType> is an abstract class with language-specific derivatives. When creating an instance of Compilation you must invoke a factory method on the <xref:Microsoft.CodeAnalysis.CSharp.CSharpCompilation?displayProperty=nameWithType> (or <xref:Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation?displayProperty=nameWithType>) class.

## Querying symbols

In this tutorial, you'll look at the "Hello World" program again. This time, you'll query the symbols in the program to understand what types those symbols represent. You'll query for the types in a namespace, and learn to query for the methods available on a type.

> [!IMPORTANT]
> The following samples require the **.NET Compiler SDK** installed as part of Visual Studio 2017. You can find the .NET Compiler SDK as the last optional component listed under the **Visual Studio extension development** workload. The templates aren't installed without this component.

You can see the finished code for this sample in [our GitHub samples repository](https://github.com/dotnet/samples/csharp/roslyn-sdk/SemanticQuickStart).

> [!NOTE]
> The Syntax Tree types use inheritance to describe the different syntax elements that are valid at different locations in the program. Using these APIs often means casting properties or collection members to specific derived types. In the following examples, the assignment and the casts are separate statements, using explicitly typed variables. You can read the code to see the return types of the API and the runtime type of the objects returned. In practice, it's more common to use implicitly typed variables and rely on API names to describe the type of objects being examined.

Create a new C# **Stand-Alone Code Analysis Tool** project:

* In Visual Studio, choose **File** > **New** > **Project** to display the New Project dialog.
* Under **Visual C#** > **Extensibility**, choose **Stand-Alone Code Analysis Tool**.
* Name your project "**SemanticQuickStart**" and click OK.

You're going to analyze the basic "Hello World!" program shown earlier.
Add the text for the Hello World program as a constant in your `Program` class:

[!code-csharp[Declare the program test](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#1 "Declare a constant string for the program text to analyze")]

Next, add the following code to build the syntax tree for the code text in the `programText` constant.  Add the following line to your `Main` method:

[!code-csharp[Create the tree](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#2 "Create the syntax tree")]

Next, build a <xref:Microsoft.CodeAnalysis.CSharp.CSharpCompilation?displayProperty=nameWithType> from the tree you already created. The "Hello World" sample relies on the <xref:System.String> and <xref:System.Console> types. You'll need to reference the assembly that declares those two types in your compilation. Add the following line to your `Main` method to create a compilation of your syntax tree, including the reference to the appropriate assembly:

[!code-csharp[Create the compilation](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#3 "Create the compilation for the semantic model")]

The <xref:Microsoft.CodeAnalysis.CSharp.CSharpCompilation.AddReferences%2A?displayProperty=nameWithType> method adds references to the compilation. The <xref:Microsoft.CodeAnalysis.MetaDataReference.CreateFromFile%2A?displayProperty=nameWithType> method loads an assembly as a reference. 

## Querying the semantic model

Once you have a <xref:Microsoft.CodeAnalysis.Compilation?displayProperty=nameWithType> you can ask it for a <xref:Microsoft.CodeAnalysis.SemanticModel> for any <xref:Microsoft.CodeAnalysis.SyntaxTree> contained in that <xref:Microsoft.CodeAnalysis.Compilation>. You can think of the semantic model as the source for all the information would normally get from intellisense. A <xref:Microsoft.CodeAnalysis.SemanticModel> can answer questions like "What names are in scope at this location?" "What members are accessible from this method?" "What variables are used in this block of text?" and "What does this name/expression refer to?" Add this statement to create the semantic model:

[!code-csharp[Create the semantic model](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#4 "Create the semantic model")]

## Binding a name

The <xref:Microsoft.CodeAnalysis.Compilation> creates the  <xref:Microsoft.CodeAnalysis.SemanticModel> from the <xref:Microsoft.CodeAnalysis.SyntaxTree>. After creating the model, you can query it to find the first `using` directive, and retrieve the symbol information for the `System` namespace. Add these two lines to your `Main` method to create the semantic model and retrieve the symbol for the first using statement:

[!code-csharp[Find the namespace symbol for the first using](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#5 "Find the namespace symbol for the first using")]

The preceding code shows how to obtain a <xref:Microsoft.CodeAnalysis.SemanticModel> object for our HelloWorld <xref:Microsoft.CodeAnalysis.SyntaxTree>. Once the model is obtained, the name in the first `using` directive is bound to retrieve a <xref:Microsoft.CodeAnalysis.SymbolInfo?displayProperty=nameWithType> for the `System` namespace. The preceding code also illustrates how you use the **syntax model** to find the structure of the code and the **semantic model** to understand its meaning. The **syntax model** finds the string `System` in the using statement. The **semantic model** has all the information about the types defined in the `System` namespace.

From the <xref:Microsoft.CodeAnalysis.SymbolInfo?displayProperty=nameWithType> object you can obtain the the <xref:Microsoft.CodeAnalysis.ISymbol?displayProperty=nameWithType> using the <xref:Microsoft.CodeAnalysis.SymbolInfo.Symbol?displayProperty=nameWithType> property. This property returns the symbol this expression refers to. For expressions which don't refer to anything (such as numeric literals) this property will be `null`. When the <xref:Microsoft.CodeAnalysis.SymbolInfo.Symbol?displayProperty=nameWithType> is not null, the <xref:Microsoft.CodeAnalysis.ISymbol.Kind?displayProperty=nameWithType> denotes the type of the symbol. In this example, the <xref:Microsoft.CodeAnalysis.ISymbol.Kind?displayProperty=nameWithType> property is a <xref:Micrososft.CodeAnalysis.SymbolKind.Namespace?displayProperty=nameWithType>. Add the following code to your `Main` method to retrieve the symbol for the `System` namespace and then display all the child namespaces that are declared in the `System` namespace:

[!code-csharp[Display all the child namespaces](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#6 "Display all the child namespaces from this compilation")]

Run the program and you should see the following output:

```
Collections
Configuration
Deployment
Diagnostics
Globalization
IO
Reflection
Resources
Runtime
Security
StubHelpers
Text
Threading
Press any key to continue . . .
```

> [!NOTE]
> This does not include every namespace that is a child namespace of the `System` namespace. It displays every namespace that is present in this compilation, which only references the assembly where the `System.String` type is declared. Any namespaces declared in other assemblies are not known to this compilation

### Binding an expression

The preceding code shows how to find a symbol by binding to a name. There are other expressions in a C# program that can be bound that aren't names. To demonstrate this capability, let's access the binding to a simple string literal.

The "Hello World" program contains a <xref:Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax?displayProperty=nameWithType>, the "Hello, World!" string displayed to the console.

You find the "Hello, World!" string by locating the single string literal in the program. Then, once you've located the syntax node, get the type info for that node from the semantic model. Add the following code to your `Main` method:

[!code-csharp[Find the namespace symbol for the only using](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#7 "Find the namespace symbol for the only using")]

The <xref:Microsoft.CodeAnalysis.TypeInfo?displayProperty=nameWithType> struct includes a <xref:Microsoft.CodeAnalysis.TypeInfo.Type?displayProperty=nameWithType> property that enables access to the semantic information about the type of the literal. In this example, that's the `string` type. Add a declaration that assigns this property to a local variable:

[!code-csharp[Find the semantic information about the string type](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#8 "Use the string literal to access the semantic information in the string type.")]

To finish this tutorial, let's build a LINQ query that creates a sequence of all the public methods declared on the `string` type that return a `string`. This query gets somewhat complex, so let's build it line by line, then reconstruct it as a single query. The source for this query is the sequence of all members declarated on the `string` type:

[!code-csharp[Access the sequence of members on the string type](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#9 "Access the sequence of members on the string type.")]

That source sequencconatins all members, including properties and fields, so filter it using the <xref:System.Collections.Immutable.ImmutableArray%601.OfType%2A?displayProperty=nameWithType> method to find elements that are <xref:Microsoft.CodeAnalysis.IMethodSymbol?diplayProperty=nameWithType> objects:

[!code-csharp[Filter the sequence to only methods](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#10 "Find the subset of the colelction that is the methods.")]

Next, add another filter to return only those methods that are public and return a `string`:

[!code-csharp[Filter on return type and accessibility](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#11 "Find only the public methods that return a string.")]

Select only the name property, and only distinct names by removing any overloads:

[!code-csharp[find the distinct names.](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#12 "Use the string literal to access the semantic information in the string type.")]

You can also build the full query using the LINQ query sytnax, and then display all the method names in  the console:

[!code-csharp[build and display the results of this query.](../../../../samples/csharp/roslyn-sdk/SemanticQuickStart/SemanticQuickStart/Program.cs#12 "Build and display the results of the query.")]

Build and run the program. You should see the following output:

```
Join
Substring
Trim
TrimStart
TrimEnd
Normalize
PadLeft
PadRight
ToLower
ToLowerInvariant
ToUpper
ToUpperInvariant
ToString
Insert
Replace
Remove
Format
Copy
Concat
Intern
IsInterned
Press any key to continue . . .
```
You've used the Semantic API to find and display information about the symbols that are part of this program.
