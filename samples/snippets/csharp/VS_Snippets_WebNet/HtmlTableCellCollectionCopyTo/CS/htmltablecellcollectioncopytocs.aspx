<!--<Snippet1>-->
<%@ Page Language="C#" AutoEventWireup="True" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

  void Button_Click(Object sender, EventArgs e)
  {

    HtmlTableCell[] myCellArray = new HtmlTableCell[2];

    // Copy the collection to an array.
    Table1.Rows[0].Cells.CopyTo(myCellArray, 0);

    Span1.InnerText = "The copied items from the selected row are: ";

    // Iterate through the array and display its contents.
    foreach (HtmlTableCell cell in myCellArray)
    {

      Span1.InnerText = Span1.InnerText + " " + cell.InnerText;

    }

  }

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
   <title>HtmlTableCellCollection Example</title>
</head>
<body>

   <form id="form1" runat="server">

      <h3>HtmlTableCellCollection Example</h3>

      <table id="Table1" 
             style="border-width:1; border-color:Black"
             runat="server">

         <tr>
            <td>
               Cell 1
            </td>
            <td>
               Cell 2
            </td>
         </tr>
         <tr>
            <td>
               Cell 3
            </td>
            <td>
               Cell 4
            </td>
         </tr>

      </table>

      <br /><br />
  
      <input type="button" 
             value="Display the contents of the first row"
             onserverclick="Button_Click" 
             runat="server"/>

      <br /><br />

      <span id="Span1"
            runat="server"/>

   </form>

</body>
</html>
<!--</Snippet1>-->