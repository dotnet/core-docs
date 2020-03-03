<!-- <snippet1> -->
<%@ Page Language="VB" %>
<%@ register TagPrefix="uc1" 
  TagName="DisplayModeMenuVB" 
  Src="DisplayModeMenuVB.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >

<script runat="server">
  Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
    Dim EnableClose as Boolean = false
    If EditorZone1.HeaderCloseVerb.Enabled = False Then
      EnableClose = True
    End If
    EditorZone1.HeaderCloseVerb.Enabled = EnableClose
  End Sub
</script>
<head runat="server">
    <title>Tool Zone Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:WebPartManager ID="WebPartManager1" Runat="server" />
      <uc1:DisplayModeMenuVB ID="DisplayModeMenu1" runat="server" />
      <asp:WebPartZone ID="WebPartZone1" Runat="server" >
        <ZoneTemplate>
          <asp:BulletedList 
            ID="BulletedList1" 
            Runat="server"
            DisplayMode="HyperLink" 
            Title="Favorite Links" >
            <asp:ListItem Value="http://msdn.microsoft.com">MSDN</asp:ListItem>
            <asp:ListItem Value="http://www.asp.net">ASP.NET</asp:ListItem>
            <asp:ListItem Value="http://www.msn.com">MSN</asp:ListItem>
          </asp:BulletedList>
        </ZoneTemplate>
      </asp:WebPartZone>
      <asp:EditorZone 
        ID="EditorZone1" 
        Runat="server">
        <HeaderCloseVerb Text="End Editing" />
        <ZoneTemplate>
          <asp:AppearanceEditorPart ID="AppearanceEditorPart1" Runat="server" />
          <asp:LayoutEditorPart ID="LayoutEditorPart1" Runat="server" /> 
        </ZoneTemplate>
      </asp:EditorZone>
      <asp:Button ID="Button1" Runat="server" 
        Text="Enable/Disable Close Verb" 
        OnClick="Button1_Click" />
      </div>
    </form>
</body>
</html>
<!-- </snippet1> -->