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

        private void FRMAtualizarModalidade_Load_1(object sender, EventArgs e)
        {
            populateComboBox();

            
        }

        public void populateComboBox()
        {
            DAO_Connection.con.Open();
            MySqlCommand updateCmd = new MySqlCommand("select descricaoModalidade from Estudio_Modalidade where ativa=1", DAO_Connection.con);
            MySqlDataReader updateDataReader = updateCmd.ExecuteReader();

            while (updateDataReader.Read())
            {
                cbModalidade.Items.Add(updateDataReader.GetString("descricaoModalidade"));
            }
            updateDataReader.Close();
            DAO_Connection.con.Close();
        }

        private void cbModalidade_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DAO_Connection.con.Open();
                MySqlCommand selectModalidade = new MySqlCommand("select * from Estudio_Modalidade where descricaoModalidade like '" + cbModalidade.Text + "'", DAO_Connection.con);

                MySqlDataReader fillModalidadeInfo = selectModalidade.ExecuteReader();
                fillModalidadeInfo.Read();
                txtPreco.Text = fillModalidadeInfo.GetString("precoModalidade").ToString();
                txtQtdAlunos.Text = fillModalidadeInfo.GetString("qtdAlunos").ToString();
                txtQtdAulas.Text = fillModalidadeInfo.GetString("qtdAulas").ToString();

                fillModalidadeInfo.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro...");
            }
            finally
            {
                DAO_Connection.con.Close();
            }
        }

        private void btnAtualizarModal_Click(object sender, EventArgs e)
        {
            Modalidade updatedModal = new Modalidade(cbModalidade.SelectedItem.ToString(), Convert.ToDouble(txtPreco.Text), Convert.ToInt32(txtQtdAlunos.Text), Convert.ToInt32(txtQtdAulas.Text));

            if (updatedModal.AtualizarModalidade())
            {
                MessageBox.Show("modalidade atualizada");
            }
            else
            {
                MessageBox.Show("modalidade não atualizada");
            }
        }
    }
}
