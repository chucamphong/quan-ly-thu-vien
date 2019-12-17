using System;
using System.Windows.Forms;
using Guna.UI.Lib;

namespace PresentationLayer.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            this.InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }
    }
}
