﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.TextBox1 = New System.Windows.Forms.TextBox
Me.Button1 = New System.Windows.Forms.Button
Me.TextBox2 = New System.Windows.Forms.TextBox
Me.CheckBox1 = New System.Windows.Forms.CheckBox
Me.SuspendLayout()
'
'TextBox1
'
Me.TextBox1.Location = New System.Drawing.Point(56, 98)
Me.TextBox1.Name = "TextBox1"
Me.TextBox1.Size = New System.Drawing.Size(100, 22)
Me.TextBox1.TabIndex = 0
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(111, 167)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(75, 23)
Me.Button1.TabIndex = 1
Me.Button1.Text = "Button1"
Me.Button1.UseVisualStyleBackColor = True
'
'TextBox2
'
Me.TextBox2.Location = New System.Drawing.Point(56, 40)
Me.TextBox2.Name = "TextBox2"
Me.TextBox2.Size = New System.Drawing.Size(100, 22)
Me.TextBox2.TabIndex = 2
'
'CheckBox1
'
Me.CheckBox1.AutoSize = True
Me.CheckBox1.Location = New System.Drawing.Point(65, 214)
Me.CheckBox1.Name = "CheckBox1"
Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
Me.CheckBox1.TabIndex = 3
Me.CheckBox1.Text = "CheckBox1"
Me.CheckBox1.UseVisualStyleBackColor = True
'
'Form1
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(282, 257)
Me.Controls.Add(Me.CheckBox1)
Me.Controls.Add(Me.TextBox2)
Me.Controls.Add(Me.Button1)
Me.Controls.Add(Me.TextBox1)
Me.Name = "Form1"
Me.Text = "Form1"
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
