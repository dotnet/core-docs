<!-- <Snippet1> -->

<%@ Page Language="VB" AutoEventWireup="True" %>
<%@ Import Namespace="System.Data" %>
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
   <script runat="server">
 
      Function CreateDataSource() As ICollection 
      
         ' Create sample data for the DataList control.
         Dim dt As DataTable = New DataTable()
         dim dr As DataRow
 
         ' Define the columns of the table.
         dt.Columns.Add(New DataColumn("IntegerValue", GetType(Int32)))
         dt.Columns.Add(New DataColumn("StringValue", GetType(String)))
         dt.Columns.Add(New DataColumn("CurrencyValue", GetType(Double)))
         dt.Columns.Add(New DataColumn("ImageValue", GetType(String)))
 
         ' Populate the table with sample values.
         Dim i As Integer

         For i = 0 To 8 

            dr = dt.NewRow()
 
            dr(0) = i
            dr(1) = "Description for item " & i.ToString()
            dr(2) = 1.23 * (i + 1)
            dr(3) = "Image" & i.ToString() & ".jpg"
 
            dt.Rows.Add(dr)

         Next i
 
         Dim dv As DataView = New DataView(dt)
         Return dv

      End Function
 
      Sub Page_Load(sender As Object, e As EventArgs) 

         ' Load sample data only once, when the page is first loaded.
         If Not IsPostBack Then 
     
            ItemsList.DataSource = CreateDataSource()
            ItemsList.DataBind()
         
         End If

      End Sub

      Sub Selection_Change(sender As Object, e As EventArgs)

         ' Set whether to display the header and footer sections
         ' of the DataList control.
         ItemsList.ShowHeader = ShowHeaderCheckBox.Checked
         ItemsList.ShowFooter = ShowFooterCheckBox.Checked

      End Sub
 
   </script>
 
<head runat="server">
    <title>DataList ShowHeader and ShowFooter Example</title>
</head>
<body>
 
   <form id="form1" runat="server">

      <h3>DataList ShowHeader and ShowFooter Example</h3>

      Select whether to show or hide the header and footer sections.

      <br /><br />
 
      <asp:DataList id="ItemsList"
           BorderColor="black"
           CellPadding="5"
           CellSpacing="5"
           RepeatDirection="Vertical"
           RepeatLayout="Table"
           RepeatColumns="3"
           ShowHeader="True"
           ShowFooter="True"
           runat="server">

         <HeaderStyle BackColor="#aaaadd">
         </HeaderStyle>

         <FooterStyle BackColor="#aaaadd">
         </FooterStyle>

         <AlternatingItemStyle BackColor="Gainsboro">
         </AlternatingItemStyle>

         <HeaderTemplate>

            List of items

         </HeaderTemplate>

         <FooterTemplate>

            <asp:Image id="FooterImage"
                 GenerateEmptyAlternateText='true'
                 ImageUrl='FooterImage.jpg'
                 runat="server"/>

         </FooterTemplate>
               
         <ItemTemplate>

            Description: <br />
            <%# DataBinder.Eval(Container.DataItem, "StringValue") %>

            <br />

            Price: <%# DataBinder.Eval(Container.DataItem, "CurrencyValue", "{0:c}") %>

            <br />

            <asp:Image id="ProductImage"
                 AlternateText='<%# DataBinder.Eval(Container.DataItem, "StringValue") %>'
                 ImageUrl='<%# DataBinder.Eval(Container.DataItem, "ImageValue") %>'
                 runat="server"/>

         </ItemTemplate>
 
      </asp:DataList>

<hr />

      <table cellpadding="5">

         <tr>

            <td>

               <asp:CheckBox id="ShowHeaderCheckBox"
                    Text="Show header section"
                    Checked="True"
                    AutoPostBack="True"
                    OnCheckedChanged="Selection_Change"
                    runat="server"/>
 
            </td>

            <td>

               <asp:CheckBox id="ShowFooterCheckBox"
                    Text="Show footer section"
                    Checked="True"
                    AutoPostBack="True"
                    OnCheckedChanged="Selection_Change"
                    runat="server"/>

            </td>

         </tr>

      </table>
 
   </form>
 
</body>
</html>

<!-- </Snippet1> -->
