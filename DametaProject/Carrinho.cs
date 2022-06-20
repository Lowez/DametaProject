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
        public static int cliente_id = 0;
        public static string cliente_nome = "";
        public static decimal preco_total = 0;

        WelcomeForm form_inicial;
        PremiumUserCheck form_premium;
        int qtdDeProdutos;
        decimal precoTotal;
        string nome_funcionario;
        int estabelecimento_id;
        bool bIsOperationOK = true;

        public Carrinho(string nome, int id, WelcomeForm form, bool is_new = false)
        {
            InitializeComponent();

            form_inicial = form;
            qtdDeProdutos = 0;
            precoTotal = 0;
            nome_funcionario = nome;
            estabelecimento_id = id;
        }

        private void callOnLoad()
        {
            form_premium = new PremiumUserCheck(this);

            // Adiciona o nome do  usuário que está logando no título do formulário
            this.Text = "Bem vindo(a) " + nome_funcionario;

            // Seta a data do DateTimePicker para a data atual
            dtpDataCompra.Value = DateTime.Now;
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void limpaForm()
        {
            txNomeProd.Text = "";
            txTipoProd.Text = "";
            txValorUnit.Text = "";
            txQtd.Text = "";
            txValorParcial.Text = "";
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

        private void btConcluirCompra_Click(object sender, EventArgs e)
        {
            if (dgvCarrinho.Rows.Count == 0)
            {
                MessageBox.Show("Impossível concluir uma compra vazia",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn;
                SqlCommand comm1;

                conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

                comm1 = new SqlCommand(
                    "INSERT INTO compras (created, preco_total, premium_usuario_id, estabelecimentos_id) " +
                    "VALUES (@data_compra, @preco_total, @premium_usuario_id, @estabelecimentos_id)", conn);

                precoTotal = Convert.ToDecimal(lblValorTotal.Text);

                comm1.Parameters.Add("@data_compra", SqlDbType.Date);
                comm1.Parameters["@data_compra"].Value = dtpDataCompra.Value;

                comm1.Parameters.Add("@preco_total", SqlDbType.Money);
                comm1.Parameters["@preco_total"].Value = precoTotal;

                if (cliente_id != 0)
                {
                    comm1 = new SqlCommand(
                    "INSERT INTO compras (created, preco_total, premium_usuarios_id, estabelecimentos_id) " +
                    "VALUES (@data_compra, @preco_total, @premium_usuario_id, @estabelecimentos_id)", conn);

                    precoTotal = Convert.ToDecimal(lblValorTotal.Text);

                    comm1.Parameters.Add("@data_compra", SqlDbType.Date);
                    comm1.Parameters["@data_compra"].Value = dtpDataCompra.Value;

                    comm1.Parameters.Add("@preco_total", SqlDbType.Money);
                    comm1.Parameters["@preco_total"].Value = precoTotal;

                    comm1.Parameters.Add("@premium_usuario_id", SqlDbType.Int);
                    comm1.Parameters["@premium_usuario_id"].Value = Convert.ToInt32(cliente_id);

                    comm1.Parameters.Add("@estabelecimentos_id", SqlDbType.Int);
                    comm1.Parameters["@estabelecimentos_id"].Value = 1;
                }
                else
                {
                    comm1 = new SqlCommand(
                    "INSERT INTO compras (created, preco_total, estabelecimentos_id) " +
                    "VALUES (@data_compra, @preco_total, @estabelecimentos_id)", conn);

                    precoTotal = Convert.ToDecimal(lblValorTotal.Text);

                    comm1.Parameters.Add("@data_compra", SqlDbType.Date);
                    comm1.Parameters["@data_compra"].Value = dtpDataCompra.Value;

                    comm1.Parameters.Add("@preco_total", SqlDbType.Money);
                    comm1.Parameters["@preco_total"].Value = precoTotal;

                    comm1.Parameters.Add("@estabelecimentos_id", SqlDbType.Int);
                    comm1.Parameters["@estabelecimentos_id"].Value = estabelecimento_id;
                }

                try
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        bIsOperationOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar conexão com a base de dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    try
                    {
                        comm1.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        bIsOperationOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar execurar o comando SQL.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close();
                }

                // Comando para inserção dos itens na tabela item_venda

                SqlCommand comm2;

                comm2 = new SqlCommand(
                    "INSERT INTO item_venda (qtd, preco_parcial, produtos_cod_produto, compras_id) " +
                    "VALUES (@qtd, @preco_parcial, @cod_produto, @compras_id)", conn);

                comm2.Parameters.Add("@qtd", SqlDbType.Int);
                comm2.Parameters.Add("@preco_parcial", SqlDbType.Money);
                comm2.Parameters.Add("@cod_produto", SqlDbType.Int);
                comm2.Parameters.Add("@compras_id", SqlDbType.Int);

                for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
                {
                    comm2.Parameters["@qtd"].Value = Convert.ToInt32(dgvCarrinho.Rows[i].Cells[2].Value);
                    comm2.Parameters["@preco_parcial"].Value = Convert.ToDecimal(dgvCarrinho.Rows[i].Cells[2].Value);
                    comm2.Parameters["@cod_produto"].Value = Convert.ToInt32(dgvCarrinho.Rows[i].Cells[0].Value);
                    comm2.Parameters["@compras_id"].Value = obterCodigoDeVenda(false);

                    try
                    {
                        try
                        {
                            conn.Open();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;

                            MessageBox.Show(error.Message,
                                "Erro ao tentar conexão com a base de dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }

                        try
                        {
                            comm2.ExecuteNonQuery();
                        }
                        catch (Exception error)
                        {
                            bIsOperationOK = false;

                            MessageBox.Show(error.Message,
                                "Erro ao tentar execurar o comando SQL.",
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

                if (bIsOperationOK)
                {
                    preco_total = Convert.ToDecimal(lblValorTotal.Text);

                    FormaDePagamento form_pagamento = new FormaDePagamento();
                    form_pagamento.Show();
                }
            }
        }
        public int obterCodigoDeVenda(bool bBuscarProximo)
        {
            string codigo = "";
            string sql = "";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

            if (bBuscarProximo == true)
                sql = "SELECT MAX(id)+1 AS 'compra_id' FROM compras";
            else
                sql = "SELECT MAX(id) AS 'compra_id' FROM compras";

            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                codigo = reader["compra_id"].ToString();
            }
            conn.Close();
            return Convert.ToInt32(codigo);
        }

        private void Carrinho_Shown(object sender, EventArgs e)
        {
            form_premium.Show();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            // Adcionar uma nova linha ao carrinho
            dgvCarrinho.Rows.Add();

            // Adiciona um produto no carrinho
            dgvCarrinho.Rows[qtdDeProdutos].Cells[0].Value = txCodigoProd.Text;
            dgvCarrinho.Rows[qtdDeProdutos].Cells[1].Value = txNomeProd.Text;
            dgvCarrinho.Rows[qtdDeProdutos].Cells[2].Value = txQtd.Text;
            dgvCarrinho.Rows[qtdDeProdutos].Cells[3].Value = txValorUnit.Text;

            decimal precoParcial = Convert.ToDecimal(txValorUnit.Text) * Convert.ToDecimal(txQtd.Text);
            dgvCarrinho.Rows[qtdDeProdutos].Cells[4].Value = Convert.ToString(precoParcial);

            // Recalcula o Preço Total
            precoTotal += precoParcial;
            lblValorTotal.Text = Convert.ToString(precoTotal);

            // Incrementa quantidade de itens no carrinho
            qtdDeProdutos++;
            lblTotalItens.Text = qtdDeProdutos.ToString();

            limpaForm();
            txCodigoProd.Text = "";
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string produto_selecionado = txCodigoProd.Text;
            bool encontrou = false;

            for (int i = 0; i < qtdDeProdutos; i++)
            {
                if (dgvCarrinho.Rows[i].Cells[0].Value.ToString() == produto_selecionado)
                {
                    string nome_produto = dgvCarrinho.Rows[i].Cells[1].Value.ToString();
                    string qtd = dgvCarrinho.Rows[i].Cells[2].Value.ToString();
                    string valor_unit = dgvCarrinho.Rows[i].Cells[3].Value.ToString();
                    string valor_parcial = dgvCarrinho.Rows[i].Cells[4].Value.ToString();

                    // Subtrai o valor do item do carrinho com o Preço Total da venda
                    decimal preco_parcial = Convert.ToDecimal(valor_unit) * Convert.ToDecimal(qtd);
                    precoTotal -= preco_parcial;
                    lblValorTotal.Text = precoTotal.ToString();

                    // Remove o item do carrinho
                    dgvCarrinho.Rows.RemoveAt(i);

                    // Subtrai o valor dos itens do carrinho
                    qtdDeProdutos--;
                    lblTotalItens.Text = qtdDeProdutos.ToString();

                    encontrou = true;
                    break;
                }
            }

            if (!encontrou)
            {
                MessageBox.Show("Este produto não foi adicionado ao carrinho.",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txValorUnit_TextChanged(object sender, EventArgs e)
        {
            if (txValorUnit.Text != "")
            {
                txQtd.ReadOnly = false;
            }
        }

        private void txQtd_TextChanged(object sender, EventArgs e)
        {
            if (txQtd.Text != "")
            {
                decimal qtd = Convert.ToDecimal(txQtd.Text);
                decimal preco_unit = Convert.ToDecimal(txValorUnit.Text);

                txValorParcial.Text = ((qtd * preco_unit)).ToString();

                btAdicionar.Enabled = true;
                btRemover.Enabled = true;
            } else
            {
                txValorParcial.Text = "";

                btAdicionar.Enabled = false;
            }
        }

        private void txCodigoProd_TextChanged(object sender, EventArgs e)
        {
            limpaForm();
            btRemover.Enabled = true;
        }

        private void btNovaCompra_Click(object sender, EventArgs e)
        {
            limpaForm();
            txCodigoProd.Text = "";

            dgvCarrinho.Rows.Clear();
            dgvCarrinho.Refresh();

            qtdDeProdutos = 0;
            precoTotal = 0;

            lblTotalItens.Text = qtdDeProdutos.ToString();
            lblValorTotal.Text = precoTotal.ToString();

            PremiumUserCheck premiumUserCheck = new PremiumUserCheck(this);
            premiumUserCheck.Show();
        }
    }
}