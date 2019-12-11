using DataTransferObject.Models;
using Guna.UI.WinForms;
using Helper.Color;
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

        private User User;

        public delegate void SendUserInfo(User user);

        public MainForm()
        {
            InitializeComponent();
        }

        public void Auth(User user)
        {
            this.User = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Mặc định mở HomeForm đầu tiên
            this.BtnHome_Click(sender, e);

            // Thêm sự kiện Click cho các nút nhấn trên Sidebar
            this.AddEventMenuItemClick();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            #region Thu gọn sidebar khi chiều rộng của form <= 600
            if (this.Size.Width <= 600)
            {
                this.pnlSidebar.Width = this.pnlTitlebar_2.Width = this.SidebarCollapsedWidth;
            }
            else
            {
                this.pnlSidebar.Width = this.pnlTitlebar_2.Width = this.SidebarWidth;
            }
            #endregion
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            new SendUserInfo(homeForm.Auth)(this.User);
            this.SetChildForm(homeForm);
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
    }
}
