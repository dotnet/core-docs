﻿Imports System.Data
Imports System.ComponentModel
Imports System.Windows.Forms



MustInherit Public Class Coll1
    Inherits EventDescriptorCollection
    
    
    Public Sub New()
        MyBase.New(Nothing)
    End Sub
    
    
    
    Protected Sub Method()
        ' <Snippet1>
        Me.InternalSort(New String() {"D", "B"})
        ' </Snippet1>
    End Sub
End Class
