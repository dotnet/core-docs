﻿Imports System.Data
Imports System.ComponentModel
Imports System.Windows.Forms



Public Class Form1
    Inherits Form
    Protected textBox1 As TextBox
    
    ' <Snippet1>
    Private Sub AddMyData2()
        ' Creates a component to store in the data object.
        Dim myComponent As New Component()
        
        ' Gets the type of the component.
        Dim myType As Type = myComponent.GetType()
        
        ' Creates a new data object.
        Dim myDataObject As New DataObject()
        
        ' Adds the component to the DataObject.
        myDataObject.SetData(myType, myComponent)
        
        ' Prints whether data of the specified type is in the DataObject.
        If myDataObject.GetDataPresent(myType) Then
            textBox1.Text = "Data of type " & myType.GetType().Name & _
                " is present in the DataObject"
        Else
            textBox1.Text = "Data of type " & myType.GetType().Name & _
                " is not present in the DataObject"
        End If
    End Sub
    ' </Snippet1>
End Class

