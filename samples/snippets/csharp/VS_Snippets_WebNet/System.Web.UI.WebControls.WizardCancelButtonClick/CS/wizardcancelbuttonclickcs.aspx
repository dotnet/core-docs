<!-- <snippet1> -->
<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

  void OnCancelButtonClick(object sender, EventArgs e)
  {
    // When the Cancel button is clicked, redirect to http://www.wingtiptoys.com/.
    Response.Redirect("http://www.wingtiptoys.com/");
  }

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>ASP.NET Example</title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:Wizard id="Wizard1" 
        runat="server" 
        displaycancelbutton="True"
        oncancelbuttonclick="OnCancelButtonClick">
        <WizardSteps>
          <asp:WizardStep title="Step 1" 
            runat="server">
          </asp:WizardStep>
          <asp:WizardStep title="Step 2" 
            runat="server">
          </asp:WizardStep>
        </WizardSteps>
        <HeaderTemplate>
          <b>CancelButtonClick Example</b>
        </HeaderTemplate>
      </asp:Wizard>
    </form>
  </body>
</html>
<!-- </snippet1> -->