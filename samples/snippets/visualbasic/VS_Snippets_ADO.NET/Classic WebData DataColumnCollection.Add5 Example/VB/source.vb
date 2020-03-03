﻿imports System.Data
imports System.Windows.Forms


Public Class Form1: Inherits Form

Protected DataSet1 As DataSet

' <Snippet1>
Private Sub AddColumn()
    ' Get the DataColumnCollection from a table in a DataSet.
    Dim columns As DataColumnCollection = _
        DataSet1.Tables("Prices").Columns
    Dim column As DataColumn = columns.Add()

    With column
       .DataType = System.Type.GetType("System.Decimal")
       .ColumnName = "Total"
       .Expression = "UnitPrice * Quantity"
       .ReadOnly = True
       .Unique = False
    End With
End Sub
' </Snippet1>

End Class
