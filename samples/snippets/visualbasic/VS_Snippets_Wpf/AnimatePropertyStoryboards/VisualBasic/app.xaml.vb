﻿Imports System.Configuration
Imports System.Data
Imports System.Windows
Imports System.Windows.Navigation
Imports System.Xml

Namespace SDKSample

    Partial Public Class app
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)

            Dim myWindow As New NavigationWindow()
            Dim myContent As New StoryboardExample()
            myWindow.Content = myContent
            MainWindow = myWindow
            myWindow.Show()
        End Sub


    End Class
End Namespace
