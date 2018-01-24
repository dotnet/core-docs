---
title: "Ref return values and ref locals (C# Guide)"
description: "Learn how to define and use ref return and ref local values"
author: "rpetrusha"
ms.author: "ronpet"
ms.date: "01/23/2017"
ms.topic: "article"
ms.prod: ".net"
ms.technology: "devlang-csharp"
ms.devlang: "csharp"
---
# Ref returns and ref locals

Starting with C# 7, C# supports reference return values (ref returns). A reference return value allows a method to return a reference to a variable, rather than a value, back to a caller. The caller can then choose to treat the returned variable as if it were returned by value or by reference. The caller can create a new variable that is itself a reference to the returned value, called a ref local.

## What is a reference return value?

Most developers are familiar with passing an argument to a called method *by reference*. A called method's argument list includes a variable passed by reference, and any changes made to its value by the called method are observed by the caller. A *reference return value* means that a method returns a *reference* (or an alias) to some variable whose scope includes the method and whose lifetime must extend beyond the return of the method.

- The called method's return value, rather than an argument passed to it, is a reference.

- Modifications to the method's return value by the caller are made to the variable that is returned by the method.

Declaring that a method returns a *reference return value* indicates that the method returns an alias to a variable. The design intent is often that the calling code should have access to that variable through the alias, including to modify it. It follows that methods returning by reference cannot have the return type `void`.

There are some restrictions on the expression that a method can return as a reference return value. These include:

- The return value must have a lifetime that extends beyond the execution of the method. In other words, it cannot be a local variable in the method that returns it. It can be an instance or static field of a class, or it can be an argument passed to the method. Attempting to return a local variable generates compiler error CS8168, "Cannot return local 'obj' by reference because it is not a ref local."

- The return value cannot be the literal `null`. Attempting to return `null` generates compiler error CS8156, "An expression cannot be used in this context because it may not be returned by reference."

   A method with a ref return can return an alias to a variable whose value is currently the null (uninstantiated) value or a [nullable type](../nullable-types/index.md) for a value type.
 
- The return value cannot be a constant, an enumeration member, or the by-value return value from a property, or a method of a `class` or `struct`. Attempting to return these generates compiler error CS8156, "An expression cannot be used in this context because it may not be returned by reference."

In addition, because an asynchronous method may return before it has finished execution, while its return value is still unknown, reference return values are not allowed on async methods.
 
## Defining a ref return value

You define a ref return value by adding the [ref](../../language-reference/keywords/ref.md) keyword to the return type of the method signature. For example, the following signature indicates that the `GetContactInformation` property returns a reference to a `Person` object to the caller:

```csharp
public ref Person GetContactInformation(string fname, string lname);
```

In addition, the name of the object returned by each [return](../../language-reference/keywords/return.md) statement in the method body must be preceded by the [ref](../../language-reference/keywords/ref.md) keyword. For example, the following `return` statement returns a reference to a `Person` object named `p`:

```csharp
return ref p;
```

## Consuming a ref return value

The ref return value is an alias to another variable in the called method's scope. You can interpret any use of the ref return as using the variable it aliases:

- When you assign its value, you are assigning a value to the variable it aliases.
- When you read its value, you are reading the value of the variable it aliases.
- If you return it *by reference* you are returning an alias to that same variable.
- If you pass it to another method *by reference* you are passing a reference to the variable it aliases.
- When you make a [ref local](#ref-local) alias, you make a new alias to the same variable.


## Ref locals

Assume the `GetContactInformation` method is declared as a ref return:

```csharp
public ref Person GetContactInformation(string fname, string lname)
```

A by-value assignment reads the value of a variable and assigns it to a new variable:

```csharp
Person p = contacts.GetContactInformation("Brandie", "Best");
```

The preceding assignment declares `p` as a local variable. Its initial value is copied from reading the value returned by `GetContactInformation`. Any future assignments to `p` will not change the value of the variable returned by `GetContactInformation`. The variable `p` is no longer an alias to the variable returned.

You declare a *ref local* variable to copy the alias to the original value. In the following assignment, `p` is an alias to the variable returned from `GetContactInformation`.

```csharp
ref Person p = ref contacts.GetContactInformation("Brandie", "Best");
```

Subsequent usage of `p` is the same as using the variable returned by `GetContactInformation` because `p` is an alias for that variable. Changes to `p` also change the variable returned from `GetContactInformation`.

Note that the `ref` keyword is used both before the local variable declaration *and* before the method call. Failure to include both `ref` keywords in the variable declaration and assignment results in compiler error CS8172, "Cannot initialize a by-reference variable with a value." 
 
## Ref returns and ref locals: an example

The following example defines a `NumberStore` class that stores an array of integer values. The `FindNumber` method returns by reference the first number that is greater than or equal to the number passed as an argument. If no number is greater than or equal to the argument, the method returns the number in index 0. 

[!code-csharp[ref-returns](../../../../samples/snippets/csharp/programming-guide/ref-returns/ref-returns1.cs#1)]

The following example calls the `NumberStore.FindNumber` method to retrieve the first value that is greater than or equal to 16. The caller then doubles the value returned by the method. As the output from the example shows, this change is reflected in the value of the array elements of the `NumberStore` instance.

[!code-csharp[ref-returns](../../../../samples/snippets/csharp/programming-guide/ref-returns/ref-returns1.cs#2)]

Without support for reference return values, such an operation is usually performed by returning the index of the array element along with its value. The caller can then use this index to modify the value in a separate method call. However, the caller can also modify the index to access and possibly modify other array values.  
 
## See also

[ref keyword](../../language-reference/keywords/ref.md)
