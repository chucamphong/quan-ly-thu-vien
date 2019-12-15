using Microsoft.Practices.Unity.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer.Forms;
using System;
using System.Configuration;
using System.Windows.Forms;
using Unity;

namespace PresentationLayer
{
    internal static class Program
    {
        private static UnityContainer Container;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bootstrap();

            Container.Resolve<MyApplication>().Run(Environment.GetCommandLineArgs());
        }

        private static void Bootstrap()
        {
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            UnityContainer container = new UnityContainer();
            section.Configure(container);

            Container = container;
        }
    }

    internal class MyApplication : WindowsFormsApplicationBase
    {
        private readonly Form _loginForm;
        public MyApplication(LoginForm loginForm)
        {
            this._loginForm = loginForm;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = this._loginForm;
        }

        protected override void OnCreateSplashScreen()
        {
            this.SplashScreen = new SplashScreen();
        }
    }
}
