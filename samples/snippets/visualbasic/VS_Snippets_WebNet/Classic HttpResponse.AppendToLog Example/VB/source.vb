﻿Imports System.Web
Imports System.Web.UI

Public Class Page1: Inherits Page

  Protected Sub Page_Load(sender As Object, e As EventArgs)
' <Snippet1>
Response.AppendToLog("Page delivered")
    
' </Snippet1>
 End Sub
End Class
