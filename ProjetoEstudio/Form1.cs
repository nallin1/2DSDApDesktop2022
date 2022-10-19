using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (DAO_Connection.getConnection("143.106.241.3", "cl201239", "cl201239", "cl*13072005"))
                Console.WriteLine("VOCÊ SE CONECTOU À MATRIX");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Connection.login(textBox1.Text, textBox2.Text);
            if (tipo == 0)
            {
                MessageBox.Show("Usuário/senha inválidas");
            } else if (tipo == 1){
                MessageBox.Show("Usuário ADM");
                grpLogin.Visible = false;
                menuStrip1.Enabled = true;
            } else if (tipo == 2)
            {
                MessageBox.Show("Usuário restrito");
                grpLogin.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cad_Login = new CadastroUsuario();
            cad_Login.MdiParent = this;
            cad_Login.WindowState = FormWindowState.Maximized;
            cad_Login.Show();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno cad_aluno = new CadastroAluno();
            cad_aluno.MdiParent = this;
            cad_aluno.WindowState = FormWindowState.Maximized;
            cad_aluno.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirAluno excluirAluno = new ExcluirAluno();
            excluirAluno.Show();
        }
    }
}
