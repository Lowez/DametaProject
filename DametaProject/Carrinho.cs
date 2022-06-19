using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DametaProject
{
    public partial class Carrinho : Form
    {
        WelcomeForm form_inicial;
        NovaCompra form_novacompra;


        public Carrinho(string nome, WelcomeForm form, bool is_new = false)
        {
            InitializeComponent();

            form_inicial = form;

            if (is_new)
            {
                form_novacompra = new NovaCompra(form_inicial, this);

                // Desabilita o carrinho em seu início, para o funcionário selecionar se vai abrir uma nova compra ou sair do sistema
                this.Enabled = false;
            }

            // Adiciona o nome do  usuário que está logando no título do formulário
            this.Text = "Bem vindo(a) " + nome;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

            comm = new SqlCommand(
                "SELECT *, tipo_produtos.nome AS tiposNome FROM produtos " +
                "INNER JOIN estoque ON estoque_id = estoque.id " +
                "INNER JOIN tipo_produtos ON tipo_produtos_id = tipo_produtos.id " +
                "WHERE cod_produto = @cod_produto", conn
                );

            comm.Parameters.Add("@cod_produto", SqlDbType.NVarChar);
            comm.Parameters["@cod_produto"].Value = txCodigoProd.Text;

            try
            {
                // Tenta abrir a conexão com o Banco de Dados
                try
                {
                    conn.Open();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message,
                        "Houve um problema ao tentar abrir a conexão com a base de dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando e login
                try
                {
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        txNomeProd.Text = reader["nome"].ToString();
                        txTipoProd.Text = reader["tiposNome"].ToString();
                        string preco = reader["preco"].ToString();
                        txValorUnit.Text = preco.Remove(preco.Length - 2);

                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado",
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar comando",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
            form_inicial.Show();
        }

        private void txQtd_TextChanged(object sender, EventArgs e)
        {
            if (txQtd.Text != "")
            {
                double qtd = Convert.ToDouble(txQtd.Text);
                double preco_unit = Convert.ToDouble(txValorUnit.Text);

                txValorParcial.Text = (qtd * preco_unit).ToString();
            }
        }

        private void btConcluirCompra_Click(object sender, EventArgs e)
        {
            FormaDePagamento formPagamento = new FormaDePagamento();
            formPagamento.Show();
        }

        private void Carrinho_Shown(object sender, EventArgs e)
        {
            form_novacompra.Show();
        }
    }
}