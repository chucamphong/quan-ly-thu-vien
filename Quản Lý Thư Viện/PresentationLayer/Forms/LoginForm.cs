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
using Helper.Validation;
using Helper.Color;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        private bool _validatedUsername = false;
        private bool _validatedPassword = false;

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
            if (!this._validatedUsername || !this._validatedPassword)
            {
                MessageBox.Show("Địa chỉ email hoặc mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            GunaTextBox txtUsername = sender as GunaTextBox;
            string email = txtUsername.Text;

            if (Validation.IsEmail(email))
            {
                txtUsername.BorderColor = txtUsername.FocusedBorderColor = CustomColor.MineShaft;
                this.lblUsernameError.Text = string.Empty;
                this._validatedUsername = true;
                return;
            }

            this._validatedUsername = false;

            txtUsername.BorderColor = txtUsername.FocusedBorderColor = CustomColor.Mandy;

            this.lblUsernameError.Text = string.IsNullOrEmpty(email) ? "Địa chỉ email không được để trống." :
                                                                       "Địa chỉ email không hợp lệ.";
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            GunaTextBox txtPassword = sender as GunaTextBox;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                txtPassword.BorderColor = txtPassword.FocusedBorderColor = CustomColor.Mandy;
                this.lblPasswordError.Text = "Mật khẩu không được để trống.";
                this._validatedPassword = false;
                return;
            }

            txtPassword.BorderColor = txtPassword.FocusedBorderColor = CustomColor.MineShaft;
            this.lblPasswordError.Text = string.Empty;
            this._validatedPassword = true;
        }
    }
}
