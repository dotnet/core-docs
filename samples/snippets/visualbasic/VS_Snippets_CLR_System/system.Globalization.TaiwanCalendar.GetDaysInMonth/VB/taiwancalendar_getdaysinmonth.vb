﻿' The following code example calls GetDaysInMonth for the second month in each of 5 years in each era.

' <snippet1>
Imports System.Globalization

Public Class SamplesTaiwanCalendar   
   
   Public Shared Sub Main()

      ' Creates and initializes a TaiwanCalendar.
      Dim myCal As New TaiwanCalendar()

      ' Displays the header.
      Console.Write("YEAR" + ControlChars.Tab)
      Dim y As Integer
      For y = 90 To 94
         Console.Write(ControlChars.Tab + "{0}", y)
      Next y
      Console.WriteLine()

      ' Displays the value of the CurrentEra property.
      Console.Write("CurrentEra:")
      For y = 90 To 94
         Console.Write(ControlChars.Tab + "{0}", myCal.GetDaysInMonth(y, 2, TaiwanCalendar.CurrentEra))
      Next y
      Console.WriteLine()

      ' Displays the values in the Eras property.
      Dim i As Integer
      For i = 0 To myCal.Eras.Length - 1
         Console.Write("Era {0}:" + ControlChars.Tab, myCal.Eras(i))
         For y = 90 To 94
            Console.Write(ControlChars.Tab + "{0}", myCal.GetDaysInMonth(y, 2, myCal.Eras(i)))
         Next y
         Console.WriteLine()
      Next i

   End Sub

End Class


'This code produces the following output.
'
'YEAR            90      91      92      93      94
'CurrentEra:     28      28      28      29      28
'Era 1:          28      28      28      29      28

' </snippet1>
