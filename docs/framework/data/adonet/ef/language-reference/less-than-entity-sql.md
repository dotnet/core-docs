---
description: "Learn more about: < (Less Than) (Entity SQL)"
title: "< (Less Than) (Entity SQL)"
ms.date: "03/30/2017"
ms.assetid: 1fc2a039-3ad6-4b3c-b41d-09932e803f86
---
# \< (Less Than) (Entity SQL)

Compares two expressions to determine whether the left expression has a value less than the right expression.  
  
## Syntax  
  
```sql  
expression < expression  
```  
  
## Arguments  

 `expression`  
 Any valid expression. Both expressions must have implicitly convertible data types.  
  
## Result Types  

 `true` if the left expression has a value less than the right expression; otherwise, `false`.  
  
## Example  

 The following Entity SQL query uses < comparison operator to compare two expressions to determine whether the left expression has a value less than the right expression. The query is based on the AdventureWorks Sales Model. To compile and run this query, follow these steps:  
  
1. Follow the procedure in [How to: Execute a Query that Returns StructuralType Results](../how-to-execute-a-query-that-returns-structuraltype-results.md).  
  
2. Pass the following query as an argument to the `ExecuteStructuralTypeQuery` method:  
  
 [!code-sql[DP EntityServices Concepts#LESS](~/samples/snippets/tsql/VS_Snippets_Data/dp entityservices concepts/tsql/entitysql.sql#less)]  
  
## See also

- [Entity SQL Reference](entity-sql-reference.md)
