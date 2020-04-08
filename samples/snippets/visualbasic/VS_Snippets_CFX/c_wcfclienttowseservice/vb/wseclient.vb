﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4131.6"), _
 System.SerializableAttribute(), _
 System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.ComponentModel.DesignerCategoryAttribute("code"), _
 System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://stockservice.contoso.com/wse/samples/2003/06")> _
Partial Public Class StockQuote

    Private symbolField As String

    Private lastField As Double

    Private dateField As Date

    Private changeField As Double

    Private openField As Double

    Private highField As Double

    Private lowField As Double

    Private volumeField As Long

    Private marketCapField As Long

    Private previousCloseField As Double

    Private previousChangeField As Double

    Private low52WeekField As Double

    Private high52WeekField As Double

    Private nameField As String

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=0)> _
    Public Property Symbol() As String
        Get
            Return Me.symbolField
        End Get
        Set(ByVal value As String)
            Me.symbolField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=1)> _
    Public Property Last() As Double
        Get
            Return Me.lastField
        End Get
        Set(ByVal value As Double)
            Me.lastField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=2)> _
    Public Property [Date]() As Date
        Get
            Return Me.dateField
        End Get
        Set(ByVal value As Date)
            Me.dateField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=3)> _
    Public Property Change() As Double
        Get
            Return Me.changeField
        End Get
        Set(ByVal value As Double)
            Me.changeField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=4)> _
    Public Property Open() As Double
        Get
            Return Me.openField
        End Get
        Set(ByVal value As Double)
            Me.openField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=5)> _
    Public Property High() As Double
        Get
            Return Me.highField
        End Get
        Set(ByVal value As Double)
            Me.highField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=6)> _
    Public Property Low() As Double
        Get
            Return Me.lowField
        End Get
        Set(ByVal value As Double)
            Me.lowField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=7)> _
    Public Property Volume() As Long
        Get
            Return Me.volumeField
        End Get
        Set(ByVal value As Long)
            Me.volumeField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=8)> _
    Public Property MarketCap() As Long
        Get
            Return Me.marketCapField
        End Get
        Set(ByVal value As Long)
            Me.marketCapField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=9)> _
    Public Property PreviousClose() As Double
        Get
            Return Me.previousCloseField
        End Get
        Set(ByVal value As Double)
            Me.previousCloseField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=10)> _
    Public Property PreviousChange() As Double
        Get
            Return Me.previousChangeField
        End Get
        Set(ByVal value As Double)
            Me.previousChangeField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=11)> _
    Public Property Low52Week() As Double
        Get
            Return Me.low52WeekField
        End Get
        Set(ByVal value As Double)
            Me.low52WeekField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=12)> _
    Public Property High52Week() As Double
        Get
            Return Me.high52WeekField
        End Get
        Set(ByVal value As Double)
            Me.high52WeekField = Value
        End Set
    End Property

    '''<remarks/>
    <System.Xml.Serialization.XmlElementAttribute(Order:=13)> _
    Public Property Name() As String
        Get
            Return Me.nameField
        End Get
        Set(ByVal value As String)
            Me.nameField = Value
        End Set
    End Property
End Class



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
 System.ServiceModel.ServiceContractAttribute([Namespace]:="http://stockservice.contoso.com/wse/samples/2005/10", ConfigurationName:="WSSecurityAnonymousServiceSoap")> _
Public Interface WSSecurityAnonymousServiceSoap

    'CODEGEN: Generating message contract since the wrapper name (StockQuotes) of message StockQuoteRequestResponse does not match the default value (StockQuoteRequest)
    <System.ServiceModel.OperationContractAttribute(Action:="http://stockservice.contoso.com/wse/samples/2005/10/StockQuoteRequest", ReplyAction:="*"), _
     System.ServiceModel.XmlSerializerFormatAttribute()> _
    Function StockQuoteRequest(ByVal request As StockQuoteRequestRequest) As StockQuoteRequestResponse
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface WSSecurityAnonymousServiceSoapChannel
    Inherits WSSecurityAnonymousServiceSoap, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class WSSecurityAnonymousServiceSoapClient
    Inherits System.ServiceModel.ClientBase(Of WSSecurityAnonymousServiceSoap)
    Implements WSSecurityAnonymousServiceSoap

    Public Sub New()
        MyBase.New()
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

    Function WSSecurityAnonymousServiceSoap_StockQuoteRequest(ByVal request As StockQuoteRequestRequest) As StockQuoteRequestResponse Implements WSSecurityAnonymousServiceSoap.StockQuoteRequest
        Return MyBase.Channel.StockQuoteRequest(request)
    End Function

    Public Function StockQuoteRequest(ByVal symbols() As String) As StockQuote()
        Dim inValue As StockQuoteRequestRequest = New StockQuoteRequestRequest
        inValue.symbols = symbols
        Dim retVal As StockQuoteRequestResponse = CType(Me, WSSecurityAnonymousServiceSoap).StockQuoteRequest(inValue)
        Return retVal.StockQuote
    End Function
End Class


<System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
 System.ServiceModel.MessageContractAttribute(WrapperName:="StockQuoteRequest", WrapperNamespace:="http://stockservice.contoso.com/wse/samples/2005/10", IsWrapped:=True)> _
Partial Public Class StockQuoteRequestRequest

    <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://stockservice.contoso.com/wse/samples/2005/10", Order:=0), _
     System.Xml.Serialization.XmlArrayAttribute(IsNullable:=True), _
     System.Xml.Serialization.XmlArrayItemAttribute("Symbol", IsNullable:=False)> _
    Public symbols() As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal symbols() As String)
        MyBase.New()
        Me.symbols = symbols
    End Sub
End Class

<System.Diagnostics.DebuggerStepThroughAttribute(), _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
 System.ServiceModel.MessageContractAttribute(WrapperName:="StockQuotes", WrapperNamespace:="http://stockservice.contoso.com/wse/samples/2005/10", IsWrapped:=True)> _
Partial Public Class StockQuoteRequestResponse

    <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://stockservice.contoso.com/wse/samples/2005/10", Order:=0), _
     System.Xml.Serialization.XmlElementAttribute("StockQuote")> _
    Public StockQuote() As StockQuote

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal StockQuote() As StockQuote)
        MyBase.New()
        Me.StockQuote = StockQuote
    End Sub
End Class


