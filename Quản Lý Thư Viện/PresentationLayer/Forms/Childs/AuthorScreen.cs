using BusinessLogicLayer;
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
    public partial class AuthorScreen : Form
    {
        public AuthorScreen()
        {
            InitializeComponent();
        }

        private void AuthorScreen_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = AuthorLogic.GetAll();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            
            Control txtSearch = sender as Control;
            dataGridView.DataSource = AuthorLogic.FindByName(txtSearch.Text);
        }
    }
}
