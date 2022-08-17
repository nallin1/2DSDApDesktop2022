using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ExAula1_SplashScreen
{
    public partial class FRM1 : Form
    {
        public FRM1()
        {
            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            thread.Abort();
        }

        public void splashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void FRM1_Load(object sender, EventArgs e)
        {

        }
    }
}
