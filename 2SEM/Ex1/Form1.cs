using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {

        DateTime inicio, fim;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            inicio = DateTime.Now;
            timer1.Start();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            lblCronometro.Text = "00:00:00";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timerTick(object sender, EventArgs e)
        {
            fim = DateTime.Now;
            TimeSpan difHorarios = fim.Subtract(inicio);
            lblCronometro.Text = difHorarios.ToString("hh\\:mm\\:ss");
        }
    }
}
