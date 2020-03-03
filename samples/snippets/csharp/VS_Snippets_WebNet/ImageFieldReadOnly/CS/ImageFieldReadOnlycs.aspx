<!-- <Snippet1> -->

<%@ Page language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>ImageField ReadOnly Example</title>
</head>
<body>
    <form id="form1" runat="server">
        
      <h3>ImageField ReadOnly Example</h3>
                       
      <asp:gridview id="EmployeesGrid"
        autogeneratecolumns="false"
        datasourceid="EmployeeSource"
        autogenerateeditbutton="true"
        datakeynames="EmployeeID"   
        runat="server">
      
        <columns>

          <asp:imagefield dataimageurlfield="PhotoPath"
            alternatetext="Employee Photo"
            nulldisplaytext="No image on file."
            headertext="Photo"  
            readonly="true"/>
          <asp:boundfield datafield="FirstName"
            headertext="First Name"/>
          <asp:boundfield datafield="LastName"
            headertext="Last Name"/>
        
        </columns>
        
      </asp:gridview>
          
      <!-- This example uses Microsoft SQL Server and connects  -->
      <!-- to the Northwind sample database. Use an ASP.NET     -->
      <!-- expression to retrieve the connection string value   -->
      <!-- from the Web.config file.                            -->
      <asp:sqldatasource id="EmployeeSource"
        selectcommand="Select [EmployeeID], [LastName], [FirstName], [PhotoPath] From [Employees]"
        updatecommand="Update [Employees] Set [LastName]=@LastName, [FirstName]=@FirstName Where [EmployeeId]=@EmployeeID"
        connectionstring="<%$ ConnectionStrings:NorthWindConnectionString%>" 
        runat="server"/>
            
    </form>
  </body>
</html>

<!-- </Snippet1> -->