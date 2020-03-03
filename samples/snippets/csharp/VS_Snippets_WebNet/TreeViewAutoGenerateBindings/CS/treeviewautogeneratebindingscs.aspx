<!-- <Snippet1> -->

<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>TreeView AutoGenerateBindings Example</title>
</head>
<body>
    <form id="form1" runat="server">
    
      <h3>TreeView AutoGenerateBindings Example</h3>
    
      <!-- Set the AutoGenerateBindings property -->
      <!-- to false declaratively to allow for   -->
      <!-- the user-defined Bindings collection. -->
      <asp:TreeView id="SiteTreeView" 
        DataSourceID="SiteMapSource"
        AutoGenerateDataBindings="False"
        runat="server">
        
        <DataBindings>
        
          <asp:TreeNodeBinding TextField="title" NavigateUrlField="url"/>
        
        </DataBindings>
            
      </asp:TreeView>
      
      <asp:SiteMapDataSource ID="SiteMapSource" runat="server"/>
         
    </form>
  </body>
</html>

<!-- </Snippet1> -->

