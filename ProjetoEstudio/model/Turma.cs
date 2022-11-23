using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudio.model
{
    class Turma
    {
        private string professor;
        private string dia_semana;
        private string hora;
        private int modalidade;


        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public Turma(int modalidade)
        {   
            this.modalidade = modalidade;
        }

        public Turma( string dia_semana, int modalidade)
        {
            this.dia_semana = dia_semana;;
            this.modalidade = modalidade;
        }

        public Turma(int idModalidade, string diaSemana, string hora)
        {
            this.modalidade = idModalidade;
            this.dia_semana = diaSemana;
            this.hora = hora;
        }

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }

        public bool cadastrarTurma()
        {
            bool checkCadTurma = false;

            try
            {
                DAO_Connection.con.Open();
                StringBuilder sbCadTurma = new StringBuilder()
                    .Append("INSERT INTO Estudio_Turma (idModalidade, Professor, diaSemana, horaAula) VALUES ('")
                    .Append(Modalidade + "', '")
                    .Append(Professor + "', '")
                    .Append(Dia_semana + "', '")
                    .Append(Hora + "')");

                MySqlCommand queryCadTurma = new MySqlCommand(sbCadTurma.ToString(), DAO_Connection.con);
                queryCadTurma.ExecuteNonQuery();
                
                Console.WriteLine("TURMA CADASTRADA !");
                checkCadTurma = true;
            } catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao cadastrar turma ! \n" + ex.ToString());
            } finally
            {
                DAO_Connection.con.Close();
            }

            return checkCadTurma;
        }

        public bool excluirTurma()
        {
            bool checkExcTurma = false;

            try
            {
                DAO_Connection.con.Open();
                MySqlCommand excTurma = new MySqlCommand("DELETE FROM Estudio_Turma WHERE idModalidade = " + Modalidade + ", diaSemana='" + Dia_semana + "' horaAula='" + Hora + "'", DAO_Connection.con);
                excTurma.ExecuteNonQuery();
                checkExcTurma = true;
            } catch (MySqlException ex)
            {
                Console.WriteLine("Erro\n\n" + ex.ToString());
            } finally
            {
                DAO_Connection.con.Close();
            }

            return checkExcTurma;
        }
    }
}
