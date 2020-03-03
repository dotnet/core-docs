<!-- <Snippet1> -->
<%@ Page Language="VB" 
    Inherits="System.Web.UI.MobileControls.MobilePage" %>
<%@ Register TagPrefix="mobile" 
    Namespace="System.Web.UI.MobileControls" 
    Assembly="System.Web.Mobile" %>

<script runat="server">
    Private Sub SelectStyle(ByVal sender As Object, _
        ByVal e As EventArgs)
        
        ' Retrieve the style name as a string
        Dim myStyle As String = SelectionList1.Selection.ToString()
        ' Match the style name and apply the style to TextView1
        Select Case myStyle
            Case "hot"
                TextView1.StyleReference = "Style1"
            Case "medium"
                TextView1.StyleReference = "Style2"
            Case "mild"
                TextView1.StyleReference = "Style3"
        End Select
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<body>
<mobile:StyleSheet id="StyleSheet1" runat="server">
    <mobile:Style font-size="Large" font-name="Arial" font-bold="true"
        forecolor="red" font-italic="true" backcolor="#E0E0E0" 
        wrapping="wrap" name="Style1">
    </mobile:Style>
    <mobile:Style font-size="Normal" font-name="Arial" font-bold="false" 
       forecolor="Blue" font-italic="true" backcolor="blue" 
       wrapping="NoWrap" name="Style2">
    </mobile:Style>
    <mobile:Style font-size="Small" font-name="Arial Narrow" 
       font-bold="false" forecolor="Green" font-italic="false" 
       backcolor="Green" wrapping="NoWrap" name="Style3">
    </mobile:Style>
</mobile:StyleSheet>

<mobile:form id="Form1" runat="server">
    <mobile:Label id="Label1" runat="server" Text="Today's Special" 
        StyleReference="title" />
    <mobile:TextView id="TextView1" runat="server" 
        StyleReference="Style1">
        Chili
    </mobile:TextView>
    <mobile:SelectionList runat="server" id="SelectionList1">
        <item Text="hot" Value="hot"/>
        <item Text="medium" Value="medium"/>
        <item Text="mild" Value="mild"/>
    </mobile:SelectionList>
    <mobile:Command ID="Command1" runat="server" Text="Select Style" 
        OnClick="SelectStyle" />
    </mobile:form>
</body>
</html>
<!-- </Snippet1> -->
