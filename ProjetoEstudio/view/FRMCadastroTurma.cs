using MySql.Data.MySqlClient;
using ProjetoEstudio.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstudio.view
{
    public partial class FRMCadastroTurma : Form
    {
        public FRMCadastroTurma()
        {
            InitializeComponent();
            populateGridViewModalidade();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // public Turma(string professor, string dia_semana, string hora, int modalidade)
        private void button1_Click(object sender, EventArgs e)
        {
            Turma turmaCadastrar = new Turma(txtProfessor.Text.ToString(), txtDiaSemana.Text.ToString(), mskHora.Text.ToString(), Convert.ToInt32(txtIdModalidade.Text));

            if (turmaCadastrar.cadastrarTurma())
            {
                MessageBox.Show("Turma cadastrada !");
                populateGridViewModalidade();
            } else
            {
                MessageBox.Show("Erro ao cadastrar turma !");
            }
        }

        private void populateGridViewModalidade()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            Modalidade gridModalidade = new Modalidade();
            DAO_Connection.con.Open();
            MySqlCommand consultaModalidadeQuery = new MySqlCommand("SELECT descricaoModalidade from Estudio_Modalidade", DAO_Connection.con);
            MySqlDataReader resModalidade = consultaModalidadeQuery.ExecuteReader();

            while (resModalidade.Read())
            {
                dataGridView1.Rows.Add(resModalidade["descricaoModalidade"].ToString());
            }
        }
    }
}
