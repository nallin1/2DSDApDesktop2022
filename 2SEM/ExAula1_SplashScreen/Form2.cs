using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAula1_SplashScreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void TimerProgressBar(object sender, EventArgs e)
        {
            progressBar1.Increment(30);
            if (progressBar1.Value==100)
            {
                timer1.Enabled = false;
                // ou timer.Stop();
            }
        }
    }
}
