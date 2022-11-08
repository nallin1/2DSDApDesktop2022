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

namespace ProjetoEstudio.view
{
    public partial class FRMAtualizarModalidade : Form
    {
        public FRMAtualizarModalidade()
        {
            InitializeComponent();
        }

        private void btnAtualizarMod_Click(object sender, EventArgs e)
        {

        }

        private void FRMAtualizarModalidade_Load(object sender, EventArgs e)
        {
            DAO_Connection.con.Open();
            MySqlCommand selectDesc = new MySqlCommand("Select descricaoModalidade from Estudio_Modalidade where ativa=1", DAO_Connection.con);
            using (MySqlDataReader res = selectDesc.ExecuteReader())
            {
                cbModalidade.Items.Clear();
                while (res.Read())
                {
                    cbModalidade.Items.Add(res.GetString("descricaoModalidade"));
                    cbModalidade.Text = res[0].ToString();
                }
                
                res.Close();
            }
            DAO_Connection.con.Close();
        }

        private void cbModalidade_SelectedValueChanged(object sender, EventArgs e)
        {
            DAO_Connection.con.Open();
            MySqlCommand selectModalidade = new MySqlCommand("Select * from Estudio_Modalidade where descricaoModalidade='" + cbModalidade.Text + "'", DAO_Connection.con);
            using (MySqlDataReader resModalidade = selectModalidade.ExecuteReader())
            {
                resModalidade.Read();

                txtPreco.Text = "";
                txtQtdAlunos.Text = "";
                txtQtdAulas.Text = "";
                txtPreco.Text = resModalidade.GetString("precoModalidade").ToString();
                txtQtdAlunos.Text = resModalidade.GetString("qtdAlunos").ToString();
                txtQtdAulas.Text = resModalidade.GetString("qtdAulas").ToString();

                resModalidade.Close();
            }
            DAO_Connection.con.Close();
        }

        private void FRMAtualizarModalidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                DAO_Connection.con.Close();

            } catch (Exception ex)
            {
                Console.WriteLine("Conexão já fechada... " + ex.ToString());
            }
            
        }
    }
}
