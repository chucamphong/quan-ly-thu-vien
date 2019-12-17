using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using Core;

namespace PresentationLayer.Forms.Screen
{
    public partial class HomeScreen : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly PublisherService publisherService = new PublisherService();
        private readonly UserService userService = new UserService();
        private readonly AuthorService authorService = new AuthorService();

        public HomeScreen()
        {
            this.InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Xin chào {Auth.User.Name}!";
            this.grdCardTongSoSach.Content = this.bookService.Count().ToString();
            this.grdCardTongSoNhaPhatHanh.Content = this.publisherService.Count().ToString();
            this.grdCardTongSoNguoiDung.Content = this.userService.Count().ToString();
            this.grdCardTongSoTacGia.Content = this.authorService.Count().ToString();
        }
    }
}
