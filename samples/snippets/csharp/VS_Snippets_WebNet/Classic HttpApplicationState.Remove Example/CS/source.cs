﻿using System;
using System.Web;
using System.Web.UI;

public class Page1: Page
{
 private void Page_Load(Object sender, EventArgs e)
 {
// <Snippet1>
Application.Remove("MyAppVar1");
   
// </Snippet1>
 }
}
