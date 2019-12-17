using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using PresentationLayer.Forms.Childs;

namespace PresentationLayer.Forms.Screen
{
    public partial class AuthorScreen : Form
    {
        /// <summary>
        /// Lưu lại dữ liệu trước khi thay đổi thông tin của tác giả.
        /// </summary>
        private Author oldAuthorData;

        public AuthorScreen()
        {
            this.InitializeComponent();
        }

        private void AuthorScreen_Load(object sender, EventArgs e)
        {
            this.AllAuthor();
        }

        /// <summary>
        /// Thực hiện tìm kiếm tác giả theo tên khi người dùng nhấn Enter.
        /// </summary>
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            string authorName = (sender as Control).Text;

            if (string.IsNullOrEmpty(authorName))
            {
                this.AllAuthor();
            }
            else
            {
                this.FindAuthor(authorName);
            }
        }

        private void AllAuthor()
        {
            this.authorsBindingSource.DataSource = AuthorLogic.GetAll();
        }

        private void FindAuthor(string authorName)
        {
            List<Author> authors = AuthorLogic.FindByName(authorName);

            if (authors.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy tác giả [{authorName}]", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                this.authorsBindingSource.DataSource = authors;
            }
        }

        /// <summary>
        /// Lưu lại thông tin trước khi bắt đầu chỉnh sửa.
        /// </summary>
        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.oldAuthorData = this.GetAuthorAtRow(e.RowIndex);
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu sau khi chỉnh sửa
        /// Nếu hợp lệ thì cập nhật lên cơ sở dữ liệu.
        /// </summary>
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
            if (author.Name == this.oldAuthorData.Name)
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
                    MessageBox.Show($"Tên [{author.Name}] đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin cho tác giả có ID: {author.Id}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.RejectEdit(e.RowIndex);
            }
        }

        /// <summary>
        /// Đặt lại thông tin tác giả tại vị trí hàng trong DataGridView.
        /// </summary>
        /// <param name="rowIndex">Vị trí cột cần đặt lại thông tin.</param>
        private void RejectEdit(int rowIndex)
        {
            this.dataGridView.Rows[rowIndex].Cells[0].Value = this.oldAuthorData.Id;     // Cột ID
            this.dataGridView.Rows[rowIndex].Cells[1].Value = this.oldAuthorData.Name;   // Cột Name
        }

        /// <summary>
        /// Lấy thông tin tác giả tại vị trí hàng trong DataGridView.
        /// </summary>
        /// <param name="rowIndex">Vị trí cột cần lấy thông tin.</param>
        /// <returns>Thông tin tác giả.</returns>
        private Author GetAuthorAtRow(int rowIndex)
        {
            int id = (int)this.dataGridView.Rows[rowIndex].Cells[0].Value;
            string name = this.dataGridView.Rows[rowIndex].Cells[1].Value?.ToString();

            return new Author { Id = id, Name = name };
        }

        /// <summary>
        /// Hiển thị danh sách chức năng khi chuột phải vào các hàng trong DataGridView.
        /// </summary>
        private void DataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            this.dataGridView.ClearSelection();

            if (e.RowIndex > -1)
            {
                this.dataGridView.Rows[e.RowIndex].Selected = true;
                e.ContextMenuStrip = this.contextMenuStrip;
            }
        }

        /// <summary>
        /// Xóa thông tin tác giả trên cơ sở dữ liệu và trong DataGridView.
        /// </summary>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàng đang được chọn
            int rowSelected = this.dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            // Lấy thông tin tác giả tại hàng rowSelected
            Author author = this.GetAuthorAtRow(rowSelected);

            try
            {
                AuthorLogic.Delete(author);

                this.dataGridView.Rows.RemoveAt(rowSelected);

                this.dataGridView.Refresh();

                MessageBox.Show($"Xóa thông tin tác giả [{author.Name}] thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa tác giả [{author.Name}]", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorInsertForm authorInsertForm = new AuthorInsertForm();
            authorInsertForm.ShowDialog();
            this.AllAuthor();
        }
    }
}
