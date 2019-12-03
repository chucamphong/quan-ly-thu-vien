using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;

            if (prgLoading.Value != 100)
            {
                prgLoading.Increment(1);
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
