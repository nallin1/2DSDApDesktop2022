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
    public partial class FRMExcluirTurma : Form
    {
        public FRMExcluirTurma()
        {
            InitializeComponent();
            DAO_Connection.con.Open();
            MySqlCommand getTurmas = new MySqlCommand("SELECT descricaoModalidade from Estudio_Modalidade", DAO_Connection.con);
            MySqlDataReader turmasReader = getTurmas.ExecuteReader();
            while (turmasReader.Read())
            {
                cbTurmas.Items.Add(turmasReader.GetString("descricaoModalidade").ToString());
            }
            turmasReader.Close();
            DAO_Connection.con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNexcluirTurma_Click(object sender, EventArgs e)
        {
            DAO_Connection.con.Open();

            MySqlCommand DescModalidadeToIDModalidade = new MySqlCommand("SELECT idEstudio_Modalidade from Estudio_Modalidade WHERE descricaoModalidade like '" + cbTurmas.SelectedItem.ToString() + "'", DAO_Connection.con);
            MySqlDataReader idModalidadeReader = DescModalidadeToIDModalidade.ExecuteReader();
            idModalidadeReader.Read();
            int idModalidade = Convert.ToInt32(idModalidadeReader["idEstudio_Modalidade"]);

            DAO_Connection.con.Close();
            idModalidadeReader.Close();

            Turma novaTurma = new Turma(idModalidade, cbHora.SelectedItem.ToString(), cbDiaDaSemana.SelectedItem.ToString());

            if (novaTurma.excluirTurma())
            {
                MessageBox.Show("TURMA EXCLUÍDA...");
            } else
            {
                MessageBox.Show("ERRO AO EXCLUIR TURMA");
            }
        }

        private void dbDiaDaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        private void FRMExcluirTurma_Load(object sender, EventArgs e)
        {
            
        }

        private void cbTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            DAO_Connection.con.Open();
            MySqlCommand getDiaSemana = new MySqlCommand("SELECT Estudio_Turma.diaSemana FROM Estudio_Turma INNER JOIN Estudio_Modalidade ON Estudio_Turma.idModalidade=Estudio_Modalidade.idEstudio_Modalidade", DAO_Connection.con);
            MySqlDataReader diaSemanaReader = getDiaSemana.ExecuteReader();
            while (diaSemanaReader.Read())
            {
                cbDiaDaSemana.Items.Add(diaSemanaReader.GetString("diaSemana").ToString());
            }

            diaSemanaReader.Close();
            DAO_Connection.con.Close();


            DAO_Connection.con.Open();
            MySqlCommand getHoras = new MySqlCommand("SELECT Estudio_Turma.horaAula FROM Estudio_Turma INNER JOIN Estudio_Modalidade ON  Estudio_Turma.idModalidade=Estudio_Modalidade.idEstudio_Modalidade", DAO_Connection.con);
            MySqlDataReader horasReader = getHoras.ExecuteReader();
            while (horasReader.Read())
            {
                cbHora.Items.Add(horasReader.GetString("horaAula").ToString());
            }
            horasReader.Close();
            DAO_Connection.con.Close();
        }

        
    }
}
