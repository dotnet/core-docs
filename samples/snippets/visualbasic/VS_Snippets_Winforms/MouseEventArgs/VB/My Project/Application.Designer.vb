﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50129.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace My
    
    'NOTE: This file is auto-generated, do not modify it directly.  To make changes,
    ' or if you encounter build errors in this file, go to the Project Designer
    ' (go to project properties or double-click on the My Project node in the 
    ' Solution Explorer), and make changes on the Application tab.
    '
    Partial Class MyApplication
        
        <Global.System.Diagnostics.DebuggerStepThrough()>  _
        Public Sub New()
            MyBase.New(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
            Me.IsSingleInstance = false
            Me.EnableVisualStyles = true
            Me.SaveMySettingsOnExit = true
            Me.ShutDownStyle = Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses
        End Sub
        
        <Global.System.Diagnostics.DebuggerStepThrough()>  _
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.MouseEventArgsVB.Form1
        End Sub
    End Class
End Namespace
