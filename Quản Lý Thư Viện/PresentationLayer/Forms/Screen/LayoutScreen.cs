using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;

namespace PresentationLayer.Forms.Screen
{
    public abstract partial class LayoutScreen<TEntity, TService> : Form
        where TEntity : IEntity, new()
        where TService : IService<TEntity>, new()
    {
        /// <summary>
        /// Lưu lại thông tin cũ để phục vụ cho việc phục hồi lại thông tin khi chỉnh sửa.
        /// </summary>
        private TEntity oldEntityData;

        public LayoutScreen(string title)
        {
            this.InitializeComponent();
            this.lblTitle.Text = title;
        }

        protected TService Service { get; } = new TService();

        protected abstract void ShowInsertForm();

        private void LayoutScreen_Load(object sender, EventArgs e)
        {
            this.dataGridView.AutoGenerateColumns = true;
            this.LoadAll();
        }

        /// <summary>
        /// Thực hiện tìm kiếm theo tên khi người dùng nhấn Enter.
        /// </summary>
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            string name = (sender as Control).Text;

            if (string.IsNullOrEmpty(name))
            {
                this.LoadAll();
            }
            else
            {
                var entities = (IList<TEntity>)this.Service.FindByName(name);

                if (entities.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin bạn cần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.bindingSource.DataSource = entities;
                }
            }
        }

        /// <summary>
        /// Lưu lại thông tin trước khi bắt đầu chỉnh sửa.
        /// </summary>
        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.oldEntityData = this.GetDataAtRow(e.RowIndex);
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của dữ liệu sau khi chỉnh sửa
        /// Nếu hợp lệ thì cập nhật lên cơ sở dữ liệu.
        /// </summary>
        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TEntity entity = this.GetDataAtRow(e.RowIndex);

            // Kiểm tra không được để trống
            if (string.IsNullOrEmpty(entity.Name))
            {
                MessageBox.Show("Tên tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.RejectEdit(e.RowIndex);
                return;
            }

            // Trường hợp không có gì thay đổi
            if (entity.Name == this.oldEntityData.Name)
            {
                this.RejectEdit(e.RowIndex);
                return;
            }

            try
            {
                this.Service.Update(entity);
                MessageBox.Show("Cập nhật tên tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateException exception)
            {
                // Trường hợp bị trùng
                if (exception.InnerException.InnerException is SqlException innerException && (innerException.Number == 2627 || innerException.Number == 2601))
                {
                    MessageBox.Show($"Dữ liệu bạn nhập đã tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.RejectEdit(e.RowIndex);
            }
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
        /// Xóa thông tin trên cơ sở dữ liệu và trong DataGridView.
        /// </summary>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hàng đang được chọn
            int rowSelected = this.dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            // Lấy thông tin tại hàng rowSelected
            TEntity entity = this.GetDataAtRow(rowSelected);

            try
            {
                this.Service.Delete(entity);

                this.dataGridView.Rows.RemoveAt(rowSelected);

                this.dataGridView.Refresh();

                MessageBox.Show($"Xóa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.ShowInsertForm();
            this.LoadAll();
        }

        private async void LoadAll()
        {
            this.bindingSource.DataSource = await this.Service.All();
            this.dataGridView.Columns[0].ReadOnly = true;
        }

        /// <summary>
        /// Lấy thông tin tại <paramref name="rowIndex"/> trong DataGridView.
        /// </summary>
        /// <param name="rowIndex">Vị trí cột cần lấy thông tin.</param>
        /// <returns>Thông tin tại hàng <paramref name="rowIndex"/>.</returns>
        private TEntity GetDataAtRow(int rowIndex)
        {
            int id = (int)this.dataGridView.Rows[rowIndex].Cells[0].Value;
            string name = this.dataGridView.Rows[rowIndex].Cells[1].Value?.ToString();

            return new TEntity() { Id = id, Name = name };
        }

        /// <summary>
        /// Đặt lại thông tin tại <paramref name="rowIndex"/> trong DataGridView.
        /// </summary>
        /// <param name="rowIndex">Vị trí cột cần đặt lại thông tin.</param>
        private void RejectEdit(int rowIndex)
        {
            this.dataGridView.Rows[rowIndex].Cells[0].Value = this.oldEntityData.Id;     // Cột ID
            this.dataGridView.Rows[rowIndex].Cells[1].Value = this.oldEntityData.Name;   // Cột Name
        }
    }
}
