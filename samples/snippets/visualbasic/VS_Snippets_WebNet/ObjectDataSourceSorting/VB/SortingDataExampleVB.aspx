<!-- <Snippet2> -->
<%@ Register TagPrefix="aspSample" Namespace="Samples.AspNet.VB" Assembly="Samples.AspNet.VB" %>
<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" 
            runat="server" 
            DataSourceID="ObjectDataSource1"
            AllowSorting="True">
        </asp:GridView>
        <asp:ObjectDataSource 
            ID="ObjectDataSource1" 
            runat="server" 
            SelectMethod="SelectMethod" 
            TypeName="Samples.AspNet.VB.SortingData" 
            SortParameterName="sortExpression">
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
<!-- </Snippet2> -->
