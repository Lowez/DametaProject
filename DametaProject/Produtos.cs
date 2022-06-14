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
            txPrecoUnit.Clear();
            txQtdEstoque.Clear();
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
               "INSERT INTO produtos (nome, preco, tipo_produtos_id, fornecedores_id, estoque_id) " +
               "VALUES (@nome, @preco, @tipo_produtos_id, @fornecedores_id, @estoque_id)", conn);

           comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
           comm.Parameters["@nome"].Value = txNome.Text;

           comm.Parameters.Add("@preco", System.Data.SqlDbType.Money);
           comm.Parameters["@preco"].Value = Convert.ToDecimal(txPrecoUnit.Text);

           comm.Parameters.Add("@tipo_produtos_id", System.Data.SqlDbType.Int);
           comm.Parameters["@tipo_produtos_id"].Value = Convert.ToInt32(cbTipo.SelectedValue);

           comm.Parameters.Add("@fornecedores_id", System.Data.SqlDbType.Int);
           comm.Parameters["@fornecedores_id"].Value = Convert.ToInt32(cbFornecedor.SelectedValue);

           comm.Parameters.Add("@estoque_id", System.Data.SqlDbType.Int);
           comm.Parameters["@estoque_id"].Value = Convert.ToInt32(txQtdEstoque.Text);




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

                   Produtos_Load();
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
                    
                       "UPDATE produtos SET nome=@nome, preco=@preco, tipo_produtos_id=@tipo_produtos_id, fornecedores_id=@fornecedores_id, estoque_id=@estoque_id " +
                       "WHERE id = @id", conn);

                   comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
                   comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

                   comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                   comm.Parameters["@nome"].Value = txNome.Text;

                   comm.Parameters.Add("@preco", System.Data.SqlDbType.Money);
                   comm.Parameters["@preco"].Value = Convert.ToDecimal(txPrecoUnit.Text); 

                   comm.Parameters.Add("@tipo_produtos_id", System.Data.SqlDbType.Int);
                   comm.Parameters["@tipo_produtos_id"].Value = Convert.ToInt32(cbTipo.SelectedValue.ToString());

                   comm.Parameters.Add("@fornecedores_id", System.Data.SqlDbType.Int);
                   comm.Parameters["@fornecedores_id"].Value = Convert.ToInt32(cbTipo.SelectedValue.ToString());
                   
                   comm.Parameters.Add("@estoque_id", System.Data.SqlDbType.Int);
                   comm.Parameters["@estoque_id"].Value = Convert.ToInt32(cbTipo.SelectedValue.ToString());

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

                   Produtos_Load();
                   btLimpar_Click(sender, e);
               }

               private void btExcluir_Click(object sender, EventArgs e)
               {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            // Lê a string que representa os dados da conexão, 
            // contidos no arquivo app.config
            string connectionString = Properties.Settings.Default.CARRINHOConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            // Cria um comando SQL para exclusão de dados da tabela
            comm = new SqlCommand(
                "DELETE FROM Produtos " +
                "WHERE ID_Produto = @ID_Produto", conn);

            // Apaga o registro do banco de dados a partir da chave primária 'Codigo'
            comm.Parameters.Add("@ID_Produto", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Produto"].Value = Convert.ToInt32(txID.Text);

            // Usa tratamento de excessão para se certificar que a operação
            // foi bem executada. Senão, exibe as mensagens de erro para o usuário.
            try
            {
                try
                {
                    // Abre a Conexão com o BD
                    conn.Open();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    // Executa o Commando SQL
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(error.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                // Fecha a Conexão com o BD
                conn.Close();

                if (bIsOperationOK == true)
                {
                    // Chama Função que atualiza os dados no DataGridView
                    MessageBox.Show("Registro Excluído!",
                        "Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chama o mesmo método usado no botão Limpar
                    btLimparForm_Click(sender, e);
                }
            }

            Produtos_Load();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            // Lê a string que representa os dados da conexão, 
            // contidos no arquivo app.config
            string connectionString = Properties.Settings.Default.CARRINHOConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            // Cria um comando SQL para seleção de dados na tabela
            comm = new SqlCommand(
                "SELECT ID_Produto, Descricao, PrecoUnit, Categoria " +
                "FROM Produtos " +
                "WHERE ID_Produto=@ID_Produto ", conn);


            // Recupera o registro do banco de dados a partir da chave primária 'Codigo'
            comm.Parameters.Add("@ID_Produto", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Produto"].Value = ID;
            txID.Text = Convert.ToString(ID);

            try
            {
                try
                {
                    // Abre a Conexão com o BD
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    // Executa o Commando SQL
                    reader = comm.ExecuteReader();

                    // Lê os dados do BD e passa para os campos do Form
                    if (reader.Read())
                    {
                        txDescricao.Text = reader["Descricao"].ToString();
                        //txPrecoUnit.Text = String.Format("{0:C2}", reader["PrecoUnit"]);
                        txPrecoUnit.Text = reader["PrecoUnit"].ToString();
                        cbCategoria.Text = reader["Categoria"].ToString();

                    }

                    // Fecha o reader
                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                // Termina a conexão com o banco de dados
                conn.Close();
            }
        }

        
        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.dameta_dbDataSet.produtos);

        }
    }
}
