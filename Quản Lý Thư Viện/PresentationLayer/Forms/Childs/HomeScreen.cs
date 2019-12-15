using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using Core;

namespace PresentationLayer.Forms.Childs
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            this.InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Xin chào {Auth.User.Name}!";
            this.grdCardTongSoSach.Content = BookLogic.Count().ToString();
            this.grdCardTongSoNhaPhatHanh.Content = PublisherLogic.Count().ToString();
            this.grdCardTongSoNguoiDung.Content = UserLogic.Count().ToString();
            this.grdCardTongSoTacGia.Content = AuthorLogic.Count().ToString();
        }
    }
}
