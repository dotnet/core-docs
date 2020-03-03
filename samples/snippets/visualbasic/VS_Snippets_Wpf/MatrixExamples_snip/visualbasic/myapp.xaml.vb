﻿Imports System.Xml
Imports System.Configuration
Imports System.Windows.Media.Animation

Namespace Microsoft.Samples.MatrixExamples


	Partial Public Class MyApp
		Inherits Application

		Public Sub New()

			AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
		End Sub

		Private Sub myAppStartup(ByVal sender As Object, ByVal args As StartupEventArgs)

		  Dim myWindow As New Window()
		  myWindow.Content = New SampleViewer()

		  myWindow.Show()


		End Sub

		Private Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal args As UnhandledExceptionEventArgs)
			MessageBox.Show("Unhandled exception: " & args.ExceptionObject.ToString())
		End Sub

	End Class
End Namespace