<!-- <snippet1> -->
<%@ Page Language="VB" %>
<%@ Import namespace="System.IO" %>

<script runat="server">
  
    Sub Page_Load()
        Dim FileNames(2) As String
        FileNames(0) = "Test.txt"
        FileNames(1) = "Test2.txt"
        FileNames(2) = "Test3.txt"
        Response.AddFileDependencies(FileNames)
        Response.Write("File Dependencies sucessfully added!")
    End Sub
          
</script>

<!-- </snippet1> -->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ASP.NET Example</title>
</head>
<body>
</body>
</html>
