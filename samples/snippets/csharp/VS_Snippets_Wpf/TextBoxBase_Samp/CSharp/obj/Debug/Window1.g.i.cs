﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62D16B099AFD09B017ADA6C51E2F5F2CB4064574C8CA3ABD3A40E0B5EC934DB8"
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


namespace SDKSample {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radiobtn1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel myStackPanel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox myTextBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox myTextBox2;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock myTB1;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock myTB2;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock myTB3;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock myTB4;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock myTB5;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock myTB6;
        
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
            System.Uri resourceLocater = new System.Uri("/SDKSample;component/window1.xaml", System.UriKind.Relative);
            
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
            
            #line 6 "..\..\Window1.xaml"
            ((SDKSample.Window1)(target)).ContentRendered += new System.EventHandler(this.initValues);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.lineDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.lineLeft);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.lineRight);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.lineUp);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.pageDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 16 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.pageLeft);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 17 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.pageRight);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 18 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.pageUp);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 19 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.scrollHome);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 20 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.scrollEnd);
            
            #line default
            #line hidden
            return;
            case 12:
            this.radiobtn1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\Window1.xaml"
            this.radiobtn1.Checked += new System.Windows.RoutedEventHandler(this.wrapOn);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 24 "..\..\Window1.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.wrapOff);
            
            #line default
            #line hidden
            return;
            case 14:
            this.myStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 15:
            this.myTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            
            #line 48 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.copyText);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 49 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cutText);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 50 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.pasteSelection);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 51 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.selectAll);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 52 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.undoAction);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 53 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.redoAction);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 54 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clearTB1);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 55 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clearTB2);
            
            #line default
            #line hidden
            return;
            case 24:
            this.myTextBox2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\Window1.xaml"
            this.myTextBox2.SelectionChanged += new System.Windows.RoutedEventHandler(this.selectChanged);
            
            #line default
            #line hidden
            
            #line 66 "..\..\Window1.xaml"
            this.myTextBox2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tChanged);
            
            #line default
            #line hidden
            return;
            case 25:
            this.myTB1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 26:
            this.myTB2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 27:
            this.myTB3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 28:
            this.myTB4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 29:
            this.myTB5 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 30:
            this.myTB6 = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

