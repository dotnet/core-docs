<!--<Snippet1>-->
<%@ Page Language="VB" AutoEventWireup="True" %>
<%@ Import Namespace="System.Data" %>
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
   <script language="VB" runat="server">
 
        Function CreateDataSource() As ICollection
            Dim dt As New DataTable()
            Dim dr As DataRow
            
            dt.Columns.Add(New DataColumn("IntegerValue", GetType(Int32)))
            dt.Columns.Add(New DataColumn("StringValue", GetType(String)))
            dt.Columns.Add(New DataColumn("CurrencyValue", GetType(Double)))
            
            Dim i As Integer
            For i = 0 To 8
                dr = dt.NewRow()
                
                dr(0) = i
                dr(1) = "Item " & i.ToString()
                dr(2) = 1.23 *(i + 1)
                
                dt.Rows.Add(dr)
            Next i
            
            Dim dv As New DataView(dt)
            Return dv
        End Function 'CreateDataSource


        Sub Page_Load(sender As Object, e As EventArgs)
            
            If Not IsPostBack Then

                ' Load this data only once.
                ItemsGrid.DataSource = CreateDataSource()
                ItemsGrid.DataBind()

            End If
        End Sub 'Page_Load
         

        Sub Button_Click(sender As Object, e As EventArgs)
            
            ' Create IEnumerator for rows.
            Dim myEnum As IEnumerator = ItemsGrid.Columns.GetEnumerator()
            Dim column As DataGridColumn
            
            Label1.Text = "The header text of the items in the IEnumerator are: <br /><br />"  
            
            ' Iterate through IEnumerator and display its contents.
            While myEnum.MoveNext()
                
                column = CType(myEnum.Current, DataGridColumn)
                Label1.Text &= column.HeaderText & "<br />"
            End While 

        End Sub 'Button_Click
   
   </script>
 
<head runat="server">
    <title>DataGridColumnCollection GetEnumerator Example</title>
</head>
<body>
 
   <form id="form1" runat="server">
 
      <h3>DataGridColumnCollection GetEnumerator Example</h3>
 
      <b>Product List</b>
 
      <asp:DataGrid id="ItemsGrid"
           BorderColor="black"
           BorderWidth="1"
           CellPadding="3"
           AutoGenerateColumns="false"
           runat="server">

         <HeaderStyle BackColor="#00aaaa">
         </HeaderStyle>
 
         <Columns>
                  
            <asp:BoundColumn 
                 HeaderText="Item Number" 
                 DataField="IntegerValue"/>
 
            <asp:BoundColumn 
                 HeaderText="Item" 
                 DataField="StringValue"/>
 
            <asp:BoundColumn 
                 HeaderText="Price" 
                 DataField="CurrencyValue" 
                 DataFormatString="{0:c}">

               <ItemStyle HorizontalAlign="right">
               </ItemStyle>

            </asp:BoundColumn>
 
         </Columns>
   
      </asp:DataGrid>

      <br />

      <asp:Button id="Button1"
           Text="Create IEnumerator"
           OnClick="Button_Click"
           runat="server"/>

      <br />

      <asp:Label id="Label1"
           runat="server"/>    
 
   </form>
 
</body>
</html>

<!--</Snippet1>-->
