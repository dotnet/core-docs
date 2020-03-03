<!-- <Snippet1> -->

<%@ Page language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

  Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            
    ' Create a new GridView control.
    Dim customersGridView As New GridView()
         
    ' Set the GridView control's properties.          
    customersGridView.ID = "CustomersGridView"
    customersGridView.DataSourceID = "CustomersSqlDataSource"
    customersGridView.AutoGenerateColumns = True
    customersGridView.AutoGenerateDeleteButton = True
    Dim keyArray() As String = {"CustomerID"}
    customersGridView.DataKeyNames = keyArray
       
    ' Programmatically register the event-handling methods.
    AddHandler customersGridView.RowDeleting, AddressOf CustomersGridView_RowDeleting
        
    ' Add the GridView object to the Controls collection
    ' of the PlaceHolder control.
    GridViewPlaceHolder.Controls.Add(customersGridView)
        
  End Sub
    
  Sub CustomersGridView_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs)

    ' User the sender parameter to retrieve the GridView control
    ' that raised the event.
    Dim customersGridView As GridView = CType(sender, GridView)
    
    ' Cancel the delete operation if the user attempts to remove
    ' the last record from the GridView control.
    If customersGridView.Rows.Count <= 1 Then

      e.Cancel = True
      Message.Text = "You must keep at least one record."
            
    End If
    
  End Sub

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>GridViewDeleteEventHandler Example</title>
</head>
<body>
    <form id="form1" runat="server">
        
      <h3>GridViewDeleteEventHandler Example</h3>
            
      <asp:label id="Message"
        forecolor="Red"          
        runat="server"/>
                
      <br/>
      
      <asp:placeholder id="GridViewPlaceHolder"
        runat="server"/>
            
      <!-- This example uses Microsoft SQL Server and connects  -->
      <!-- to the Northwind sample database. Use an ASP.NET     -->
      <!-- expression to retrieve the connection string value   -->
      <!-- from the Web.config file.                            -->
      <asp:sqldatasource id="CustomersSqlDataSource"  
        selectcommand="Select [CustomerID], [CompanyName], [Address], [City], [PostalCode], [Country] From [Customers]"
        deletecommand="Delete from Customers where CustomerID = @CustomerID"
        connectionstring="<%$ ConnectionStrings:NorthWindConnectionString%>"
        runat="server">
      </asp:sqldatasource>
      
    </form>
  </body>
</html>

<!-- </Snippet1> -->