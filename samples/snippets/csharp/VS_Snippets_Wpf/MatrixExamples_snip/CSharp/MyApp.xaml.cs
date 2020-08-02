﻿using System;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Xml;

namespace Microsoft.Samples.MatrixExamples
{

    public partial class MyApp : Application
    {

        public MyApp()
        {

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        private void myAppStartup(object sender, StartupEventArgs args)
        {

            Window myWindow = new Window();
            myWindow.Content = new SampleViewer();

            myWindow.Show();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            MessageBox.Show("Unhandled exception: " + args.ExceptionObject.ToString());
        }
    }
}
