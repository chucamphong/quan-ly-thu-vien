namespace PresentationLayer
{
    partial class LoadingForm
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
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.pnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.prgLoading = new Guna.UI.WinForms.GunaProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCopyRight = new Guna.UI.WinForms.GunaLabel();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.pnlLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.IconColor = System.Drawing.Color.LightGray;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(736, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnClose.OnPressedDepth = 0;
            this.btnClose.Size = new System.Drawing.Size(45, 49);
            this.btnClose.TabIndex = 0;
            // 
            // pnlLayout
            // 
            this.pnlLayout.ColumnCount = 1;
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLayout.Controls.Add(this.btnClose, 0, 0);
            this.pnlLayout.Controls.Add(this.prgLoading, 0, 2);
            this.pnlLayout.Controls.Add(this.lblTitle, 0, 1);
            this.pnlLayout.Controls.Add(this.lblCopyRight, 0, 3);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlLayout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.RowCount = 4;
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.07692F));
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.pnlLayout.Size = new System.Drawing.Size(784, 411);
            this.pnlLayout.TabIndex = 0;
            // 
            // prgLoading
            // 
            this.prgLoading.BackColor = System.Drawing.Color.Transparent;
            this.prgLoading.BorderColor = System.Drawing.Color.Black;
            this.prgLoading.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.prgLoading.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.prgLoading.Location = new System.Drawing.Point(20, 224);
            this.prgLoading.Margin = new System.Windows.Forms.Padding(20);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(247)))), ((int)(((byte)(191)))));
            this.prgLoading.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.prgLoading.Radius = 3;
            this.prgLoading.Size = new System.Drawing.Size(744, 10);
            this.prgLoading.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(20, 147);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(744, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đồ Án Quản Lý Thư Viện";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCopyRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCopyRight.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCopyRight.Location = new System.Drawing.Point(589, 369);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(192, 42);
            this.lblCopyRight.TabIndex = 2;
            this.lblCopyRight.Text = "Copyright © Cẩm Phong, Duy Anh";
            this.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Enabled = true;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.pnlLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Form";
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox btnClose;
        private System.Windows.Forms.TableLayoutPanel pnlLayout;
        private Guna.UI.WinForms.GunaProgressBar prgLoading;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaLabel lblCopyRight;
        private System.Windows.Forms.Timer tmrLoading;
    }
}

