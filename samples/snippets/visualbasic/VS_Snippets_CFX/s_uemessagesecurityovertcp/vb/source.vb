﻿
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Permissions
Imports System.ServiceModel.Description

<Assembly: SecurityPermission(SecurityAction.RequestMinimum, Execution := True)>
Namespace Windows.Communication.Foundation.Samples

	Public Class Test
		Private Sub New()
		End Sub
		Shared Sub Main()
			Console.WriteLine("Hello")
			Console.ReadLine()
		End Sub


		Private Class Snippets
			Private Function ReturnUserName() As String
				Return "SHH"
			End Function
			Private Function ReturnPassword() As String
				Return "SHH"
			End Function

			Private Sub snippet1()
				'<snippet1>
				Dim binding As New BasicHttpBinding()
				' Specify HTTPS as the security mechanism.
				binding.Security.Mode = BasicHttpSecurityMode.Transport
				'</snippet1>
			End Sub
			Private Sub Snippet2()
				'<snippet2>
				Dim binding As New NetTcpBinding()
				' Specify the mode, then the credential type.
				binding.Security.Mode = SecurityMode.Message
				binding.Security.Message.ClientCredentialType = MessageCredentialType.UserName
				binding.Security.Message.AlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Basic256
				'</snippet2>
			End Sub
			Private Sub snippet3()
				'<snippet3>
				Dim binding As New NetTcpBinding()
				binding.Security.Mode = SecurityMode.Transport
				binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Certificate
				'</snippet3>
			End Sub

			Private Sub Snippet4()
				'<snippet4>
				' Specify client credentials on the client. 
				' Code to set the UserName and Password is not shown here.
				Dim CalculatorClient As New CalculatorClient("myBinding")
				CalculatorClient.ClientCredentials.UserName.UserName = ReturnUserName()
				CalculatorClient.ClientCredentials.UserName.Password = ReturnPassword()
				'</snippet4>
			End Sub

			Private Sub Snippet5()
				'<snippet5>
				Dim myServiceHost As New ServiceHost(GetType(CalculatorService))
				' Create a binding to use.
				Dim binding As New WSHttpBinding()
				binding.Security.Mode = SecurityMode.Message
				binding.Security.Message.ClientCredentialType = MessageCredentialType.Certificate

				' Set the client certificate.
				myServiceHost.Credentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySubjectName, "client.com")
				'</snippet5>
			End Sub

			Private Sub Snippet6And7()
				'<snippet6>
				Dim myServiceHost As New ServiceHost(GetType(CalculatorService))

				' Specify client credentials validation on the service. 
				Dim myServiceCredentials As ServiceCredentials = myServiceHost.Description.Behaviors.Find(Of ServiceCredentials)()

				' The CurrentUser property of the StoreLocation class is a static method.
				myServiceCredentials.ClientCertificate.Authentication.TrustedStoreLocation = StoreLocation.CurrentUser
				'</snippet6>

				'<snippet7>
				Dim binding As New WSHttpBinding()
				binding.Security.Mode = SecurityMode.Message
				binding.Security.Message.ClientCredentialType = MessageCredentialType.UserName
				binding.Security.Message.NegotiateServiceCredential = False

				Dim CalculatorClient As New CalculatorClient("myBinding")
				CalculatorClient.ClientCredentials.ServiceCertificate. SetDefaultCertificate("Al", StoreLocation.CurrentUser, StoreName.My)
				'</snippet7>
			End Sub

			Private Sub Snippet8()
				'<snippet8>
				Dim binding As New WSHttpBinding()
				binding.Security.Mode = SecurityMode.Message
				binding.Security.Message.AlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Basic256
				binding.Security.Message.EstablishSecurityContext = True
				'</snippet8>
			End Sub

			'<snippet9>
			<OperationContract(ProtectionLevel := System.Net.Security.ProtectionLevel.EncryptAndSign)> _
			Private Sub MyCalculatorMethod()
				' Code not shown.
			End Sub
			'</snippet9>

			Private Sub TransportSecurityOverview()
				'<snippet10>
				Dim b As New WSHttpBinding()
				b.Security.Mode = SecurityMode.Transport
				b.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows
				'</snippet10>
			End Sub

			Private Sub TransportSecurityOverview2()
				'<snippet11>
				' The code uses a shortcut to specify the security mode to Transport.
				Dim b As New WSHttpBinding(SecurityMode.Transport)
				b.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows
				'</snippet11>
			End Sub

			Private Sub TransportSecurityOverview3()
				'<snippet12>
				Dim b As New NetTcpBinding()
				b.Security.Mode = SecurityMode.Transport
				b.Security.Transport.ClientCredentialType = TcpClientCredentialType.Certificate
				'</snippet12>
			End Sub

			Private Sub ClientSideCode()
				'<snippet13>
				Dim b As New NetTcpBinding()
				b.Security.Mode = SecurityMode.Transport
				b.Security.Transport.ClientCredentialType = TcpClientCredentialType.Certificate
				Dim a As New EndpointAddress("net.tcp://contoso.com/TcpAddress")
				Dim cf As New ChannelFactory(Of ICalculator)(b, a)
                cf.Credentials.ClientCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.My, X509FindType.FindByThumbprint, "0000000000000000000000000000000000000000")
				'</snippet13>
			End Sub

			Private Sub Snippet14()
				'<snippet15>
				'<snippet14>
				Dim myServiceHost As New ServiceHost(GetType(CalculatorService))
				' Create a binding to use.
				Dim binding As New WSHttpBinding()
				binding.Security.Mode = SecurityMode.Message
				binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows
				'</snippet14>

				' Set the service certificate.
				myServiceHost.Credentials.ServiceCertificate.SetCertificate("cn=service.com")
				'</snippet15>
			End Sub

		End Class
	End Class

	<System.ServiceModel.ServiceContractAttribute(Namespace := "http://Microsoft.ServiceModel.Samples")> _
	Public Interface ICalculator

		<System.ServiceModel.OperationContractAttribute(Action := "http://Microsoft.ServiceModel.Samples/ICalculator/Add", ReplyAction := "http://Microsoft.ServiceModel.Samples/ICalculator/AddResponse")> _
		Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double

		<System.ServiceModel.OperationContractAttribute(Action := "http://Microsoft.ServiceModel.Samples/ICalculator/Subtract", ReplyAction := "http://Microsoft.ServiceModel.Samples/ICalculator/SubtractResponse")> _
		Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double

		<System.ServiceModel.OperationContractAttribute(Action := "http://Microsoft.ServiceModel.Samples/ICalculator/Multiply", ReplyAction := "http://Microsoft.ServiceModel.Samples/ICalculator/MultiplyResponse")> _
		Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double

		<System.ServiceModel.OperationContractAttribute(Action := "http://Microsoft.ServiceModel.Samples/ICalculator/Divide", ReplyAction := "http://Microsoft.ServiceModel.Samples/ICalculator/DivideResponse")> _
		Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double
	End Interface

	Public Interface ICalculatorChannel
	Inherits ICalculator, System.ServiceModel.IClientChannel
	End Interface

	Partial Public Class CalculatorClient
		Inherits System.ServiceModel.ClientBase(Of ICalculator)
		Implements ICalculator

		Public Sub New()
		End Sub

		Public Sub New(ByVal configurationName As String)
			MyBase.New(configurationName)
		End Sub

		Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal address As System.ServiceModel.EndpointAddress)
			MyBase.New(binding, address)
		End Sub

		Public Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculator.Add
			Return MyBase.Channel.Add(n1, n2)
		End Function

		Public Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculator.Subtract
			Return MyBase.Channel.Subtract(n1, n2)
		End Function

		Public Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculator.Multiply
			Return MyBase.Channel.Multiply(n1, n2)
		End Function

		Public Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculator.Divide
			Return MyBase.Channel.Divide(n1, n2)
		End Function
	End Class

	Public Class CalculatorService
	End Class
End Namespace
