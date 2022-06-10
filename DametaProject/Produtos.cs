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

namespace DametaProject
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
            "SELECT pro.cod_produto, pro.nome as produtoNome, pro.preco, pro.estoque_id, pro.fornecedores_id, pro.tipo_produtos_id, est.id, " +
            "est.qtd, forn.id, forn.nome as fornecedoresNome, Tipo.id, Tipo.nome as tipoNome " +
            "FROM produtos AS pro " +
                "INNER JOIN estoque AS Est  ON Est.id = pro.estoque_id " +
                "INNER JOIN fornecedores AS Forn  ON Forn.id = pro.fornecedores_id " +
                "INNER JOIN tipo_produtos AS Tipo  ON Tipo.id = pro.tipo_produtos_id " +
                "WHERE pro.cod_produto = @ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = Convert.ToInt32(txID.Text);

            try
            {
                try
                {
                    // Abre a conexão com o Banco de Dados
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    // Executa o comando SQL
                    reader = comm.ExecuteReader();

                    // Se encontrou um cliente...
                    if (reader.Read())
                    {
                        string preco = reader["preco"].ToString();
                        preco = preco.Remove(preco.Length - 2);
                        Console.WriteLine(preco);
                        txNome.Text = reader["produtoNome"].ToString();
                        txPrecoUnit.Text = preco;
                        txQtdEstoque.Text = reader["qtd"].ToString();
                        cbFornecedor.Text = reader["fornecedoresNome"].ToString();
                        cbTipo.Text = reader["tipoNome"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Erro ao tentar executar o comando SQL.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                // Fecha a conexão com o Bando de Dados
                conn.Close();
            }
        }

        private void btLimparForm_Click(object sender, EventArgs e)
        {
            txID.Clear();
            txNome.Clear();
            cbTipo.Text = "";
            cbFornecedor.Text = "";
            txID.Focus();
        }

        //private void btIncluir_Click(object sender, EventArgs e)
        //{
        //    SqlConnection conn;
        //    SqlCommand comm;
        //    bool bIsOperationOK = true;

        //    string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

        //    conn = new SqlConnection(connectionString);

        //    comm = new SqlCommand(
        //        "INSERT INTO produtos (produtoNome, preco, tipo_produtos_id, fornecedores_id, qtd) " +
        //        "VALUES (@produtoNome, @preco, @tipo_produtos_id, @fornecedores_id, @qtd)", conn);

        //    comm.Parameters.Add("@produtoNome", System.Data.SqlDbType.NVarChar);
        //    comm.Parameters["@produtoNome"].Value = txNome.Text;

        //    comm.Parameters.Add("@preco", System.Data.SqlDbType.Date);
        //    comm.Parameters["@preco"].Value = txPrecoUnit.Text;

        //    comm.Parameters.Add("@tipo_produtos_id", System.Data.SqlDbType.Int);
        //    comm.Parameters["@tipo_produtos_id"].Value = Convert.ToInt32(cbTipo.SelectedValue);

        //    comm.Parameters.Add("@fornecedores_id", System.Data.SqlDbType.Int);
        //    comm.Parameters["@fornecedores_id"].Value = Convert.ToInt32(cbFornecedor.SelectedValue);

        //    comm.Parameters.Add("@estoque_id", System.Data.SqlDbType.Int);
        //    comm.Parameters["@estoque_id"].Value = Convert.ToInt32(cbFornecedor.SelectedValue);




        //    try
        //    {
        //        try
        //        {
        //            // Abre a conexão com o Banco de Dados
        //            conn.Open();
        //        }
        //        catch (Exception ex)
        //        {
        //            bIsOperationOK = false;
        //            MessageBox.Show(ex.Message,
        //                "Erro ao tentar abrir o Banco de Dados",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);
        //        }

        //        try
        //        {
        //            comm.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            bIsOperationOK = false;
        //            MessageBox.Show(ex.Message,
        //                "Erro ao tentar executar o comando SQL.",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);
        //        }
        //    }
        //    catch { }
        //    finally
        //    {
        //        // Fecha a conexão com o Bando de Dados
        //        conn.Close();

        //        if (bIsOperationOK == true)
        //        {
        //            MessageBox.Show("Cliente Cadastrado com sucesso!",
        //                "INSERT",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Information);

        //            AtualizaListaDeClientes();
        //            btLimpar_Click(sender, e);
        //        }
        //    }
        //}

        //        private void btAlterar_Click(object sender, EventArgs e)
        //        {
        //            SqlConnection conn;
        //            SqlCommand comm;
        //            bool bIsOperationOK = true;

        //            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

        //            conn = new SqlConnection(connectionString);

        //            comm = new SqlCommand(
        //                "UPDATE Clientes SET Nome=@Nome, CPF=@CPF, ID_Cidade=@ID_Cidade " +
        //                "WHERE ID_Cliente = @ID_Cliente", conn);

        //            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
        //            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txID.Text);

        //            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
        //            comm.Parameters["@Nome"].Value = txNome.Text;

        //            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
        //            comm.Parameters["@CPF"].Value = mtxCPF.Text;

        //            comm.Parameters.Add("@ID_Cidade", System.Data.SqlDbType.Int);
        //            comm.Parameters["@ID_Cidade"].Value = Convert.ToInt32(cbCidade.SelectedValue.ToString());

        //            try
        //            {
        //                try
        //                {
        //                    conn.Open();
        //                }
        //                catch (Exception error)
        //                {
        //                    bIsOperationOK = false;
        //                    MessageBox.Show(error.Message,
        //                        "Erro ao abrir conexão com o Banco de Dados",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //                }

        //                try
        //                {
        //                    comm.ExecuteNonQuery();
        //                }
        //                catch (Exception error)
        //                {
        //                    bIsOperationOK = false;
        //                    MessageBox.Show(error.Message,
        //                        "Erro ao tentar executar o comando SQL",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //                }
        //            }
        //            catch { }
        //            finally
        //            {
        //                conn.Close();

        //                if (bIsOperationOK == true)
        //                {
        //                    MessageBox.Show("Registro Alterado!",
        //                        "UPDATE",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Information);
        //                }
        //            }

        //            AtualizaListaDeClientes();
        //            btLimpar_Click(sender, e);
        //        }

        //        private void btExcluir_Click(object sender, EventArgs e)
        //        {
        //            SqlConnection conn;
        //            SqlCommand comm;
        //            bool bIsOperationOK = true;

        //            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

        //            conn = new SqlConnection(connectionString);

        //            comm = new SqlCommand(
        //                "UPDATE Clientes SET Nome=@Nome, CPF=@CPF, ID_Cidade=@ID_Cidade " +
        //                "WHERE ID_Cliente = @ID_Cliente", conn);

        //            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
        //            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txID.Text);

        //            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
        //            comm.Parameters["@Nome"].Value = txNome.Text;

        //            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
        //            comm.Parameters["@CPF"].Value = mtxCPF.Text;

        //            comm.Parameters.Add("@ID_Cidade", System.Data.SqlDbType.Int);
        //            comm.Parameters["@ID_Cidade"].Value = Convert.ToInt32(cbCidade.SelectedValue.ToString());

        //            try
        //            {
        //                try
        //                {
        //                    conn.Open();
        //                }
        //                catch (Exception error)
        //                {
        //                    bIsOperationOK = false;
        //                    MessageBox.Show(error.Message,
        //                        "Erro ao abrir conexão com o Banco de Dados",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //                }

        //                try
        //                {
        //                    comm.ExecuteNonQuery();
        //                }
        //                catch (Exception error)
        //                {
        //                    bIsOperationOK = false;
        //                    MessageBox.Show(error.Message,
        //                        "Erro ao tentar executar o comando SQL",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //                }
        //            }
        //            catch { }
        //            finally
        //            {
        //                conn.Close();

        //                if (bIsOperationOK == true)
        //                {
        //                    MessageBox.Show("Registro Alterado!",
        //                        "UPDATE",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Information);
        //                }
        //            }

        //            AtualizaListaDeClientes();
        //            btLimpar_Click(sender, e);
        //        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.dameta_dbDataSet.produtos);

        }
    }
}
