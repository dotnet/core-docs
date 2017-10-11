---
title: "% Operator (C# Reference)"
ms.date: "2015-07-20"
ms.prod: .net
ms.technology: ["devlang-csharp"]
ms.topic: "article"
f1_keywords: ["%_CSharpKeyword"]
dev_langs: ["CSharp"]
helpviewer_keywords: ["modulus operator [C#]", "% operator [C#]"]
ms.assetid: 3b74f4f9-fd9c-45e7-84fa-c8d71a0dfad7
caps.latest.revision: 15
author: "BillWagner"
ms.author: "wiwagn"
---
# % Operator (C# Reference)
The `%` operator computes the remainder after dividing its first operand by its second. All numeric types have predefined remainder operators.  
  
## Remarks  
 User-defined types can overload the `%` operator (see [operator](../../../csharp/language-reference/keywords/operator.md)). When a binary operator is overloaded, the corresponding assignment operator, if any, is also implicitly overloaded.  
  
## Example  
 [!code-cs[csRefOperators#9](../../../csharp/language-reference/operators/codesnippet/CSharp/modulus-operator_1.cs)]  
  
## Comments  
 Note the round-off errors associated with the double type.  
  
## See Also  
 [C# Reference](../../../csharp/language-reference/index.md)   
 [C# Programming Guide](../../../csharp/programming-guide/index.md)   
 [C# Operators](../../../csharp/language-reference/operators/index.md)
