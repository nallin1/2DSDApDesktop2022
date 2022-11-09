using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace ProjetoEstudio
{
    class Aluno
    {
        private string CPF;
        private string nome;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;
        private string CEP;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private string[] foto;
        private bool ativo;

        public string CPF1 { get => CPF; set => CPF = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string CEP1 { get => CEP; set => CEP = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string[] Foto { get => foto; set => foto = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email, bool ativo)
        {
            DAO_Connection.getConnection("143.106.241.3", "cl201239", "cl201239", "cl*13072005");
            this.CPF = cpf;
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.CEP = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.telefone = telefone;
            this.email = email;
            this.ativo = ativo;
        }
        public Aluno(String cpf)
        {
            DAO_Connection.getConnection("143.106.241.3", "cl201239", "cl201239", "cl*13072005");
            this.CPF = cpf;
        }
        public bool excluirAluno()
        {
            bool exclusao = false;
            try
            {
                DAO_Connection.con.Open();
                MySqlCommand excluirQuery = new MySqlCommand("update Estudio_Aluno set ativo=0 where CPFAluno like '" + CPF + "'", DAO_Connection.con);
                excluirQuery.ExecuteNonQuery();
                exclusao = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Connection.con.Close();
            }
            return exclusao;
        }


        public bool consultarAluno()
        {
            bool existe = false;
                try
            {
                DAO_Connection.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPFAluno like '" + CPF + "'", DAO_Connection.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
                resultado.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Connection.con.Close();
            }
            return existe;
        }

        public Aluno()
        {

        }

        public bool cadAluno()
        {
            bool checkCadAluno = false;
            try
            {
                DAO_Connection.con.Open();
                MySqlCommand insert = new MySqlCommand("INSERT INTO cl201239.Estudio_Aluno (CPFAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno, nomeAluno) VALUES ('" + CPF + "', '" + rua + "', '" + numero + "', '" + bairro + "', '" + complemento + "', '" + CEP + "', '" + cidade + "', '" + estado + "', '" + telefone + "', '" + email + "', '" + nome + "')", DAO_Connection.con);
                insert.ExecuteNonQuery();
                checkCadAluno = true;
            } catch (Exception ex)
            {
                Console.WriteLine("Erro: ", ex.ToString());
            } finally 
            {
                DAO_Connection.con.Close();
            }
            return checkCadAluno;
        }
 
    }
}
