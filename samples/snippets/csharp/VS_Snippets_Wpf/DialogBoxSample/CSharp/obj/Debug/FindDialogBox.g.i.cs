﻿#pragma checksum "..\..\FindDialogBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87B43CD247A4B19D12368F763387107114CA419AE6A451903728E2F87BD7F414"
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
    /// FindDialogBox
    /// </summary>
    public partial class FindDialogBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\FindDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox findWhatTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\FindDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox caseSensitiveCheckBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\FindDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox matchWholeWordCheckBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\FindDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button findNextButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\FindDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DialogBoxSample;component/finddialogbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FindDialogBox.xaml"
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
            this.findWhatTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\FindDialogBox.xaml"
            this.findWhatTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.findWhatTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.caseSensitiveCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 40 "..\..\FindDialogBox.xaml"
            this.caseSensitiveCheckBox.Click += new System.Windows.RoutedEventHandler(this.criteria_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.matchWholeWordCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 43 "..\..\FindDialogBox.xaml"
            this.matchWholeWordCheckBox.Click += new System.Windows.RoutedEventHandler(this.criteria_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.findNextButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\FindDialogBox.xaml"
            this.findNextButton.Click += new System.Windows.RoutedEventHandler(this.findNextButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\FindDialogBox.xaml"
            this.closeButton.Click += new System.Windows.RoutedEventHandler(this.closeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

