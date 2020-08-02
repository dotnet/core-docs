﻿Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Media.Animation
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace Microsoft.Samples.BrushExamples
    ''' <summary>
    ''' Interaction logic for SampleViewer.xaml
    ''' </summary>

    Partial Public Class SampleViewer
        Inherits Page
        Public Sub New()
            InitializeComponent()

            SolidColorBrushExampleFrame.Content = New SolidColorBrushExample()

        End Sub

    End Class
End Namespace
