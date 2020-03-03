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
System.ServiceModel.ServiceContractAttribute(Namespace:="Microsoft.WCF.Documentation", _
                                             ConfigurationName:="IMessagingHello")> _
Public Interface IMessagingHello

    <System.ServiceModel.OperationContractAttribute(Action:="http://GreetingMessage/Action", _
                                                    ReplyAction:="http://HelloResponseMessage/Action")> _
    Function Hello(ByVal request As HelloGreetingMessage) As HelloResponseMessage
End Interface

<DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
System.ServiceModel.MessageContractAttribute(WrapperName:="HelloGreetingMessage", _
                                             WrapperNamespace:="Microsoft.WCF.Documentation", IsWrapped:=True)> _
Partial Public Class HelloGreetingMessage

    <System.ServiceModel.MessageBodyMemberAttribute(Namespace:="http://www.examples.com", Order:=0)> _
    Public Salutations As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal Salutations As String)
        Me.Salutations = Salutations
    End Sub
End Class

<DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
System.ServiceModel.MessageContractAttribute(WrapperName:="HelloResponseMessage", _
                                             WrapperNamespace:="Microsoft.WCF.Documentation", IsWrapped:=True)> _
Partial Public Class HelloResponseMessage

    <System.ServiceModel.MessageHeaderAttribute(Namespace:="http://www.examples.com")> _
    Public OutOfBandData As String

    <System.ServiceModel.MessageBodyMemberAttribute(Namespace:="http://www.examples.com", Order:=0)> _
    Public ResponseToGreeting As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal OutOfBandData As String, ByVal ResponseToGreeting As String)
        Me.OutOfBandData = OutOfBandData
        Me.ResponseToGreeting = ResponseToGreeting
    End Sub
End Class

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface IMessagingHelloChannel
	Inherits IMessagingHello, System.ServiceModel.IClientChannel
End Interface

<DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class MessagingHelloClient
	Inherits System.ServiceModel.ClientBase(Of IMessagingHello)
	Implements IMessagingHello

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

	Public Function Hello(ByVal request As HelloGreetingMessage) As HelloResponseMessage Implements IMessagingHello.Hello
		Return MyBase.Channel.Hello(request)
	End Function
End Class
