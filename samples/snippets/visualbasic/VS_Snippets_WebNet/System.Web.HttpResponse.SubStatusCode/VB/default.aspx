<!-- <Snippet2> -->
<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Label1.Text = Response.SubStatusCode.ToString()
        Label2.Text = Response.StatusCode.ToString()
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Test Module Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    SubStatusCode = <asp:Label ID="Label1" runat="server"/>
    <br />
    StatusCode = <asp:Label ID="Label2" runat="server" />
    
    </div>
    </form>
</body>
</html>
<!-- </Snippet2> -->