<!-- <Snippet1> -->
<%@ Page LANGUAGE="VB" SMARTNAVIGATION="false" %>
<%@ Import Namespace="System.Xml" %>

<script runat="server" >
  Private Sub TreeView1_SelectedNodeChanged(sender As Object, e As EventArgs)

    Dim myXml As New XmlDocument
    myXml = CType(XmlSource.GetXmlDocument(), XmlDataDocument)

    Dim iterator As String = TreeView1.SelectedNode.DataPath
    Dim myNode As XmlNode = myXml.SelectSingleNode(iterator)

    myNode.InnerText = "ThisIsATest"
    XmlSource.Save()
    TreeView1.DataBind()
    TreeView1.ExpandAll()
  End Sub ' TreeView1_SelectedNodeChanged
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ASP.NET Example</title>
</head>
<body>
    <form id="Form1" runat="server">

      <asp:xmldatasource
        runat="server"
        id="XmlSource"
        xpath="/bookstore/book"
        datafile="Booksort.xml"
        enableviewstate="False"
        enablecaching="False" />

      <asp:treeview
        runat="server"
        id="TreeView1"
        ExpandDepth="3"
        datasourceid="XmlSource"
        maxdatabinddepth="3"
        autogeneratedatabindings="False"
        onselectednodechanged="TreeView1_SelectedNodeChanged" >
        <databindings>
          <asp:treenodebinding datamember="book" valuefield="publicationdate" />
          <asp:treenodebinding datamember="title" valuefield="#InnerText" />
          <asp:treenodebinding datamember="author" valuefield="#InnerText" />
          <asp:treenodebinding datamember="first-name" valuefield="#InnerText" />
          <asp:treenodebinding datamember="last-name" valuefield="#InnerText" />
        </databindings>
      </asp:treeview>
    </form>
  </body>
</html>
<!-- </Snippet1> -->