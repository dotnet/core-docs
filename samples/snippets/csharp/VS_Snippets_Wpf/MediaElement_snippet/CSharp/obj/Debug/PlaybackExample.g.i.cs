﻿#pragma checksum "..\..\PlaybackExample.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0CFF122946E24268860C1F00C9EA3D9B65C16BC3970378848A3688DCA8A0B75B"
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


namespace MediaElementExample {
    
    
    /// <summary>
    /// PlaybackExample
    /// </summary>
    public partial class PlaybackExample : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image playBTN;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image pauseBTN;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image stopBTN;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image volBTN;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image muteBTN;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSL;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\PlaybackExample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement storyboardTarget;
        
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
            System.Uri resourceLocater = new System.Uri("/MediaElementExample;component/playbackexample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlaybackExample.xaml"
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
            
            #line 5 "..\..\PlaybackExample.xaml"
            ((MediaElementExample.PlaybackExample)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PlaybackPageLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.media = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.playBTN = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\PlaybackExample.xaml"
            this.playBTN.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PlayMedia);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pauseBTN = ((System.Windows.Controls.Image)(target));
            
            #line 30 "..\..\PlaybackExample.xaml"
            this.pauseBTN.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PauseMedia);
            
            #line default
            #line hidden
            return;
            case 5:
            this.stopBTN = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\PlaybackExample.xaml"
            this.stopBTN.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StopMedia);
            
            #line default
            #line hidden
            return;
            case 6:
            this.volBTN = ((System.Windows.Controls.Image)(target));
            
            #line 37 "..\..\PlaybackExample.xaml"
            this.volBTN.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MuteMedia);
            
            #line default
            #line hidden
            return;
            case 7:
            this.muteBTN = ((System.Windows.Controls.Image)(target));
            
            #line 41 "..\..\PlaybackExample.xaml"
            this.muteBTN.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MuteMedia);
            
            #line default
            #line hidden
            return;
            case 8:
            this.volumeSL = ((System.Windows.Controls.Slider)(target));
            
            #line 45 "..\..\PlaybackExample.xaml"
            this.volumeSL.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ChangeMediaVolume);
            
            #line default
            #line hidden
            return;
            case 9:
            this.storyboardTarget = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

