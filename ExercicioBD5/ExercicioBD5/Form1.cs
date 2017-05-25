using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ExercicioBD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conexao.ConAbrir();
            if (Conexao.ConEstaAberta())
            {
                SqlConnection con4 = Conexao.ConFechar();
                SqlConnection con2 = Conexao.ConAbrir();
                List<aluno> lista = aluno.all();
                datagrid1.DataSource = lista;
            }
            else
            {
                SqlConnection con3 = Conexao.ConAbrir();
                List<aluno> lista = aluno.all();
                datagrid1.DataSource = lista;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Conexao.ConEstaAberta())
            {
                SqlConnection con = Conexao.ConFechar();
                SqlConnection con2 = Conexao.ConAbrir();
                List<Setores> lista = Setores.all();
                datagrid1.DataSource = lista;
            }
            else
            {
                SqlConnection con = Conexao.ConAbrir();
                List<Setores> lista = Setores.all();
                datagrid1.DataSource = lista;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ocultando botões
            btn_buscar.Visible = false;
            btn_exibiralunos.Visible = false;
            btn_exibirsalas.Visible = false;
            btn_exibirsetores.Visible = false;
            datagrid1.Visible = false;
            //mostrando botões
            btn_buscasalas.Visible = true;
            btn_buscaalunos.Visible = true;
            btn_buscasetores.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Conexao.ConEstaAberta())
            {
                SqlConnection con = Conexao.ConFechar();
                SqlConnection con2 = Conexao.ConAbrir();
                List<Salas> lista = Salas.all();
                datagrid1.DataSource = lista;
            }
            else
            {
                SqlConnection con = Conexao.ConAbrir();
                List<Salas> lista = Salas.all();
                datagrid1.DataSource = lista;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscasetores_Click(object sender, EventArgs e)
        {
            //mostrando 
            lab_ID.Visible = true;
            lab_nome.Visible = true;
            txtb_ID.Visible = true;
            txtb_nome.Visible = true;
            btn_buscarsetores.Visible = true;
            //ocultando 
            btn_buscasalas.Visible = false;
            btn_buscasetores.Visible = false;
            btn_buscaalunos.Visible = false;

        }

        private void btn_buscarsetores_Click(object sender, EventArgs e)
        {           
            if (Conexao.ConEstaAberta())
            {
                SqlConnection con = Conexao.ConFechar();
                SqlConnection con2 = Conexao.ConAbrir();                
                if (txtb_nome.Text.Length != 0 & txtb_ID.Text.Length == 0)
                {
                    string nome = txtb_nome.Text;
                    datagrid1.Visible = true;
                    List<Setores> lista = Setores.Busca_por_nome(nome);
                    datagrid1.DataSource = lista;

                }
                if (txtb_nome.Text.Length == 0 & txtb_ID.Text.Length != 0)
                {
                    int id = Convert.ToInt32(txtb_ID.Text);
                    datagrid1.Visible = true;
                    List<Setores> lista = Setores.Busca_por_id(id);
                    datagrid1.DataSource = lista;
                }
            }
            else
            {
                SqlConnection con2 = Conexao.ConAbrir();                
                if (txtb_nome.Text.Length != 0 & txtb_ID.Text.Length == 0)
                {
                    string nome = txtb_nome.Text;
                    datagrid1.Visible = true;
                    List<Setores> lista = Setores.Busca_por_nome(nome);
                    datagrid1.DataSource = lista;
                   
                }
                if (txtb_nome.Text.Length == 0 & txtb_ID.Text.Length != 0)
                {
                    int id = Convert.ToInt32 (txtb_ID.Text);
                    datagrid1.Visible = true;
                    List<Setores> lista = Setores.Busca_por_id(id);
                    datagrid1.DataSource = lista;
                }

            }
        }

        private void txtb_ID_KeyDown(object sender, KeyEventArgs e)
        {
            //if (
        }
    }
}
