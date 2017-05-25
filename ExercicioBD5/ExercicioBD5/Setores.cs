using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExercicioBD5
{
    class Setores
    {
        private int id;
        private string nome;
        private string descricao;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
        }
        //lista setores
        public static List<Setores> all()
        {
            string sql = "select * from setores;";
            SqlConnection con = Conexao.ConAbrir();
            List<Setores> lista = new List<Setores> ();
            if (Conexao.ConEstaAberta())
            {
                SqlCommand comd_Setores = new SqlCommand (sql, con);
                SqlDataReader leitor2 = comd_Setores.ExecuteReader();
                while(leitor2.Read())
                {
                    Setores s = new Setores();
                    s.id = Convert.ToInt32(leitor2["id"]);
                    s.nome = Convert.ToString(leitor2["nome_setor"]);
                    s.descricao = Convert.ToString(leitor2["descricao"]);
                    lista.Add(s);

                }

            }
            return lista;
        }
        public static List<Setores> Busca_por_nome(string nome)
        {
            string sql = "select * from setores where nome_setor = '" + nome + "';";
            SqlConnection con = Conexao.ConAbrir();
            List<Setores> lista = new List<Setores>();
            if (Conexao.ConEstaAberta())
            {
                SqlCommand comd_produto = new SqlCommand(sql, con);
                SqlDataReader leitor = comd_produto.ExecuteReader();
                while (leitor.Read())
                {
                    Setores s = new Setores();
                    s.id = Convert.ToInt32(leitor["id"]);
                    s.nome = Convert.ToString(leitor["nome_setor"]);
                    s.descricao = Convert.ToString(leitor["descricao"]);
                    lista.Add(s);
                }
            }
            return lista;
        }
        public static List<Setores> Busca_por_id(int id)
        {
            string sql = "select * from setores where id = " + id + ";";
            SqlConnection con = Conexao.ConAbrir();
            List<Setores> lista = new List<Setores>();
            if (Conexao.ConEstaAberta())
            {
                SqlCommand comd_produto = new SqlCommand(sql, con);
                SqlDataReader leitor = comd_produto.ExecuteReader();
                while (leitor.Read())
                {
                    Setores s = new Setores();
                    s.id = Convert.ToInt32(leitor["id"]);
                    s.nome = Convert.ToString(leitor["nome_setor"]);
                    s.descricao = Convert.ToString(leitor["descricao"]);
                    lista.Add(s);
                }
            }
            return lista;
        }
    
    }
}
