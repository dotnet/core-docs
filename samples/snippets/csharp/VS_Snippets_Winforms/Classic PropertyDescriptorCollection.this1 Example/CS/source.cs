﻿using System;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

public class Form1: Form
{
 protected Button button1;
 protected TextBox textBox1;
// <Snippet1>
 private void PrintIndexItem2() {
    // Creates a new collection and assigns it the properties for button1.
    PropertyDescriptorCollection properties =
        TypeDescriptor.GetProperties(button1);
 
    // Sets a PropertyDescriptor to the specific property.
    PropertyDescriptor myProperty = properties["Opacity"];
 
    // Prints the display name for the property.
    textBox1.Text = myProperty.DisplayName;
 }

// </Snippet1>
}
