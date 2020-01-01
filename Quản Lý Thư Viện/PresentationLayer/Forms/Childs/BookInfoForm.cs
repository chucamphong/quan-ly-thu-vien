using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using Guna.UI.Lib;
using DataAccessLayer;

namespace PresentationLayer.Forms.Childs
{
    public partial class BookInfoForm : Form
    {
        private readonly IBookService bookService = new BookService();
        private readonly Book book;
        private ICollection<Author> authors = new HashSet<Author>();

        public BookInfoForm(int bookId)
        {
            this.InitializeComponent();
            this.book = this.bookService.Find(bookId);
        }

        private void BookInfoForm_Load(object sender, EventArgs e)
        {
            GraphicsHelper.ShadowForm(sender as Form);

            this.txtID.Text = this.book.Id.ToString();
            this.txtName.Text = this.book.Name;
            this.txtAuthors.Text = this.HumanizeAuthor(this.book.Authors);
        }

        private void BtnSelectAuthor_Click(object sender, EventArgs e)
        {
            BookInfoAuthorSelectForm bookInfoAuthorSelectForm = new BookInfoAuthorSelectForm(this.book.Authors)
            {
                SendListAuthors = this.ListAuthors,
            };
            bookInfoAuthorSelectForm.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //this.bookService.Update(this.book);

            //this.book.Authors.Clear();

            //foreach (var author in this.authors)
            //{
            //    this.book.Authors.Add(author);
            //}

            //this.bookService.Save();

            //using (var context = new LibraryManagementSystemContext())
            //{
            //    context.Database.Log = Console.WriteLine;

            //    context.Books.Attach(this.book);
            //    context.Entry(this.book).State = System.Data.Entity.EntityState.Modified;

            //    this.book.Authors.Clear();

            //    foreach (var author in this.authors)
            //    {
            //        Author a = context.Authors.Find(author.Id);
            //        this.book.Authors.Add(a);
            //    }

            //    context.SaveChanges();
            //}
        }

        private void ListAuthors(List<Author> authors)
        {
            this.authors = authors.ToList();
            this.txtAuthors.Text = this.HumanizeAuthor(this.authors);
        }

        private string HumanizeAuthor(ICollection<Author> authors)
        {
            if (authors is null)
            {
                return string.Empty;
            }

            return string.Join(", ", authors.Select(author => author.Name));
        }

        private Book GetBookData()
        {
            AuthorService authorService = new AuthorService();

            this.book.Authors.Clear();
            this.book.Authors.Add(authorService.Find(1));

            return this.book;
        }
    }
}
