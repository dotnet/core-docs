﻿using System;
using System.Windows.Forms;

public class Form1: Form
{
// <Snippet1>
private void InitializeMyButton()
 {
    // Create and initialize a Button.
    Button button1 = new Button();
 
    // Set the button to return a value of OK when clicked.
    button1.DialogResult = DialogResult.OK;
 
    // Add the button to the form.
    Controls.Add(button1);
 }
 
// </Snippet1>
}
