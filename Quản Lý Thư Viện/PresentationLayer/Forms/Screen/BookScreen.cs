using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;

namespace PresentationLayer.Forms.Screen
{
    public partial class BookScreen : Form
    {
        private readonly BookService bookService = new BookService();

        public BookScreen()
        {
            this.InitializeComponent();
        }

        private void BookScreen_Load(object sender, System.EventArgs e)
        {
            this.dataGridView.AutoGenerateColumns = true;
            this.LoadAll();
        }

        private void LoadAll()
        {
            this.BindGrid(this.bookService.All());
        }

        private void BindGrid(IEnumerable<Book> books)
        {
            this.bindingSource.DataSource = books.Select(book =>
            {
                return new
                {
                    book.Id,
                    book.Name,
                    Authors = string.Join(", ", book.Authors.Select(author => author.Name)),
                    Publisher = book.Publishers.Name,
                    Category = string.Join(", ", book.Categories.Select(author => author.Name)),
                };
            });
        }
    }
}
