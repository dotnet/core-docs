﻿
Imports System.Configuration
Imports System.Data
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.Windows.Navigation
Imports System.Xml

Namespace ImageElementExample

    ' <summary>
    ' Interaction logic for app.xaml
    ' </summary>

    Partial Class app
        Inherits Application
        Private Sub AppStartingUp(ByVal sender As Object, ByVal e As StartupEventArgs)
            Dim mainWindow As New SampleViewer()
            mainWindow.Show()

        End Sub
    End Class
End Namespace 'ImageElementExample
