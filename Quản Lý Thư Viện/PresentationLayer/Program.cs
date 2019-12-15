using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer.Forms;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new MyApplication().Run(Environment.GetCommandLineArgs());
        }
    }

    internal class MyApplication : WindowsFormsApplicationBase
    {
        protected override void OnCreateMainForm()
        {
            this.MainForm = new LoginForm();
        }

        protected override void OnCreateSplashScreen()
        {
            this.SplashScreen = new SplashScreen();
        }
    }
}
