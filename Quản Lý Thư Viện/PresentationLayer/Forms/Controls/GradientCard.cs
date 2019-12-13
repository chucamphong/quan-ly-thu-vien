using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Controls
{
    public partial class GradientCard : UserControl
    {
        public Color BackgroundGradientColor_1 { get; set; } = Color.FromArgb(136, 126, 227);

        public Color BackgroundGradientColor_2 { get; set; } = Color.FromArgb(98, 175, 253);

        public LinearGradientMode GradientMode { get; set; } = LinearGradientMode.Horizontal;

        public string Header { get; set; } = "Hello";

        public string Content { get; set; } = "Its me";
        
        public GradientCard()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            
            InitializeComponent();

            this.lblHeader.Text = this.Header;
            this.lblContent.Text = this.Content;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (var brush = new LinearGradientBrush(this.ClientRectangle,
                                                       this.BackgroundGradientColor_1,
                                                       this.BackgroundGradientColor_2,
                                                       this.GradientMode))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.lblHeader.Text = this.Header;
            this.lblContent.Text = this.Content;
        }
    }
}
