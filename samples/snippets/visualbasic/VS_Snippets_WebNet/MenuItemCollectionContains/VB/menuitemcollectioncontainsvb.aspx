<!-- <Snippet1> -->

<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    
  Sub NavigationMenu_MenuItemClick(ByVal sender As Object, ByVal e As MenuEventArgs)
  
    ' Use the Contains method to determine whether the menu
    ' item selected by the user is contained in the Items
    ' collection of the Menu control. 
    If NavigationMenu.Items.Contains(e.Item) Then
    
      Message.Text = "You selected the root menu item."
    
    Else
    
      Message.Text = "You selected a submenu item."
    
    End If
      
  End Sub

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>MenuItemCollection Contains Example</title>
</head>
<body>
    <form id="form1" runat="server">
    
      <h3>MenuItemCollection Contains Example</h3>
    
      Select an item from the menu.
      <br/><br/>
    
      <asp:menu id="NavigationMenu"
        orientation="Vertical"
        target="_blank"
        onmenuitemclick="NavigationMenu_MenuItemClick"  
        runat="server">
        
        <items>
          <asp:menuitem text="Home"
            tooltip="Home">
            <asp:menuitem text="Music"
              tooltip="Music">
              <asp:menuitem text="Classical"
                tooltip="Classical"/>
              <asp:menuitem text="Rock"
                tooltip="Rock"/>
              <asp:menuitem text="Jazz"
                tooltip="Jazz"/>
            </asp:menuitem>
            <asp:menuitem text="Movies"
              tooltip="Movies">
              <asp:menuitem text="Action"
                tooltip="Action"/>
              <asp:menuitem text="Drama"
                tooltip="Drama"/>
              <asp:menuitem text="Musical"
                tooltip="Musical"/>
            </asp:menuitem>
          </asp:menuitem>
        </items>

      </asp:menu>
      
      <hr/>
      
      <asp:label id="Message" 
        runat="server"/>
        
    </form>
  </body>
</html>

<!-- </Snippet1> -->
