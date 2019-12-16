using System;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogicLayer;
using Core.Validation;
using DataTransferObject;
using Guna.UI.Lib;
using Guna.UI.WinForms;

namespace PresentationLayer.Forms.Childs
{
    public partial class AuthorInsertForm : Form
    {
        private bool validateAuthorName = false;

        public AuthorInsertForm()
        {
            this.InitializeComponent();
        }

        private void AuthorInsertForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            GunaTextBox txtName = sender as GunaTextBox;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                Validation.SetErrorTextBox(txtName, this.lblNameError, "Tên tác giả không được để trống");
                this.validateAuthorName = false;
            }
            else
            {
                Validation.ClearErrorTextBox(txtName, this.lblNameError);
                this.validateAuthorName = true;
            }
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            if (!this.validateAuthorName)
            {
                MessageBox.Show("Tên tác giả không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Author author = new Author
            {
                Name = this.txtName.Text,
            };

            this.InsertAuthor(author);
        }

        /// <summary>
        /// Gửi truy vấn thêm tác giả đến cơ sở dữ liệu.
        /// </summary>
        /// <param name="author">Tác giả cần thêm.</param>
        private void InsertAuthor(Author author)
        {
            try
            {
                AuthorLogic.Insert(author);
                this.Close();
            }
            catch (DbUpdateException exception)
            {
                // Trường hợp tên tác giả bị trùng
                if (exception.InnerException.InnerException is SqlException innerException && (innerException.Number == 2627 || innerException.Number == 2601))
                {
                    MessageBox.Show($"Tên [{author.Name}] đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm tác giả vào cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
