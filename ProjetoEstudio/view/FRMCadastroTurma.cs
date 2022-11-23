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
            DAO_Connection.con.Open();

            MySqlCommand DescModalidadeToIDModalidade = new MySqlCommand("SELECT idEstudio_Modalidade from Estudio_Modalidade WHERE descricaoModalidade like '" + txtDescModalidade.Text.ToString() + "'", DAO_Connection.con);
            MySqlDataReader idModalidadeReader = DescModalidadeToIDModalidade.ExecuteReader();
            idModalidadeReader.Read();
            int idModalidade = Convert.ToInt32(idModalidadeReader["idEstudio_Modalidade"]);

            DAO_Connection.con.Close();
            idModalidadeReader.Close();

            Turma turmaCadastrar = new Turma(txtProfessor.Text.ToString(), txtDiaSemana.Text.ToString(), mskHora.Text.ToString(), idModalidade);

            if (turmaCadastrar.cadastrarTurma())
            {
                MessageBox.Show("Turma cadastrada !");
                populateGridViewModalidade();
            } else
            {
                MessageBox.Show("Erro ao cadastrar turma !");
            }
            DAO_Connection.con.Close();
            idModalidadeReader.Close();
        }

        private void populateGridViewModalidade()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            DAO_Connection.con.Open();
            MySqlCommand consultaModalidadeQuery = new MySqlCommand("SELECT descricaoModalidade from Estudio_Modalidade", DAO_Connection.con);
            MySqlDataReader resModalidade = consultaModalidadeQuery.ExecuteReader();

            while (resModalidade.Read())
            {
                dataGridView1.Rows.Add(resModalidade["descricaoModalidade"].ToString());
            }
            resModalidade.Close();
            DAO_Connection.con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtDescModalidade.Clear();

            DAO_Connection.con.Open();
            MySqlCommand getDescModalidade = new MySqlCommand("SELECT descricaoModalidade FROM Estudio_Modalidade WHERE descricaoModalidade like '" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "'", DAO_Connection.con);
            MySqlDataReader resDescModalidade = getDescModalidade.ExecuteReader();
            resDescModalidade.Read();
            txtDescModalidade.Text = resDescModalidade["descricaoModalidade"].ToString();

            DAO_Connection.con.Close();
            resDescModalidade.Close();
        }
    }
}
