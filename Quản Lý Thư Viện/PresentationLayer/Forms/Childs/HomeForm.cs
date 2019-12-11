using BusinessLogicLayer;
using DataTransferObject.Models;
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
        private User User;

        public HomeForm()
        {
            InitializeComponent();
        }
        
        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Xin chào {this.User.Name}!";
            this.lblSoSachHienCo.Text = BookEntity.Count().ToString();
        }

        public void Auth(User user)
        {
            this.User = user;
        }
    }
}
