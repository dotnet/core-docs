﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CA0D426607D587A81D705F81B11D39C58ABDE75DBE89ED92AC66BF64DC3632B4"
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


namespace SdkSample {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuFileClose;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuFileRights;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuFilePublish;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuFilePrint;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuViewIncreaseZoom;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuViewDecreaseZoom;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock promptBlock;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusBlock;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock rightsBlockTitle;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock rightsBlock;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DocumentViewer docViewer;
        
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
            System.Uri resourceLocater = new System.Uri("/UnsignedPubLicense;component/window1.xaml", System.UriKind.Relative);
            
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
            
            #line 7 "..\..\Window1.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OnOpen);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 8 "..\..\Window1.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OnClose);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 9 "..\..\Window1.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OnPrint);
            
            #line default
            #line hidden
            return;
            case 4:
            this.menuFileClose = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.menuFileRights = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\Window1.xaml"
            this.menuFileRights.Click += new System.Windows.RoutedEventHandler(this.OnRights);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menuFilePublish = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\Window1.xaml"
            this.menuFilePublish.Click += new System.Windows.RoutedEventHandler(this.OnPublish);
            
            #line default
            #line hidden
            return;
            case 7:
            this.menuFilePrint = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            
            #line 29 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnExit);
            
            #line default
            #line hidden
            return;
            case 9:
            this.menuViewIncreaseZoom = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 10:
            this.menuViewDecreaseZoom = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 11:
            this.promptBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.statusBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.rightsBlockTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.rightsBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.docViewer = ((System.Windows.Controls.DocumentViewer)(target));
            return;
            case 16:
            
            #line 101 "..\..\Window1.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OnPrint);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

