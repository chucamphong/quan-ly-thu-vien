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
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prgLoading = new Guna.UI.WinForms.GunaProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaControlBox1.IconColor = System.Drawing.Color.LightGray;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(736, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(156)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.OnPressedDepth = 0;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 49);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gunaControlBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.prgLoading, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gunaLabel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.07692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 411);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(20, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(744, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đồ Án Quản Lý Thư Viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.gunaLabel1.Location = new System.Drawing.Point(589, 369);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(192, 42);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Copyright © Cẩm Phong, Duy Anh";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaProgressBar prgLoading;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer tmrLoading;
    }
}

