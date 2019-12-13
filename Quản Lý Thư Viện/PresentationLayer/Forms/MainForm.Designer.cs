namespace PresentationLayer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gnResize = new Guna.UI.WinForms.GunaResize(this.components);
            this.pnlHeader = new Guna.UI.WinForms.GunaLinePanel();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.pnlTitlebar_2 = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.drgTitleBar = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drgTitleBar_2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.sideBarActived = new System.Windows.Forms.Panel();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlTitlebar_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnResize
            // 
            this.gnResize.TargetForm = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.pnlTitlebar_2);
            this.pnlHeader.Controls.Add(this.btnMaximize);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.LineColor = System.Drawing.Color.Black;
            this.pnlHeader.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(819, 47);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(205)))), ((int)(((byte)(44)))));
            this.btnMinimize.IconSize = 15F;
            this.btnMinimize.Location = new System.Drawing.Point(684, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(150)))), ((int)(((byte)(44)))));
            this.btnMinimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(150)))), ((int)(((byte)(44)))));
            this.btnMinimize.Size = new System.Drawing.Size(45, 47);
            this.btnMinimize.TabIndex = 3;
            // 
            // pnlTitlebar_2
            // 
            this.pnlTitlebar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlTitlebar_2.Controls.Add(this.btnMenu);
            this.pnlTitlebar_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitlebar_2.Location = new System.Drawing.Point(0, 0);
            this.pnlTitlebar_2.Name = "pnlTitlebar_2";
            this.pnlTitlebar_2.Size = new System.Drawing.Size(235, 47);
            this.pnlTitlebar_2.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.BaseColor = System.Drawing.Color.White;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.Image = global::PresentationLayer.Properties.Resources.Menu;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(63, 47);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Animated = true;
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(39)))));
            this.btnMaximize.IconSize = 15F;
            this.btnMaximize.Location = new System.Drawing.Point(729, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OnHoverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.OnHoverIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(39)))));
            this.btnMaximize.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Size = new System.Drawing.Size(45, 47);
            this.btnMaximize.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(95)))), ((int)(((byte)(98)))));
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(774, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.Size = new System.Drawing.Size(45, 47);
            this.btnClose.TabIndex = 0;
            // 
            // drgTitleBar
            // 
            this.drgTitleBar.TargetControl = this.pnlHeader;
            // 
            // drgTitleBar_2
            // 
            this.drgTitleBar_2.TargetControl = this.pnlTitlebar_2;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.gunaButton2);
            this.pnlSidebar.Controls.Add(this.sideBarActived);
            this.pnlSidebar.Controls.Add(this.gunaButton4);
            this.pnlSidebar.Controls.Add(this.gunaButton1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSidebar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSidebar.Location = new System.Drawing.Point(3, 50);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(235, 547);
            this.pnlSidebar.TabIndex = 1;
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton2.Image = global::PresentationLayer.Properties.Resources.User;
            this.gunaButton2.ImageOffsetX = 10;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(0, 497);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton2.Size = new System.Drawing.Size(235, 50);
            this.gunaButton2.TabIndex = 6;
            this.gunaButton2.Text = "Tài khoản";
            this.gunaButton2.TextOffsetX = 10;
            this.gunaButton2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // sideBarActived
            // 
            this.sideBarActived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.sideBarActived.Location = new System.Drawing.Point(0, 0);
            this.sideBarActived.Margin = new System.Windows.Forms.Padding(0);
            this.sideBarActived.Name = "sideBarActived";
            this.sideBarActived.Size = new System.Drawing.Size(4, 50);
            this.sideBarActived.TabIndex = 5;
            // 
            // gunaButton4
            // 
            this.gunaButton4.Animated = true;
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton4.Image = global::PresentationLayer.Properties.Resources.OpenBook;
            this.gunaButton4.ImageOffsetX = 10;
            this.gunaButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton4.Location = new System.Drawing.Point(0, 50);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton4.Size = new System.Drawing.Size(235, 50);
            this.gunaButton4.TabIndex = 5;
            this.gunaButton4.Text = "Quản lý sách";
            this.gunaButton4.TextOffsetX = 10;
            this.gunaButton4.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton1.Image = global::PresentationLayer.Properties.Resources.Home;
            this.gunaButton1.ImageOffsetX = 10;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.WhiteSmoke;
            this.gunaButton1.Size = new System.Drawing.Size(235, 50);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "Trang chủ";
            this.gunaButton1.TextOffsetX = 10;
            this.gunaButton1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(238, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 547);
            this.pnlMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(825, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlTitlebar_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaResize gnResize;
        private Guna.UI.WinForms.GunaLinePanel pnlHeader;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar_2;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTitlebar_2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel sideBarActived;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaPictureBox btnMenu;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
    }
}