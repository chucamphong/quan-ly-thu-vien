using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BusinessLogicLayer;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(sender as LoginForm);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isLogged = UserEntity.Login(txtUsername.Text, txtPassword.Text);

            if (isLogged)
            {
                MessageBox.Show("Đăng nhập thành công.");
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.");
            }
        }
    }
}
