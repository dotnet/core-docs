﻿// <snippet1>
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;

    private void MyTabs()
    {
        this.tabControl1 = new TabControl();
        this.tabPage1 = new TabPage();
        this.tabPage2 = new TabPage();

        this.tabControl1.Controls.AddRange(new Control[] {
            this.tabPage1,
            this.tabPage2});
        this.tabControl1.Padding = new Point(15, 10);
        this.tabControl1.Location = new Point(35, 25);
        this.tabControl1.Size = new Size(220, 220);

        // Selects tabPage2 using SelectedIndex.
        this.tabControl1.SelectedIndex = 1;
    
        this.tabPage1.Text = "myTabPage1";
        this.tabPage1.TabIndex = 0;

        this.tabPage2.Text = "myTabPage2";
        this.tabPage2.TabIndex = 1;

        this.Size = new Size(300, 300);
        this.Controls.AddRange(new Control[] {
            this.tabControl1});
    }
    
    public Form1()
    {
        MyTabs();
    }

    static void Main() 
    {
        Application.Run(new Form1());
    }
}
// </snippet1>