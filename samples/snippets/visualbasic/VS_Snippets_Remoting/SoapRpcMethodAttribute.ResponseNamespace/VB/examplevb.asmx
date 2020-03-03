<%@ WebService Language="VB" Class="SoapRpcMethodSample" %>
	
Imports System.Web.Services
Imports System.Web.Services.Protocols

Public Class SoapRpcMethodSample

   <WebMethod(),SoapRpcMethod(ResponseNamespace :="http://www.contoso.com",ResponseElementName := "MyCustomResponseElement")> _
   Public Function  ResponseRpc(numentries as Integer) As Integer()
	Dim intarray(numentries - 1) as Integer
        Dim i as Integer
        For i = 0 To numentries - 1
           intarray(i) = i
        Next
        Return intarray
   End Function
End Class