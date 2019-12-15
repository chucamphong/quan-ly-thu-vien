using BusinessLogicLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Childs
{
    public partial class AuthorScreen : Form
    {
        /// <summary>
        /// Lưu lại dữ liệu trước khi thay đổi thông tin của tác giả
        /// </summary>
        private Author _oldAuthorData;

        public AuthorScreen()
        {
            InitializeComponent();
        }

        private void AuthorScreen_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = AuthorLogic.GetAll();
            dataGridView.Columns["Id"].ReadOnly = true;
            dataGridView.Columns["Books"].Visible = false;
        }

        /// <summary>
        /// Thực hiện tìm kiếm tác giả theo tên khi người dùng nhấn Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            var authorName = (sender as Control).Text;
            dataGridView.DataSource = AuthorLogic.FindByName(authorName);
        }

        /// <summary>
        /// Lưu lại dữ liệu trước khi bắt đầu chỉnh sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this._oldAuthorData = this.GetAuthorAtRow(e.RowIndex);
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu sau khi chỉnh sửa
        /// Nếu hợp lệ thì cập nhật lên cơ sở dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dữ liệu
            Author author = this.GetAuthorAtRow(e.RowIndex);

            // Kiểm tra không được để trống
            if (string.IsNullOrEmpty(author.Name))
            {
                MessageBox.Show("Tên tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.RejectEdit(e.RowIndex);
                return;
            }

            // Trường hợp không có gì thay đổi
            if (author.Name == this._oldAuthorData.Name)
            {
                this.RejectEdit(e.RowIndex);
                return;
            }

            try
            {
                AuthorLogic.Update(author);
                MessageBox.Show("Cập nhật tên tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException exception)
            {
                // Trường hợp tên tác giả bị trùng
                if (exception.InnerException.InnerException is SqlException innerException && (innerException.Number == 2627 || innerException.Number == 2601))
                {
                    MessageBox.Show($"Tên [{author.Id}] đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                else
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin cho tác giả có ID: {author.Id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.RejectEdit(e.RowIndex);
            }
        }

        /// <summary>
        /// Đặt lại giá trị cũ nếu giá trị mới không hợp lệ
        /// </summary>
        /// <param name="rowIndex"></param>
        private void RejectEdit(int rowIndex)
        {
            dataGridView.Rows[rowIndex].Cells[0].Value = this._oldAuthorData.Id;     // Cột ID
            dataGridView.Rows[rowIndex].Cells[1].Value = this._oldAuthorData.Name;   // Cột Name
        }

        /// <summary>
        /// Lấy thông tin tác giả tại rowIndex
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns>Thông tin tác giả</returns>
        private Author GetAuthorAtRow(int rowIndex)
        {
            // Lấy dữ liệu
            int id = (int)dataGridView.Rows[rowIndex].Cells[0].Value;
            string name = dataGridView.Rows[rowIndex].Cells[1].Value?.ToString();

            return new Author { Id = id, Name = name };
        }
    }
}
