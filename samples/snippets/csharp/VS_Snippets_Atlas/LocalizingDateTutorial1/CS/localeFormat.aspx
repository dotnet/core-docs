// <Snippet1>
<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Globalization Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true"/>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="False" 
                         UpdateMode="Conditional">
            <ContentTemplate>
                   <asp:Panel ID="Panel1" runat="server" GroupingText="Update Panel">
                   <asp:Button ID="Button1" runat="server" Text="Display Date" />
		   <br />
                   <asp:Label ID="Label1" runat="server"></asp:Label>
                   </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
<script type="text/javascript">
// <Snippet2>
    Sys.UI.DomEvent.addHandler($get("Button1"), "click", formatDate);
    function formatDate() {
      var d = new Date();
      try {
        $get('Label1').innerHTML = d.localeFormat("dddd, dd MMMM yyyy HH:mm:ss");
      }
      catch(e) {
        alert("Error:" + e.message);
      }
    }
// </Snippet2>
</script>
// </Snippet1>
