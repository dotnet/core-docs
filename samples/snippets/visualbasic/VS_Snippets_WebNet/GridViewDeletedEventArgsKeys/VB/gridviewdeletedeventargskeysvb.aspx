<!-- <Snippet1> -->

<%@ Page language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

  Sub CustomersGridView_RowDeleted(ByVal sender As Object, ByVal e As GridViewDeletedEventArgs)
  
    Dim entry As DictionaryEntry
    
    ' Display the value of the key fields in the Keys property.
    KeysMessageLabel.Text = _
      "The key fields for the deleted record are: <br/>"

    ' In VB, you cannot iterate through the DictionaryEntry objects
    ' in the Keys property directly. Use the CopyTo method to 
    ' copy the objects to an array first.
    Dim keysArray(e.Keys.Count - 1) As DictionaryEntry
    e.Keys.CopyTo(keysArray, 0)
    
    ' Iterate through the array and display its values.
    For Each entry In keysArray
    
      DisplayValue(entry, KeysMessageLabel)
    
    Next

    ' Display the value of the non-key fields in the Values 
    ' property.
    ValuesMessageLabel.Text = _
      "The non-key fields for the deleted record are: <br/>"

    Dim valuesArray(e.Values.Count - 1) As DictionaryEntry
    e.Values.CopyTo(valuesArray, 0)

    For Each entry In valuesArray
    
      DisplayValue(entry, ValuesMessageLabel)
    
    Next

  End Sub

  Sub DisplayValue(ByVal entry As DictionaryEntry, ByVal displayLabel As Label)
  
    ' Display the field name contained in the DictionaryEntry object.
    If entry.Key IsNot Nothing Then
    
      displayLabel.Text &= "Name=" & entry.Key.ToString() & ", "
    
    Else
    
      displayLabel.Text &= "Name=null, "
      
    End If

    ' Display the field value contained in the DictionaryEntry object.
    If entry.Value IsNot Nothing Then
    
      displayLabel.Text &= "Value=" & entry.Value.ToString() & "<br/>"
    
    Else
    
      displayLabel.Text &= "Value=null<br/>"
      
    End If
        
  End Sub
    
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>GridViewDeletedEventArgs Keys and Values Example</title>
</head>
<body>
    <form id="form1" runat="server">
        
      <h3>GridViewDeletedEventArgs Keys and Values Example</h3>
            
      <asp:label id="Message"
        forecolor="Red"          
        runat="server"/>
                
      <br/>
            
      <!-- The GridView control automatically sets the columns     -->
      <!-- specified in the datakeynames property as read-only.    -->
      <!-- No input controls are rendered for these columns in     -->
      <!-- edit mode.                                              -->
      <asp:gridview id="CustomersGridView" 
        datasourceid="CustomersSqlDataSource" 
        autogeneratecolumns="true"
        autogeneratedeletebutton="true"
        allowpaging="true" 
        datakeynames="CustomerID"
        onrowdeleted="CustomersGridView_RowDeleted"  
        runat="server">
      </asp:gridview>
      
      <br/>
      
      <asp:label id="KeysMessageLabel"
        forecolor="Red"
        runat="server"/>
          
      <br/><br/>
          
      <asp:label id="ValuesMessageLabel"
        forecolor="Red"
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