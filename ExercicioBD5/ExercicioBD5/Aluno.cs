using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioBD5
{
    class aluno
    {
        //propriedades
        private int id;
        private string matricula;
        private string nome;
        private string nomesala;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Matricula
        {
            get
            {
                return matricula;
            }
        }
        public string Nome 
        {
            get
            {
                return nome;
            }
        }
        public string Nomesala
        {
            get
            {
                return nomesala;
            }
        }
        public static  List<aluno> all ()
        {
            string sql = "select alunos.id, alunos.matricula, alunos.nome, salas.nome_sala from alunos inner join sala_tem_alunos on sala_tem_alunos.aluno_id = alunos.id inner join salas on salas.id = sala_tem_alunos.sala_id;";
            SqlConnection con = Conexao.ConAbrir();
            List<aluno> lista1 = new List<aluno>();
            if (Conexao.ConEstaAberta())
            {
                SqlCommand comd_produto = new SqlCommand(sql, con);
                SqlDataReader leitor = comd_produto.ExecuteReader();
                while (leitor.Read())
                {
                    aluno a = new aluno();
                    a.id = Convert.ToInt32(leitor["id"]);
                    a.nomesala = Convert.ToString (leitor["nome_sala"]);
                    a.matricula = Convert.ToString(leitor["matricula"]);
                    a.nome = Convert.ToString(leitor["nome"]);
                    lista1.Add(a);
                }
            }
            return lista1;
        }
        public static List<aluno> Busca_por_nome(string nome)
        {
            string sql = "select alunos.id, alunos.matricula, alunos.nome, salas.nome_sala from alunos inner join sala_tem_alunos on sala_tem_alunos.aluno_id = alunos.id inner join salas on salas.id = sala_tem_alunos.sala_id where alunos.nome = " + nome + ";";
            SqlConnection con = Conexao.ConAbrir();
            List<aluno> lista = new List<aluno>();
            if (Conexao.ConEstaAberta())
            {
                SqlCommand comd_produto = new SqlCommand(sql, con);
                SqlDataReader leitor = comd_produto.ExecuteReader();
                while (leitor.Read())
                {
                    aluno a = new aluno();
                    a.id = Convert.ToInt32(leitor["id"]);
                    a.nomesala = Convert.ToString(leitor["nome_sala"]);
                    a.matricula = Convert.ToString(leitor["matricula"]);
                    a.nome = Convert.ToString(leitor["nome"]);
                    lista.Add(a);
                }
            }
            return lista;
        }
   }

}
