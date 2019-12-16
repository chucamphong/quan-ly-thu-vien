using System;
using System.Windows.Forms;
using Guna.UI.Lib;

namespace PresentationLayer.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            this.InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }
    }
}
