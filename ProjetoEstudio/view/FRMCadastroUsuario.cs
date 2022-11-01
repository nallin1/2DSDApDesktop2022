using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstudio
{
    public partial class FRMCadastroUsuario : Form
    {
        public FRMCadastroUsuario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo_usuario = 0;
            if(comboBox1.SelectedIndex == 0)
            {
                tipo_usuario = 1;  // posição 1 combo box => adm
            }
            if (comboBox1.SelectedIndex == 1)
            {
                tipo_usuario = 2;  // posição 1 combo box => usuario
            }
            if (DAO_Connection.CadLogin(this.textBox1.Text, this.textBox2.Text, tipo_usuario))
            {
                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO !");
            } else
            {
                MessageBox.Show("Erro ao cadastrar...");
            }
        }
    }
}
