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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCEP_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtComplemento.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTelefone.Text, txtEmail.Text, true);
            if(aluno.cadAluno())
            {
                MessageBox.Show("Aluno cadastrado com sucesso");
            } else
            {
                MessageBox.Show("Erro ao cadastrar aluno...");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
