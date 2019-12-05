using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MyApplication myApplication = new MyApplication();
            myApplication.Run(Environment.GetCommandLineArgs());
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
