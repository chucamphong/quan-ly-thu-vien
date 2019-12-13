using BusinessLogicLayer;
using Core;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Childs
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        
        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Xin chào {Auth.User.Name}!";
            this.grdCardTongSoSach.Content = BookEntity.Count().ToString();
            this.grdCardTongSoNhaPhatHanh.Content = PublisherEntity.Count().ToString();
            this.grdCardTongSoNguoiDung.Content = UserEntity.Count().ToString();
            this.grdCardTongSoTacGia.Content = AuthorEntity.Count().ToString();
        }
    }
}
