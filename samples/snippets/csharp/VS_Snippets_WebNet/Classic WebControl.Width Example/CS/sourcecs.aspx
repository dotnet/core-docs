<!--<Snippet1>-->
<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head2" runat="server">
    <title>WebControl Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <h3>Width Property of a Web Control</h3>
    <asp:Table id="Table1" runat="server"
        CellPadding="10" GridLines="Both"
        Width="350">
 
        <asp:TableRow>
            <asp:TableCell>
                Row 0, Col 0
            </asp:TableCell>
 
            <asp:TableCell>
                Row 0, Col 1
            </asp:TableCell>
        </asp:TableRow>
 
        <asp:TableRow>
            <asp:TableCell>
                Row 1, Col 0
            </asp:TableCell>
 
            <asp:TableCell>
                Row 1, Col 1
            </asp:TableCell>
        </asp:TableRow>
 
 </asp:Table>
 
    </div>
    </form>
</body>
</html>
<!--</Snippet1>-->
