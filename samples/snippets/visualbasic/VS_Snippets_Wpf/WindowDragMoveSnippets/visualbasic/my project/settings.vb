﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------


Namespace My
	Partial Public Class Settings
		Inherits System.Configuration.ApplicationSettingsBase
		Private Shared m_Value As Settings

		Private Shared m_SyncObject As New Object()

		Public Shared ReadOnly Property Value() As Settings
			Get
				If (Settings.m_Value Is Nothing) Then
					System.Threading.Monitor.Enter(Settings.m_SyncObject)
					If (Settings.m_Value Is Nothing) Then
						Try
							Settings.m_Value = New Settings()
						Finally
							System.Threading.Monitor.Exit(Settings.m_SyncObject)
						End Try
					End If
				End If
				Return Settings.m_Value
			End Get
		End Property
	End Class
End Namespace
