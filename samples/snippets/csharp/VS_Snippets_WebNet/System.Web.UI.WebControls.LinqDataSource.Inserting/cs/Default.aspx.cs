﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    //<Snippet1>
    protected void LinqDataSource_Inserting(object sender, LinqDataSourceInsertEventArgs e)
    {
        Product product = (Product)e.NewObject;
        product.DateModified = DateTime.Now;
    }
    //</Snippet1>
}
