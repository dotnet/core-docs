﻿' TODO: Skipped Null-able Directive enable 
Imports System.Text.Json
Imports System.Text.Json.Serialization

Namespace JsonIgnoreAttributeExample

    Public Class Forecast

        <JsonIgnore(Condition:=JsonIgnoreCondition.WhenWritingDefault)>
        Public Property [Date] As Date

        <JsonIgnore(Condition:=JsonIgnoreCondition.Never)>
        Public Property TemperatureC As Integer

        <JsonIgnore(Condition:=JsonIgnoreCondition.WhenWritingNull)>
        Public Property Summary As String

    End Class

    Public NotInheritable Class Program

        Public Shared Sub Main()
            Dim forecast1 As New Forecast

            Dim options As New JsonSerializerOptions

            Dim forecastJson As String = JsonSerializer.Serialize(forecast1, options)

            Console.WriteLine(forecastJson)
        End Sub

    End Class

End Namespace

' Produces output like the following example:
'
'{"TemperatureC":0}
