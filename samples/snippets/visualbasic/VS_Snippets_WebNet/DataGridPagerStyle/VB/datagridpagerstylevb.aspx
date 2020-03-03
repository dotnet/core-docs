<!-- <Snippet1> -->

<%@ Page Language="VB" AutoEventWireup="True" %>
<%@ Import Namespace="System.Data" %>
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
   <script runat="server">
 
      Function CreateDataSource() As ICollection 

         ' Create sample data for the DataGrid control.
         Dim dt As DataTable = New DataTable()
         Dim dr As DataRow
 
         ' Define the columns of the table.
         dt.Columns.Add(new DataColumn("IntegerValue", GetType(Int32)))
         dt.Columns.Add(new DataColumn("StringValue", GetType(String)))
         dt.Columns.Add(new DataColumn("CurrencyValue", GetType(Double)))
 
         ' Populate the table with sample values.
         Dim i As Integer

         For i=0 To 100

            dr = dt.NewRow()
 
            dr(0) = i
            dr(1) = "Item " & i.ToString()
            dr(2) = 1.23 * (i + 1)
 
            dt.Rows.Add(dr)
         
         Next i
 
         Dim dv As DataView = New DataView(dt)

         Return dv
      
      End Function
 
      Sub Page_Load(sender As Object, e As EventArgs)
 
         ' Load sample data only once, when the page is first loaded.
         If Not IsPostBack Then 
         
            ItemsGrid.DataSource = CreateDataSource()
            ItemsGrid.DataBind()
         
         End If

      End Sub

      Sub Selection_Change(sender As Object, e As EventArgs)

         ' Set the background color for the paging controls section of
         ' the DataGrid control.
         ItemsGrid.PagerStyle.BackColor = _
             System.Drawing.Color.FromName(List.SelectedItem.Value)

      End Sub

      Sub Grid_Change(sender As Object, e As DataGridPageChangedEventArgs) 
 
         ' For the DataGrid control to navigate to the correct page when
         ' paging is allowed, the CurrentPageIndex property must be
         ' updated programmatically. This process is usually accomplished
         ' in the event-handling method for the PageIndexChanged event.

         ' Set CurrentPageIndex to the page the user clicked.
         ItemsGrid.CurrentPageIndex = e.NewPageIndex

         ' Rebind the data to refresh the DataGrid control. 
         ItemsGrid.DataSource = CreateDataSource()
         ItemsGrid.DataBind()
      
      End Sub

   </script>
 
<head runat="server">
    <title>DataGrid PagerStyle Example</title>
</head>
<body>
 
   <form id="form1" runat="server">
 
      <h3>DataGrid PagerStyle Example</h3>

      Select a backcolor for the paging controls section
      of the DataGrid control.

      <br /><br />
 
      <b>Product List</b>
 
      <asp:DataGrid id="ItemsGrid"
           BorderColor="black"
           BorderWidth="1"
           CellPadding="3"
           AutoGenerateColumns="False"
           PageSize="10"
           AllowPaging="True"
           OnPageIndexChanged="Grid_Change"
           runat="server">

         <HeaderStyle BackColor="#00aaaa">
         </HeaderStyle>

         <Columns>

            <asp:BoundColumn DataField="IntegerValue" 
                 SortExpression="IntegerValue"
                 HeaderText="Item"/>

            <asp:BoundColumn DataField="StringValue"
                 SortExpression="StringValue" 
                 HeaderText="Description"/>

            <asp:BoundColumn DataField="CurrencyValue" 
                 HeaderText="Price"
                 SortExpression="CurrencyValue"
                 DataFormatString="{0:c}">

               <ItemStyle HorizontalAlign="Right">
               </ItemStyle>

            </asp:BoundColumn>

         </Columns> 
 
      </asp:DataGrid>

      <hr />

      <table cellpadding="5">

         <tr>

            <td>

               BackColor:

            </td>

         </tr>

         <tr>

            <td>

               <asp:DropDownList id="List"
                    AutoPostBack="True"
                    OnSelectedIndexChanged="Selection_Change"
                    runat="server">

                  <asp:ListItem Selected="True" Value="White"> White </asp:ListItem>
                  <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                  <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                  <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                  <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>

               </asp:DropDownList>

            </td>

         </tr>

      </table>
 
   </form>
 
</body>
</html>

<!-- </Snippet1> -->