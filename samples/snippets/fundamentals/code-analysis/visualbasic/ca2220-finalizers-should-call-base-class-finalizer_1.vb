Imports System

Namespace UsageLibrary

  Public Class TypeB
      Inherits TypeA
   
      Protected Overrides Sub Finalize()
          Try
              Dispose(False)
          Finally
              MyBase.Finalize()
          End Try
      End Sub
   
  End Class
  
End Namespace