using System;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            this.InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(sender as Form);
        }
    }
}
