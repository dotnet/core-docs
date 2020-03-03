﻿Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb

Module Module1

    Sub Main()
    End Sub
    ' <Snippet1>
    Public Function CreateCmdsAndUpdate(ByVal connectionString As String, _
        ByVal queryString As String, _
        ByVal tableName As String) As DataSet

        Using connection As New OleDbConnection(connectionString)
            Dim adapter As New OleDbDataAdapter()
            adapter.SelectCommand = New OleDbCommand(queryString, connection)
            Dim builder As New OleDbCommandBuilder(adapter)

            connection.Open()

            Dim customers As New DataSet()
            adapter.Fill(customers)

            ' Code to modify data in DataSet here 

            adapter.Update(customers, tableName)

            Return customers
        End Using
    End Function
    ' </Snippet1>
End Module
