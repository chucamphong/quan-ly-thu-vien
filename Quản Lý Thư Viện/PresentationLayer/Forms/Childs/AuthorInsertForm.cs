using System;
using System.Windows.Forms;
using Core.Validation;
using DataTransferObject;
using Guna.UI.Lib;
using Guna.UI.WinForms;

namespace PresentationLayer.Forms.Childs
{
    public partial class AuthorInsertForm : Form
    {
        private readonly Author author = new Author();

        public AuthorInsertForm()
        {
            this.InitializeComponent();
        }

        public delegate void DelegateSendAuthor(Author author);

        public DelegateSendAuthor SendAuthor { get; set; }

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
            }
            else
            {
                Validation.ClearErrorTextBox(txtName, this.lblNameError);
            }
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            this.author.Name = this.txtName.Text;

            this.SendAuthor(this.author);

            this.Close();
        }
    }
}
