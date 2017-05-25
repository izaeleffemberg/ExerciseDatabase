using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioBD5
{
    class Salas
    {
        private int id;
        private string setor_nome;
        private string nome;
        private int capacidade;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Setor_nome
        {
            get
            {
                return setor_nome;
            }
        }
        public int Capacidade
        {
            get
            {
                return capacidade;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
        }
        //lista Salas
        public static List<Salas> all()
        {
            string sql = "select salas.id, nome_sala, capacidade, nome_setor from salas inner join setores on setores.id = setor_id;";
            SqlConnection con = Conexao.ConAbrir();
            List<Salas> lista = new List<Salas>();
            if (Conexao.ConEstaAberta())
            {
                SqlCommand comd_Salas = new SqlCommand(sql, con);
                SqlDataReader leitor = comd_Salas.ExecuteReader();
                while (leitor.Read())
                {
                    Salas s = new Salas();
                    s.id = Convert.ToInt32(leitor["id"]);
                    s.nome = Convert.ToString(leitor["nome_sala"]);
                    s.setor_nome = Convert.ToString (leitor["nome_setor"]);
                    s.capacidade = Convert.ToInt32(leitor["capacidade"]);
                    lista.Add(s);

                }

            }

            return lista;
        }

    }
    class sala_8 : Salas
    {
        public static
    }
}
