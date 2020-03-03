﻿Imports System.Xml
Imports System.Data
Imports System.Data.Common
Imports System.Windows.Forms

Public Class Form1
    Inherits Form
    Protected DataSet1 As DataSet
    Protected dataGrid1 As DataGrid
    
' <Snippet1>
Private Sub WriteXmlToFile(thisDataSet As DataSet)
     If thisDataSet Is Nothing Then
         Return
     End If 

    ' Create a file name to write to.
     Dim filename As String = "XmlDoc.xml"

     ' Create the FileStream to write with.
     Dim stream As New System.IO.FileStream _
        (filename, System.IO.FileMode.Create)

     ' Write to the file with the WriteXml method.
     thisDataSet.WriteXml(stream)
End Sub
' </Snippet1>
End Class
