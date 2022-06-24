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

        private bool ConsultarExistencia(int id)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            bool existe = false;
            int ID = id;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT prod.cod_produto " +
                "FROM produtos AS prod " +
                "WHERE prod.cod_produto = @ID", conn);

            comm.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            comm.Parameters["@ID"].Value = Convert.ToInt32(ID);

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
                        existe = true;
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
            return existe;
        }

        public string camposVazios(string operacao = null)
        {

            if (operacao == "only_id")
            {
                if (txID.Text == "")
                {
                    return "Código de Produto";
                }
            }
            else
            {
                if (txID.Text == "")
                {
                    return "Código de Produto";
                }
                if (operacao == "alterar")
                {
                    if (txID.Text == "")
                    {
                        bool existe = ConsultarExistencia(Convert.ToInt32(txID.Text));
                        if (!existe)
                        {
                            MessageBox.Show("Funcionario não existe no banco de dados!",
                          "Registro não existe",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                            return "nao existe";
                        }
                    }
                }
                if (txNome.Text == "")
                {
                    return "Nome do Produto";
                }

                if (txPrecoUnit.Text == "")
                {
                    return "Preço do Unitário";
                }

                if (txQtdEstoque.Text == "")
                {
                    return "Quantidade em Estoque";
                }

                if (cbFornecedor.Text == "")
                {
                    return "Fornecedor";
                }

                if (cbTipo.Text == "")
                {
                    return "Tipo de Produto";
                }
            }

            return "preenchido";
        }

        public int obterIdEstoque(bool bBuscarProximo)
        {
            string codigo = "";
            string sql = "";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

            if (bBuscarProximo == true)
                sql = "SELECT MAX(id)+1 AS 'estoque_id' FROM estoque";
            else
                sql = "SELECT MAX(id) AS 'estoque_id' FROM estoque";

            SqlCommand comm = new SqlCommand(sql.ToString(), conn);
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                codigo = reader["estoque_id"].ToString();
            }
            conn.Close();
            return Convert.ToInt32(codigo);
        }

        private void Produtos_Load_2(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.dtProduto' table. You can move, or remove it, as needed.
            this.dtProdutoTableAdapter.Fill(this.dameta_dbDataSet.dtProduto);
            this.fornecedoresTableAdapter.Fill(this.dameta_dbDataSet.fornecedores);
            this.tipo_produtosTableAdapter.Fill(this.dameta_dbDataSet.tipo_produtos);
        }

        private void btLimparForm_Click(object sender, EventArgs e)
        {
            txID.Clear();
            txNome.Clear();
            txPrecoUnit.Clear();
            cbTipo.Text = "";
            cbFornecedor.Text = "";
            txQtdEstoque.Clear();
            txID.Focus();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            bool bIsOperationOK = true;
            bool pegou_estoque_id = true;
            int estoque_id = 0;

            string campoVazio = (camposVazios("alterar"));
            if (campoVazio != "nao existe")
            {
                if (campoVazio != "preenchido")
                {
                    MessageBox.Show("Você deve preencher: " + campoVazio,
                        "Informações incompletas!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bIsOperationOK = false;
                    return;
                }
                bool existe = ConsultarExistencia(Convert.ToInt32(txID.Text));

                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                conn = new SqlConnection(connectionString);

                // Pega o ID do estoque do produto
                SqlCommand commEstoque_id = new SqlCommand(
                    "SELECT cod_produto, estoque_id FROM produtos " +
                    "WHERE cod_produto = @id", conn
                    );

                commEstoque_id.Parameters.Add("@id", System.Data.SqlDbType.Int);
                commEstoque_id.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

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

                    try
                    {
                        reader = commEstoque_id.ExecuteReader();

                        if (reader.Read())
                        {
                            estoque_id = Convert.ToInt32(reader["estoque_id"]);
                        }
                        else
                        {
                            MessageBox.Show("Algo inesperado ocorreu.",
                            "Erro!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                            pegou_estoque_id = false;
                        }

                        reader.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar comando SQL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close();
                }

                if (!pegou_estoque_id)
                {
                    return;
                }

                // Altera a quantidade do produto em seu estoque
                SqlCommand commQtdEstoque = new SqlCommand(
                    "UPDATE estoque SET qtd = @qtd " +
                    "WHERE id = @estoque_id", conn
                    );

                commQtdEstoque.Parameters.Add("@qtd", SqlDbType.Int);
                commQtdEstoque.Parameters["@qtd"].Value = Convert.ToInt32(txQtdEstoque.Text);

                commQtdEstoque.Parameters.Add("@estoque_id", SqlDbType.Int);
                commQtdEstoque.Parameters["@estoque_id"].Value = estoque_id;

                try
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao abrir conexão com o Banco de Dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    try
                    {
                        commQtdEstoque.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL2",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        pegou_estoque_id = false;
                    }
                }
                catch { }
                finally
                {
                    conn.Close();
                }

                if (!pegou_estoque_id)
                {
                    return;
                }

                comm = new SqlCommand(

                   "UPDATE produtos SET cod_produto = @id, nome=@nome, preco=@preco, tipo_produtos_id=@tipo_produtos_id, fornecedores_id=@fornecedores_id " +
                   "WHERE cod_produto = @id", conn);

                comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
                comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = txNome.Text;

                comm.Parameters.Add("@preco", System.Data.SqlDbType.Money);
                comm.Parameters["@preco"].Value = Convert.ToDecimal(txPrecoUnit.Text);

                comm.Parameters.Add("@tipo_produtos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@tipo_produtos_id"].Value = Convert.ToInt32(cbTipo.SelectedValue.ToString());

                comm.Parameters.Add("@fornecedores_id", System.Data.SqlDbType.Int);
                comm.Parameters["@fornecedores_id"].Value = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());

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
                            "Erro ao tentar executar o comando SQL3",
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
                        MessageBox.Show("Produto alterado com sucesso!",
                           "Registro Alterado!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    }
                }

                Produtos_Load_2(sender, e);
                btLimparForm_Click(sender, e);
            }
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            if (!(camposVazios() == "preenchido"))
            {
                MessageBox.Show("Você deve preencher: " + camposVazios(),
                    "Informações incompletas!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            // Cria o estoque
            SqlCommand commEstoque = new SqlCommand(
                "INSERT INTO estoque (qtd) " +
                "VALUES (@qtd)", conn
                );

            commEstoque.Parameters.Add("@qtd", SqlDbType.Int);
            commEstoque.Parameters["@qtd"].Value = Convert.ToInt32(txQtdEstoque.Text);

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
                    commEstoque.ExecuteNonQuery();
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

            comm = new SqlCommand(
                "INSERT INTO produtos (cod_produto, nome, preco, tipo_produtos_id, fornecedores_id, estoque_id) " +
                "VALUES (@id, @nome, @preco, @tipo_produtos_id, @fornecedores_id, @estoque_id)", conn);

            comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
            comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = txNome.Text;

            comm.Parameters.Add("@preco", System.Data.SqlDbType.Money);
            comm.Parameters["@preco"].Value = Convert.ToDecimal(txPrecoUnit.Text);

            comm.Parameters.Add("@tipo_produtos_id", System.Data.SqlDbType.Int);
            comm.Parameters["@tipo_produtos_id"].Value = Convert.ToInt32(cbTipo.SelectedValue.ToString());

            comm.Parameters.Add("@fornecedores_id", System.Data.SqlDbType.Int);
            comm.Parameters["@fornecedores_id"].Value = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());

            comm.Parameters.Add("@estoque_id", System.Data.SqlDbType.Int);
            comm.Parameters["@estoque_id"].Value = obterIdEstoque(false);


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
                    MessageBox.Show("Produto cadastro com sucesso!",
                           "Registro Alterado!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    Produtos_Load_2(sender, e);
                    btLimparForm_Click(sender, e);

                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            if (!(camposVazios("only_id") == "preenchido"))
            {
                MessageBox.Show("Você deve preencher: " + camposVazios("only_id"),
                    "Informações incompletas!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            bool existe = ConsultarExistencia(Convert.ToInt32(txID.Text));
            if (existe)
            {

                // Lê a string que representa os dados da conexão, 
                // contidos no arquivo app.config
                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                // Inicializa a conexão com o Banco de Dados
                conn = new SqlConnection(connectionString);

                // Cria um comando SQL para exclusão de dados da tabela
                comm = new SqlCommand(
                    "DELETE FROM Produtos " +
                    "WHERE cod_produto = @id", conn);

                // Apaga o registro do banco de dados a partir da chave primária 'Codigo'
                comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
                comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

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
                        MessageBox.Show("Produto excluído com sucesso!",
                           "Registro Alterado!",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

                        // Chama o mesmo método usado no botão Limpar
                        btLimparForm_Click(sender, e);

                    }
                }

                Produtos_Load_2(sender, e);
                btLimparForm_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Produto não pode ser excluído porque não existe no banco de dados!",
                           "Registro não existe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            if (!(camposVazios("only_id") == "preenchido"))
            {
                MessageBox.Show("Você deve preencher: " + camposVazios("only_id"),
                    "Informações incompletas!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

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
                    else
                    {
                        MessageBox.Show("Produto não existe no banco de dados!",
                           "Registro não existe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                SqlConnection conn;
                SqlCommand comm;
                SqlDataReader reader;

                // Lê a string que representa os dados da conexão, 
                // contidos no arquivo app.config
                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                // Inicializa a conexão com o Banco de Dados
                conn = new SqlConnection(connectionString);

                // Cria um comando SQL para seleção de dados na tabela
                comm = new SqlCommand(
                    "SELECT prod.cod_produto, prod.nome AS nome, prod.preco, prod.tipo_produtos_id , prod.fornecedores_id, " +
                    "prod.estoque_id, estoq.id, estoq.qtd AS qtd, tipprod.id, tipprod.nome AS tipnome, forn.id ,forn.nome AS fornnome " +
                    "FROM produtos AS prod " +
                    "INNER JOIN estoque AS estoq ON estoq.id = prod.estoque_id " +
                    "INNER JOIN fornecedores AS forn ON forn.id = prod.fornecedores_id " +
                    "INNER JOIN tipo_produtos AS tipprod ON tipprod.id = prod.tipo_produtos_id " +
                    "WHERE cod_produto=@ID_Produto ", conn);


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
                            string preco = reader["preco"].ToString();
                            preco = preco.Remove(preco.Length - 2);
                            txNome.Text = reader["nome"].ToString();
                            txPrecoUnit.Text = preco;
                            txQtdEstoque.Text = reader["qtd"].ToString();
                            cbFornecedor.Text = reader["fornnome"].ToString();
                            cbTipo.Text = reader["tipnome"].ToString();

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
        }
    }
}
