using BusinessLogicLayer;
using DataTransferObject.Models;
using Guna.UI.WinForms;
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
using System.Security.Authentication;

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

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            GunaGradientButton btnLogin = sender as GunaGradientButton;
            LoadingForm loadingForm = new LoadingForm();

            try
            {
                btnLogin.Enabled = false;
                loadingForm.Show();
                
                await UserEntity.Login(txtUsername.Text, txtPassword.Text);

                this.Hide();
                
                loadingForm.Close();
                
                new HomeForm().ShowDialog();
                
                this.Close();
            }
            catch (AuthenticationException exception)
            {
                loadingForm.Close();
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
