using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using PresentationLayer.Forms.Childs;

namespace PresentationLayer.Forms.Screen
{
    public partial class BookScreen : Form
    {
        private readonly IBookService bookService = new BookService();

        public BookScreen()
        {
            this.InitializeComponent();
        }

        private void BookScreen_Load(object sender, System.EventArgs e)
        {
            this.LoadAll();
        }

        private async void LoadAll()
        {
            this.BindGrid(await this.bookService.All());
        }

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
                return;
            }

            var entities = (IList<Book>)this.bookService.FindByName(name);

            if (entities.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin bạn cần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.BindGrid(entities);
            }
        }

        private void BindGrid(IEnumerable<Book> books)
        {
            this.bindingSource.DataSource = books.Select(book =>
            {
                return new
                {
                    book.Id,
                    book.Name,
                };
            }).ToList();
        }

        private void DataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            this.dataGridView.ClearSelection();

            if (e.RowIndex > -1)
            {
                this.dataGridView.Rows[e.RowIndex].Selected = true;
                e.ContextMenuStrip = this.contextMenuStrip;
            }
        }

        private void SeeMoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowSelected = this.dataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            Book book = this.GetDataAtRow(rowSelected);
            new BookInfoForm(book.Id).ShowDialog();
        }

        private Book GetDataAtRow(int rowIndex)
        {
            int id = (int)this.dataGridView.Rows[rowIndex].Cells[0].Value;
            string name = this.dataGridView.Rows[rowIndex].Cells[1].Value?.ToString();

            return new Book
            {
                Id = id,
                Name = name,
            };
        }
    }
}
