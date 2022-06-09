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
                "SELECT Pro.cod_produto, Pro.produtoNome, Pro.preco, Pro.estoque_id, Pro.fornecedores_id, Pro.tipo_produtos_id " +
                "Est.id, Est.qtd, For.id, For.fornecedorNome, Tipo.id, Tipo.tipoNome " +
                "FROM Produtos AS Pro " +
                "INNER JOIN estoque AS Est " +
                "INNER JOIN fornecedores AS For " +
                "INNER JOIN tipo_produtos AS Tipo " +
                "ON Pro.id = @ID AND Est.id = Pro.estoque_id AND For.id = Pro.fornecedores_id AND Tipo.id = Pro.tipo_produtos_id", conn);

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
                        txNome.Text = reader["produtoNome"].ToString();
                        txPrecoUnit.Text = reader["preco"].ToString();
                        txQtdEstoque.Text = reader["qtd"].ToString();
                        cbFornecedor.Text = reader["fornecedorNome"].ToString();
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

        private void btIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "INSERT INTO Clientes (nome, nascimento, CPF, telefone, CEP, estados_id, cidades_id, generos_id) " +
                "VALUES (@nome, @nascimento, @CPF, @telefone, @CEP, @estados_id, @cidades_id, @generos_id)", conn);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = txNome.Text;

            comm.Parameters.Add("@nascimento", System.Data.SqlDbType.Date);
            comm.Parameters["@nascimento"].Value = dtpDataNasc.Value;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@telefone"].Value = txNome.Text;

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;

            comm.Parameters.Add("@estado_id", System.Data.SqlDbType.Int);
            comm.Parameters["@estado_id"].Value = Convert.ToInt32(cbCidade.SelectedValue);

            comm.Parameters.Add("@cidade_id", System.Data.SqlDbType.Int);
            comm.Parameters["@cidade_id"].Value = Convert.ToInt32(cbCidade.SelectedValue);

            comm.Parameters.Add("@genero_id", System.Data.SqlDbType.Int);
            comm.Parameters["@genero_id"].Value = Convert.ToInt32(cbGenero.SelectedValue);


            try
            {
                try
                {
                    // Abre a conexão com o Banco de Dados
                    conn.Open();
                }
                catch (Exception ex)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(ex.Message,
                        "Erro ao tentar abrir o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    bIsOperationOK = false;
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

                if (bIsOperationOK == true)
                {
                    MessageBox.Show("Cliente Cadastrado com sucesso!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    AtualizaListaDeClientes();
                    btLimpar_Click(sender, e);
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE Clientes SET Nome=@Nome, CPF=@CPF, ID_Cidade=@ID_Cidade " +
                "WHERE ID_Cliente = @ID_Cliente", conn);

            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@ID_Cidade", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cidade"].Value = Convert.ToInt32(cbCidade.SelectedValue.ToString());

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
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();

                if (bIsOperationOK == true)
                {
                    MessageBox.Show("Registro Alterado!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            AtualizaListaDeClientes();
            btLimpar_Click(sender, e);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE Clientes SET Nome=@Nome, CPF=@CPF, ID_Cidade=@ID_Cidade " +
                "WHERE ID_Cliente = @ID_Cliente", conn);

            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@ID_Cidade", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cidade"].Value = Convert.ToInt32(cbCidade.SelectedValue.ToString());

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
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();

                if (bIsOperationOK == true)
                {
                    MessageBox.Show("Registro Alterado!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            AtualizaListaDeClientes();
            btLimpar_Click(sender, e);
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.dameta_dbDataSet.produtos);

        }
    }
}
