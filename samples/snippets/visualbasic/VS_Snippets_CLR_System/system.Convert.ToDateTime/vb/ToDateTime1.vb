﻿' Visual Basic .NET Document
' Illustrates Convert.ToDateTime(Object) method.
Option Strict On

' <Snippet1>
Module ConversionToDateTime
   Public Sub Main()
      ' Try converting an integer.
      Dim number As Integer = 16352
      ConvertToDateTime(number)
      
      ' Convert a null.
      Dim obj As Object = Nothing
      ConvertToDateTime(obj)
      
      ' Convert a non-date string.
      Dim nonDateString As String = "monthly"
      ConvertToDateTime(nonDateString)
      
      ' Try to convert various dates.
      Dim dateString As String 
      dateString = "05/01/1996"
      ConvertToDateTime(dateString)
      dateString = "Tue Apr 28, 2009"
      ConvertToDateTime(dateString)
      dateString = "06 July 2008 7:32:47 AM"
      ConvertToDateTime(dateString)
      dateString = "17:32:47.003"
      ConvertToDateTime(dateString)
   End Sub
   
   Private Sub ConvertToDateTime(value As Object)
      Dim convertedDate As Date
      Try
         convertedDate = Convert.ToDateTime(value)
         Console.WriteLine("'{0}' converts to {1}.", value, convertedDate)
      Catch e As FormatException
         Console.WriteLine("'{0}' is not in the proper format.", value)
      Catch e As InvalidCastException
         Console.WriteLine("Conversion of the {0} '{1}' is not supported", _
                           value.GetType().Name, value)
      End Try
   End Sub
End Module
' The example displays the following output:
'       Conversion of the Int32 '16352' is not supported
'       '' converts to 1/1/0001 12:00:00 AM.
'       'monthly' is not in the proper format.
'       '05/01/1996' converts to 5/1/1996 12:00:00 AM.
'       'Tue Apr 28, 2009' converts to 4/28/2009 12:00:00 AM.
'       '06 July 2008 7:32:47 AM' converts to 7/6/2008 7:32:47 AM.
'       '17:32:47.003' converts to 5/28/2008 5:32:47 PM.
' </Snippet1>
