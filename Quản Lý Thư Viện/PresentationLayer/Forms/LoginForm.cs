using System;
using System.ComponentModel;
using System.Security.Authentication;
using System.Windows.Forms;
using BusinessLogicLayer;
using Core;
using Core.Validation;
using DataTransferObject;
using Guna.UI.Lib;
using Guna.UI.WinForms;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService = new UserService();
        private bool validatedUsername = false;
        private bool validatedPassword = false;

        public LoginForm()
        {
            this.InitializeComponent();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
            this.txtUsername.Text = "chucamphong@gmail.com";
            this.txtPassword.Text = "123456";
        }

        /// <summary>
        /// Thực hiện kiểm tra đăng nhập.
        /// </summary>
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của username và password
            if (!this.validatedUsername || !this.validatedPassword)
            {
                MessageBox.Show("Địa chỉ email hoặc mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Control btnLogin = sender as Control;
            LoadingForm loadingForm = new LoadingForm();

            try
            {
                btnLogin.Enabled = false;
                loadingForm.Show();

                User user = await this.userService.Login(this.txtUsername.Text, this.txtPassword.Text);

                this.Hide();

                loadingForm.Close();

                Auth.User = user;

                new MainForm().ShowDialog();

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

        /// <summary>
        /// Kiểm tra username có phải là một email hợp lệ.
        /// </summary>
        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            GunaTextBox txtUsername = sender as GunaTextBox;
            string email = txtUsername.Text;

            if (!Validation.IsEmail(email))
            {
                this.validatedUsername = false;
                string message = string.IsNullOrEmpty(email) ? "Địa chỉ email không được để trống." :
                                                               "Địa chỉ email không hợp lệ.";
                Validation.SetErrorTextBox(txtUsername, this.lblUsernameError, message);
                return;
            }

            this.validatedUsername = true;
            Validation.ClearErrorTextBox(txtUsername, this.lblUsernameError);
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của password.
        /// </summary>
        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            GunaTextBox txtPassword = sender as GunaTextBox;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                this.validatedPassword = false;
                Validation.SetErrorTextBox(txtPassword, this.lblPasswordError, "Mật khẩu không được để trống.");
                return;
            }

            this.validatedPassword = true;
            Validation.ClearErrorTextBox(txtPassword, this.lblPasswordError);
        }
    }
}
