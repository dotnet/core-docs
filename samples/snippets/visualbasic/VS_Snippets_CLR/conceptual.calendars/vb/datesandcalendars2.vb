﻿' Visual Basic .NET Document
Option Strict On

' <Snippet3>
Imports System.Globalization
Imports System.Threading

Module Example
   Public Sub Main()
      ' Make Arabic (Egypt) the current culture 
      ' and Umm al-Qura calendar the current calendar. 
      Dim arEG As CultureInfo = CultureInfo.CreateSpecificCulture("ar-EG")
      Dim cal As Calendar = New UmAlQuraCalendar()
      arEG.DateTimeFormat.Calendar = cal
      Thread.CurrentThread.CurrentCulture = arEG

      ' Display information on current culture and calendar.
      DisplayCurrentInfo()      

      ' Instantiate a date object.
      Dim date1 As Date = #07/15/2011#

      ' Display the string representation of the date.
      Console.WriteLine("Date: {0:d}", date1)
      Console.WriteLine("Date in the Invariant Culture: {0}", 
                        date1.ToString("d", CultureInfo.InvariantCulture))
      Console.WriteLine()
            
      ' Compare DateTime properties and Calendar methods.
      Console.WriteLine("DateTime.Month property: {0}", date1.Month)
      Console.WriteLine("UmAlQura.GetMonth: {0}", 
                        cal.GetMonth(date1))
      Console.WriteLine()

      Console.WriteLine("DateTime.Day property: {0}", date1.Day)
      Console.WriteLine("UmAlQura.GetDayOfMonth: {0}", 
                        cal.GetDayOfMonth(date1))                         
      Console.WriteLine()
      
      Console.WriteLine("DateTime.Year property: {0:D4}", date1.Year)
      Console.WriteLine("UmAlQura.GetYear: {0}", 
                        cal.GetYear(date1))                         
      Console.WriteLine()
   End Sub
   
   Private Sub DisplayCurrentInfo()
      Console.WriteLine("Current Culture: {0}", 
                        CultureInfo.CurrentCulture.Name)
      Console.WriteLine("Current Calendar: {0}", 
                        DateTimeFormatInfo.CurrentInfo.Calendar)
   End Sub
End Module
' The example displays the following output:
'    Current Culture: ar-EG
'    Current Calendar: System.Globalization.UmAlQuraCalendar
'    Date: 14/08/32
'    Date in the Invariant Culture: 07/15/2011
'    
'    DateTime.Month property: 7
'    UmAlQura.GetMonth: 8
'    
'    DateTime.Day property: 15
'    UmAlQura.GetDayOfMonth: 14
'    
'    DateTime.Year property: 2011
'    UmAlQura.GetYear: 1432
' </Snippet3>

