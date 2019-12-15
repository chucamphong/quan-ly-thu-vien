using BusinessLogicLayer;
using Core;
using Guna.UI.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Security.Authentication;
using Core.Validation;
using DataTransferObject;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        private readonly MainForm _mainForm;
        private bool _validatedUsername = false;
        private bool _validatedPassword = false;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
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

                User user = await UserEntity.Login(txtUsername.Text, txtPassword.Text);

                this.Hide();
                
                loadingForm.Close();

                Auth.User = user;

                this._mainForm.ShowDialog();

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

            if (!Validation.IsEmail(email))
            {
                this._validatedUsername = false;
                string message = string.IsNullOrEmpty(email) ? "Địa chỉ email không được để trống." :
                                                               "Địa chỉ email không hợp lệ.";
                this.SetErrorTextBox(txtUsername, this.lblUsernameError, message);
                return;
            }

            this._validatedUsername = true;
            this.ClearErrorTextBox(txtUsername, this.lblUsernameError);
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            GunaTextBox txtPassword = sender as GunaTextBox;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(password))
            {
                this._validatedPassword = false;
                this.SetErrorTextBox(txtPassword, this.lblPasswordError, "Mật khẩu không được để trống.");
                return;
            }

            this._validatedPassword = true;
            this.ClearErrorTextBox(txtPassword, this.lblPasswordError);
        }

        private void SetErrorTextBox(GunaTextBox textBox, Label lblError, string message)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = CustomColor.Mandy;
            lblError.Text = message;
        }

        private void ClearErrorTextBox(GunaTextBox textBox, Label lblError)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = CustomColor.MineShaft;
            lblError.Text = string.Empty;
        }
    }
}
