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
    public partial class InsertLayoutForm<TEntity, TService> : Form
        where TEntity : IEntity, new()
        where TService : IService<TEntity>, new()
    {
        private readonly IService<TEntity> service = new TService();
        private bool validateName = false;

        public InsertLayoutForm()
        {
            this.InitializeComponent();
        }

        public string Title
        {
            get => this.lblName.Text;
            set => this.lblTitle.Text = value;
        }

        public string Label
        {
            get => this.lblName.Text;
            set => this.lblName.Text = value;
        }

        public string BtnText
        {
            get => this.btnAdd.Text;
            set => this.btnAdd.Text = value;
        }

        private void InsertLayoutForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            GunaTextBox txtName = sender as GunaTextBox;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                Validation.SetErrorTextBox(txtName, this.lblNameError, "Thông tin không được để trống");
                this.validateName = false;
            }
            else
            {
                Validation.ClearErrorTextBox(txtName, this.lblNameError);
                this.validateName = true;
            }
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            if (!this.validateName)
            {
                MessageBox.Show("Thông tin không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TEntity entity = new TEntity
            {
                Name = this.txtName.Text,
            };

            this.Insert(entity);
        }

        /// <summary>
        /// Gửi truy vấn thêm thông tin đến cơ sở dữ liệu.
        /// </summary>
        /// <param name="entity">Thông tin cần thêm.</param>
        private void Insert(TEntity entity)
        {
            try
            {
                this.service.Insert(entity);
                this.Close();
            }
            catch (DbUpdateException exception)
            {
                // Trường hợp tên tác giả bị trùng
                if (exception.InnerException.InnerException is SqlException innerException && (innerException.Number == 2627 || innerException.Number == 2601))
                {
                    MessageBox.Show($"Dữ liệu đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm vào cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
