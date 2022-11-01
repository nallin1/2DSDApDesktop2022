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
    public partial class FRMCadastroModalidade : Form
    {
        public FRMCadastroModalidade()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CadModalidade_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(this.txtDescricao.Text.ToString(), float.Parse(this.txtPreco.Text), int.Parse(this.txtQtdAlunos.Text), int.Parse(this.txtQtdAulas.Text));
            if (modalidade.cadastrarModalidade())
            {
                MessageBox.Show("Modalidade cadastrada com sucesso !");
            } else
            {
                MessageBox.Show("Erro ao cadastrar modalidade...");
            }
        }

        private void FRMCadastroModalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
