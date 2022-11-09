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
    public partial class FRMExcluirAluno : Form
    {
        public FRMExcluirAluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno excuido com sucesso...");
                    } else
                    {
                        MessageBox.Show("Aluno não encontrado...");
                    }
                }
            }

        }
        */
        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mskCPFAluno.Text);

            if (aluno.consultarAluno())
            {
                if (aluno.excluirAluno())
                {
                    MessageBox.Show("ALUNO EXCLUÍDO !!");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno...");
                }
            } else {
                    MessageBox.Show("Aluno não encontrado :(");
            }
                    
        }
    }
}
