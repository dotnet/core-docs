﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------





<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
System.ServiceModel.ServiceContractAttribute(Namespace:="http://Microsoft.WCF.Documentation", _
                                             ConfigurationName:="HelloWorld")> _
Public Interface HelloWorld

    <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.WCF.Documentation/HelloWorld/SampleMethod", _
     ReplyAction:="http://Microsoft.WCF.Documentation/HelloWorld/SampleMethodResponse")> _
    Function SampleMethod(ByVal msg As String) As String
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface HelloWorldChannel
	Inherits HelloWorld, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class HelloWorldClient
	Inherits System.ServiceModel.ClientBase(Of HelloWorld)
	Implements HelloWorld

	Public Sub New()
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String)
		MyBase.New(endpointConfigurationName)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(binding, remoteAddress)
	End Sub

	Public Function SampleMethod(ByVal msg As String) As String Implements HelloWorld.SampleMethod
		Return MyBase.Channel.SampleMethod(msg)
	End Function
End Class
