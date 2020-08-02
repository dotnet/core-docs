﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace Microsoft.Samples.BrushExamples
{
    public partial class MyApp : Application
    {

        void myAppStartup(object sender, StartupEventArgs e)
        {
            Window myWindow = new Window();
            myWindow.Content = new SampleViewer();
            MainWindow = myWindow;
            myWindow.Show();
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {

            try
            {
                StreamWriter wr = new StreamWriter("error.txt");
                wr.Write(args.ExceptionObject.ToString());
                wr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            MessageBox.Show("Unhandled exception: " + args.ExceptionObject.ToString());
        }
    }
}
