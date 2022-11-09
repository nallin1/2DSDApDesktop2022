using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudio
{
    class Modalidade
    {
        private String descricao;
        private double preco;
        private int qtd_alunos;
        private int qtd_aulas;

        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Qtd_alunos { get => qtd_alunos; set => qtd_alunos = value; }
        public int Qtd_aulas { get => qtd_aulas; set => qtd_aulas = value; }

        public Modalidade() { }

        public Modalidade(string descricao)
        {
            DAO_Connection.getConnection("143.106.241.3", "cl201239", "cl201239", "cl*13072005");
            this.descricao = descricao;
        }

        public Modalidade(string descricao, double preco, int qtd_alunos, int qtd_aulas)
        {
            DAO_Connection.getConnection("143.106.241.3", "cl201239", "cl201239", "cl*13072005");
            this.descricao = descricao;
            this.preco = preco;
            this.qtd_alunos = qtd_alunos;
            this.qtd_aulas = qtd_aulas;
        }

        public Modalidade(double preco, int qtd_alunos, int qtd_aulas)
        {
            DAO_Connection.getConnection("143.106.241.3", "cl201239", "cl201239", "cl*13072005");
            this.preco = preco;
            this.qtd_alunos = qtd_alunos;
            this.qtd_aulas = qtd_aulas;
        }

        public bool cadastrarModalidade()
        {
            bool checkCadModalidade = false;
            try
            {
                DAO_Connection.con.Open();           
                MySqlCommand insert = new MySqlCommand("INSERT INTO Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdAlunos, qtdAulas) values ('" + Descricao + "', '" + Preco + "', '" + Qtd_alunos + "', '" + Qtd_aulas + "')", DAO_Connection.con);
                insert.ExecuteNonQuery();
                checkCadModalidade = true;
            } catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao cadastrar modalidade... -- " + ex.ToString());
            }  finally
            {
                DAO_Connection.con.Close();
            }

            return checkCadModalidade;
        }

        public bool excluirModalidade()
        {
            bool checkExModalidade = false;
            try
            {
                DAO_Connection.con.Open();
                StringBuilder sbQuery = new StringBuilder()
                    .Append("update Estudio_Modalidade set ativa=0 where descricaoModalidade=")
                    .Append("'" + Descricao + "'");
                MySqlCommand excluirQuery = new MySqlCommand(sbQuery.ToString(), DAO_Connection.con);
                excluirQuery.ExecuteNonQuery();
                checkExModalidade = true;
                Console.WriteLine("Modalidade: " + Descricao);
            } catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao excluir modalidade: " + Descricao + "\n" + ex.ToString());
            } finally
            {
                DAO_Connection.con.Close();
            }
            return checkExModalidade;
        }

        public bool AtualizarModalidade()
        {
            bool checkUpdate = false;

            try
            {
                DAO_Connection.con.Open();
                String query = "UPDATE Estudio_Modalidade set precoModalidade=" + Preco + ", qtdAlunos=" + Qtd_alunos + ", qtdAulas=" + Qtd_aulas + " where descricaoModalidade like '" + Descricao + "'";

                MySqlCommand atualizarQuery = new MySqlCommand(query.ToString(), DAO_Connection.con);
                atualizarQuery.ExecuteNonQuery();
                checkUpdate = true;
            } catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao atualizar modalidade... " + Descricao + "\n" + ex.ToString());
            } finally
            {
                DAO_Connection.con.Close();
                
            }
            return checkUpdate;
        }
    }
}
