<!-- <Snippet1> -->
<%@ Page Language="C#" %>
<%@ Import Namespace="System.ComponentModel" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
bool IsValidEmail(string strIn)
{
    // Return true if strIn is in valid email format.
    return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"); 
}

void OnLoggingIn(object sender, System.Web.UI.WebControls.LoginCancelEventArgs e)
{
    Login loginControl = (Login)PlaceHolder1.FindControl("loginControl");

    if (!IsValidEmail(loginControl.UserName))
    {
        loginControl.InstructionText = "You must enter a valid email address.";
        e.Cancel = true;
    }
    else
    {
        loginControl.InstructionText = String.Empty;
    }
}

void Page_Load(object sender, EventArgs e) 
{
    Login loginControl = new Login();

    loginControl.ID = "loginControl";

    loginControl.HelpPageText = "Help logging in...";
    loginControl.HelpPageUrl = "help.aspx";

    loginControl.PasswordRecoveryText = "Forgot your password?";
    loginControl.PasswordRecoveryUrl = "getPass.aspx";

    loginControl.LoggingIn += new LoginCancelEventHandler(OnLoggingIn);

    PlaceHolder1.Controls.Add(loginControl);

}
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
    <title>ASP.NET Example</title>
</head>
<body>
        <form id="form1" runat="server">
            <asp:PlaceHolder id="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </form>
    </body>
</html>
<!-- </Snippet1> -->
