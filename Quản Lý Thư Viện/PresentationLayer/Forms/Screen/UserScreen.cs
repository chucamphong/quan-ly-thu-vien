using System;
using System.Windows.Forms;
using Core;

namespace PresentationLayer.Forms.Screen
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            this.InitializeComponent();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            this.lblName.Text = Auth.User.Name;
            this.lblEmail.Text = Auth.User.Email;
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
