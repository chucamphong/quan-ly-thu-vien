namespace PresentationLayer.Forms
{
    partial class HomeForm
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
            this.pnlTitleBar = new Guna.UI.WinForms.GunaLinePanel();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.drgTitleBar = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnResize
            // 
            this.gnResize.TargetForm = this;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.LineColor = System.Drawing.Color.Black;
            this.pnlTitleBar.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlTitleBar.Location = new System.Drawing.Point(3, 3);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(794, 47);
            this.pnlTitleBar.TabIndex = 0;
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
            this.btnMinimize.Location = new System.Drawing.Point(659, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(150)))), ((int)(((byte)(44)))));
            this.btnMinimize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(150)))), ((int)(((byte)(44)))));
            this.btnMinimize.Size = new System.Drawing.Size(45, 47);
            this.btnMinimize.TabIndex = 2;
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
            this.btnMaximize.Location = new System.Drawing.Point(704, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnMaximize.OnHoverIconColor = System.Drawing.Color.White;
            this.btnMaximize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btnMaximize.Size = new System.Drawing.Size(45, 47);
            this.btnMaximize.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(749, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.btnClose.Size = new System.Drawing.Size(45, 47);
            this.btnClose.TabIndex = 0;
            // 
            // drgTitleBar
            // 
            this.drgTitleBar.TargetControl = this.pnlTitleBar;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaResize gnResize;
        private Guna.UI.WinForms.GunaLinePanel pnlTitleBar;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI.WinForms.GunaDragControl drgTitleBar;
    }
}