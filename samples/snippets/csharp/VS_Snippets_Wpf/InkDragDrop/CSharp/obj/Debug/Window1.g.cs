﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE35E9AA777EAA2B8965B08D2F7B91A2D951364E66099A8832B0D3F210DC0CDC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;




/// <summary>
/// Window1
/// </summary>
public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 17 "..\..\Window1.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.InkCanvas ic1;
    
    #line default
    #line hidden
    
    
    #line 23 "..\..\Window1.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.InkCanvas ic2;
    
    #line default
    #line hidden
    
    private bool _contentLoaded;
    
    /// <summary>
    /// InitializeComponent
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent() {
        if (_contentLoaded) {
            return;
        }
        _contentLoaded = true;
        System.Uri resourceLocater = new System.Uri("/InkDragDrop;component/window1.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\Window1.xaml"
        System.Windows.Application.LoadComponent(this, resourceLocater);
        
        #line default
        #line hidden
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
        this.ic1 = ((System.Windows.Controls.InkCanvas)(target));
        
        #line 20 "..\..\Window1.xaml"
        this.ic1.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.InkCanvas_PreviewMouseDown);
        
        #line default
        #line hidden
        
        #line 21 "..\..\Window1.xaml"
        this.ic1.Drop += new System.Windows.DragEventHandler(this.InkCanvas_Drop);
        
        #line default
        #line hidden
        return;
            case 2:
        this.ic2 = ((System.Windows.Controls.InkCanvas)(target));
        
        #line 26 "..\..\Window1.xaml"
        this.ic2.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.InkCanvas_PreviewMouseDown);
        
        #line default
        #line hidden
        
        #line 27 "..\..\Window1.xaml"
        this.ic2.Drop += new System.Windows.DragEventHandler(this.InkCanvas_Drop);
        
        #line default
        #line hidden
        return;
            case 3:
        
        #line 30 "..\..\Window1.xaml"
        ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.switchToSelect);
        
        #line default
        #line hidden
        
        #line 30 "..\..\Window1.xaml"
        ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.switchToInk);
        
        #line default
        #line hidden
        return;
            }
        this._contentLoaded = true;
    }
}

