﻿#pragma checksum "..\..\MyApp.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0CEBFB41D3F3F6FECAC6B72C8AE680A4F9B17DF512849C639C4C03E14A062F32"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Samples.Animation.TimingBehaviors;
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


namespace Microsoft.Samples.Animation.TimingBehaviors {
    
    
    /// <summary>
    /// MyApp
    /// </summary>
    public partial class MyApp : System.Windows.Application {
        
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
            
            #line 5 "..\..\MyApp.xaml"
            this.Startup += new System.Windows.StartupEventHandler(this.myAppStartup);
            
            #line default
            #line hidden
            System.Uri resourceLocater = new System.Uri("/TimingBehaviors_markup;component/myapp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MyApp.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main() {
            Microsoft.Samples.Animation.TimingBehaviors.MyApp app = new Microsoft.Samples.Animation.TimingBehaviors.MyApp();
            app.InitializeComponent();
            app.Run();
        }
    }
}

