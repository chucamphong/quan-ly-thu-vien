using System;
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
}
