﻿#pragma checksum "..\..\Page1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0D623661B84106D7B1F6F06FF1770D12A67B7538413C3CC8EB6C940080AE0617"
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


namespace Foo {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 73 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.FlowDocument myflowdocument;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Paragraph focusableP;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink h1;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu cm;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Paragraph CursorForced;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Paragraph CursorNotForced;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Paragraph introParagraph;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Paragraph focusme;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Paragraph focusme2;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text1;
        
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
            System.Uri resourceLocater = new System.Uri("/ContentElementsSmorgasbord;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
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
            
            #line 5 "..\..\Page1.xaml"
            ((Foo.Page1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.FocusOnParagraph);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myflowdocument = ((System.Windows.Documents.FlowDocument)(target));
            return;
            case 3:
            this.focusableP = ((System.Windows.Documents.Paragraph)(target));
            
            #line 75 "..\..\Page1.xaml"
            this.focusableP.Drop += new System.Windows.DragEventHandler(this.dropHandler);
            
            #line default
            #line hidden
            return;
            case 4:
            this.h1 = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 77 "..\..\Page1.xaml"
            this.h1.Click += new System.Windows.RoutedEventHandler(this.MakeSpecialLink);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cm = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 6:
            this.CursorForced = ((System.Windows.Documents.Paragraph)(target));
            return;
            case 7:
            this.CursorNotForced = ((System.Windows.Documents.Paragraph)(target));
            return;
            case 8:
            this.introParagraph = ((System.Windows.Documents.Paragraph)(target));
            return;
            case 9:
            this.focusme = ((System.Windows.Documents.Paragraph)(target));
            
            #line 99 "..\..\Page1.xaml"
            this.focusme.GotFocus += new System.Windows.RoutedEventHandler(this.SetBGByResource);
            
            #line default
            #line hidden
            return;
            case 10:
            this.focusme2 = ((System.Windows.Documents.Paragraph)(target));
            
            #line 100 "..\..\Page1.xaml"
            this.focusme2.GotFocus += new System.Windows.RoutedEventHandler(this.SetBGByResourceTry);
            
            #line default
            #line hidden
            return;
            case 11:
            this.text1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 104 "..\..\Page1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FindIntro);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

