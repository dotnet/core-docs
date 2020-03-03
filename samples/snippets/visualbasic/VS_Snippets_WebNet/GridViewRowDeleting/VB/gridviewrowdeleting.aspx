﻿<!-- <Snippet1> -->

<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    Private Sub CustomersGridView_RowDeleting _
        (ByVal sender As [Object], _
        ByVal e As GridViewDeleteEventArgs)
        Dim cell As TableCell
        cell = CustomersGridView.Rows(e.RowIndex).Cells(2)
        If cell.Text = "Beaver" Then
            e.Cancel = True
            Message.Text = "You cannot delete customer Beaver."
        Else
            Message.Text = ""
        End If
    End Sub
    
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>GridView RowDeleting Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <h3>
        GridView RowDeleting Example
    </h3>
    <asp:Label ID="Message" ForeColor="Red" runat="server" />
    <br />
    <asp:GridView ID="CustomersGridView" runat="server" 
        DataSourceID="CustomersSqlDataSource" 
        AutoGenerateColumns="False"
        AutoGenerateDeleteButton="True" 
        OnRowDeleting="CustomersGridView_RowDeleting"
        DataKeyNames="CustomerID,AddressID">
        <Columns>
            <asp:BoundField DataField="FirstName" 
                HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" 
                SortExpression="LastName" />
            <asp:BoundField DataField="City" HeaderText="City" 
                SortExpression="City" />
            <asp:BoundField DataField="StateProvince" HeaderText="State" 
                SortExpression="StateProvince" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="CustomersSqlDataSource" runat="server"
        SelectCommand="SELECT SalesLT.CustomerAddress.CustomerID, 
            SalesLT.CustomerAddress.AddressID, 
            SalesLT.Customer.FirstName, 
            SalesLT.Customer.LastName, 
            SalesLT.Address.City, 
            SalesLT.Address.StateProvince 
            FROM SalesLT.Customer 
            INNER JOIN SalesLT.CustomerAddress 
            ON SalesLT.Customer.CustomerID = 
                SalesLT.CustomerAddress.CustomerID 
            INNER JOIN SalesLT.Address ON SalesLT.CustomerAddress.AddressID = 
                SalesLT.Address.AddressID"
        DeleteCommand="Delete from SalesLT.CustomerAddress where CustomerID = 
            @CustomerID and AddressID = @AddressID" 
        ConnectionString="<%$ ConnectionStrings:AdventureWorksLTConnectionString %>">
        <DeleteParameters>
            <asp:Parameter Name="AddressID" />
            <asp:Parameter Name="CustomerID" />
        </DeleteParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
<!-- </Snippet1> -->
