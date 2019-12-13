using DataTransferObject;
using Guna.UI.WinForms;
using Core;
using PresentationLayer.Forms.Childs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class MainForm : Form
    {
        private Form _childForm;
        
        /// <summary>
        /// Chiều rộng mặc định của Sidebar
        /// </summary>
        private readonly int SidebarWidth = 235;

        /// <summary>
        /// Chiều rộng thu nhỏ của Sidebar
        /// </summary>
        private readonly int SidebarCollapsedWidth = 60;

        public delegate void SendUserInfo(User user);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Mặc định mở HomeForm đầu tiên
            this.BtnHome_Click(sender, e);

            // Thêm sự kiện Click cho các nút nhấn trên Sidebar
            this.AddEventMenuItemClick();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.SetChildForm(new HomeForm());
        }

        /// <summary>
        /// Tạo sự kiện click chuột cho các nút nhấn ở phần Sidebar
        /// </summary>
        private void AddEventMenuItemClick()
        {
            // Đặt thanh màu xanh bên trái cho biết nút đó đã được active
            void MenuItem_Click(object sender, EventArgs e)
            {
                var button = sender as Control;
                this.sideBarActived.Top = button.Top;
                this.sideBarActived.Height = button.Height;
                this.sideBarActived.BringToFront();
            }

            // Thêm sự kiện click cho các nút nhấn
            foreach (Control control in this.pnlSidebar.Controls)
            {
                if (control is GunaButton button)
                {
                    button.Click += new EventHandler(MenuItem_Click);
                }
            }
        }

        /// <summary>
        /// Tạo form con
        /// </summary>
        /// <param name="childForm"></param>
        private void SetChildForm(Form childForm)
        {
            this._childForm = childForm;
            this._childForm.TopLevel = false;
            this._childForm.Dock = DockStyle.Fill;

            this.pnlMain.Controls.Add(this._childForm);
            this.pnlMain.Tag = this._childForm;

            this._childForm.BringToFront();
            this._childForm.Show();
        }

        /// <summary>
        /// Thu gọn / Mở rộng Sidebar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlSidebar.Width == this.SidebarWidth)
            {
                this.pnlSidebar.Width = this.pnlTitlebar_2.Width = this.SidebarCollapsedWidth;
            }
            else
            {
                this.pnlSidebar.Width = this.pnlTitlebar_2.Width = this.SidebarWidth;
            }
        }
    }
}
