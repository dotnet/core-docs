﻿
Imports System.Windows
Imports System.Data
Imports System.Xml
Imports System.Configuration


'/ <summary>
'/ Interaction logic for MyApp.xaml
'/ </summary>

Namespace MyInkEraser
    Class MyApp
        Inherits Application

        Private Sub AppStartingUp(ByVal sender As Object, ByVal e As StartupEventArgs)
            Dim mainWindow As New Window1()
            mainWindow.Show()

        End Sub
    End Class
End Namespace
'
'ToDo: Error processing original source shown below
'    }
'}
'-^--- expression expected