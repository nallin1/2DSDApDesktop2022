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
    public partial class FRMExcluirModalidade : Form
    {
        public FRMExcluirModalidade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRMExcluirModalidade_Load(object sender, EventArgs e)
        {
            
            
            populateCBoxModalidades();

            
        }

        public void populateCBoxModalidades()
        {


            DAO_Connection.con.Open();
            MySqlCommand selectDesc = new MySqlCommand("Select descricaoModalidade from Estudio_Modalidade where ativa=1", DAO_Connection.con);
            MySqlDataReader res = selectDesc.ExecuteReader();
            cbModalidade.Items.Clear();
            while (res.Read())
            {
                cbModalidade.Items.Add(res.GetString("descricaoModalidade"));
                cbModalidade.Text = res[0].ToString();
            }
            res.Close();
            DAO_Connection.con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbModalidade.SelectedItem.ToString());
            if (mod.excluirModalidade())
            {
                MessageBox.Show("Modalidade excluida com sucesso !");
            } else
            {
                MessageBox.Show("Modalidade não excluida...");
            }
            populateCBoxModalidades();
        }

        private void FRMExcluirModalidade_FormClosing(object sender, FormClosingEventArgs e)
        {
            DAO_Connection.con.Close();
        }

        private void cbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
