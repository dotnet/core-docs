<!-- <snippet1> -->
<%@ page language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

  Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
  
    If Not Page.Header Is Nothing Then
    
      ' Create a Style object to hold style rules to apply to a Label control.
      Dim labelStyle As Style = New Style()

      labelStyle.ForeColor = System.Drawing.Color.DarkRed
      labelStyle.BorderColor = System.Drawing.Color.DarkBlue
      labelStyle.BorderWidth = 2

      ' Register the Style object so that it can be merged with 
      ' the Style object of the controls that use it.
      Page.Header.StyleSheet.RegisterStyle(labelStyle, Nothing)

      ' Merge the labelCssStyle style with the label1 control's
      ' style settings.
      label1.MergeStyle(labelStyle)
      label1.Text = "This is what the labelCssStyle looks like."
      
    End If
    
  End Sub
  
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="head1" runat="server">
    <title>IStyleSheet Example</title>
</head>    
<body>
    <form id="form1" runat="server">
        <h1>IStyleSheet Example</h1>
        <asp:Label 
          id="label1" 
          runat="server">
        </asp:Label>
    </form>
  </body>
</html>
<!-- </snippet1> -->