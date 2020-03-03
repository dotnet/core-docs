<!-- <Snippet1> -->
<%@ Register TagPrefix="aspSample" Namespace="Samples.AspNet.VB" Assembly="Samples.AspNet.VB" %>
<%@ Import namespace="Samples.AspNet.VB" %>
<%@ Page language="vb" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
' Called before a Delete operation.
    Private Sub NorthwindEmployeeDeleting(ByVal source As Object, ByVal e As ObjectDataSourceMethodEventArgs)

        ' The GridView passes the ID of the employee
        ' to be deleted. However, the business object, EmployeeLogic,
        ' requires a NorthwindEmployee parameter, named "ne". Create
        ' it now and add it to the parameters collection.
        Dim paramsFromPage As IDictionary = e.InputParameters
  
        If Not paramsFromPage("EmpID") Is Nothing Then
    
            Dim ne As New NorthwindEmployee(paramsFromPage("EmpID").ToString())
            ' Remove the old EmpID parameter.
            paramsFromPage.Clear()
            paramsFromPage.Add("ne", ne)
    
    
        End If
    End Sub ' NorthwindEmployeeDeleting

    ' Called after a Delete operation.
    Private Sub NorthwindEmployeeDeleted(ByVal source As Object, ByVal e As ObjectDataSourceStatusEventArgs)
        ' Handle the Exception if it is a NorthwindDataException.
        If Not e.Exception Is Nothing Then

            ' Handle the specific exception type. The ObjectDataSource wraps
            ' any Exceptions in a TargetInvokationException wrapper, so
            ' check the InnerException property for the expected Exception types.
            If e.Exception.InnerException.GetType().Equals(GetType(NorthwindDataException)) Then

                Label1.Text = e.Exception.InnerException.Message
                ' Because the exception is handled, there is
                ' no reason to throw it.
                e.ExceptionHandled = True
      
            End If
        End If
    End Sub ' NorthwindEmployeeDeleted
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head>
    <title>ObjectDataSource - VB Example</title>
  </head>
  <body>
    <form id="Form1" method="post" runat="server">

        <asp:gridview
          id="GridView1"
          runat="server"
          datasourceid="ObjectDataSource1"
          autogeneratedeletebutton="true"
          autogeneratecolumns="false"
          datakeynames="EmpID">
          <columns>
            <asp:boundfield headertext="EmpID" datafield="EmpID" />
            <asp:boundfield headertext="First Name" datafield="FirstName" />
            <asp:boundfield headertext="Last Name" datafield="LastName" />
          </columns>
        </asp:gridview>

        <asp:objectdatasource
          id="ObjectDataSource1"
          runat="server"
          selectmethod="GetAllEmployees"
          deletemethod="DeleteEmployee"
          ondeleting="NorthwindEmployeeDeleting"
          ondeleted="NorthwindEmployeeDeleted"
          typename="Samples.AspNet.VB.EmployeeLogic">
          <deleteparameters>
            <asp:parameter name="EmpID" type="Int32" />
          </deleteparameters>
        </asp:objectdatasource>

        <asp:label id="Label1" runat="server" />

    </form>
  </body>
</html>
<!-- </Snippet1> -->