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
    public partial class Fornecedores : Form
    {


        public Fornecedores()
        {
            InitializeComponent();
            AtualizaListaDeFornecedores();
        }

        public string camposVazios(string operacao = null)
        {

            if (operacao == "only_id")
            {
                if (txID.Text == "")
                {
                    return "Código do Fornecedor";
                }
            }
            else
            {
                if (operacao == "alterar")
                {
                    if (txID.Text == "")
                    {
                        return "Código do Fornecedor";
                    }
                    else
                    {
                        bool existe = ConsultarExistencia(Convert.ToInt32(txID.Text));
                        if (!existe)
                        {
                            MessageBox.Show("Fornecedor não existe no banco de dados!",
                          "Registro não existe",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                            return "nao existe";
                        }
                    }
                }

                if (txNome.Text == "")
                {
                    return "Nome do Fornecedor";
                }

                if (mtxTelefone.Text == "(  )     -")
                {
                    return "Telefone";
                }

                if (mtxCNPJ.Text == "   .   .   /    -")
                {
                    return "CNPJ";
                }
            }

            return "preenchido";
        }

        private void AtualizaListaDeFornecedores()
        {
            this.fornecedoresTableAdapter.Fill(this.dameta_dbDataSet.fornecedores);
        }


        private void Fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.produtos' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.dameta_dbDataSet.fornecedores);

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txID.Clear();
            txNome.Clear();
            txID.Focus();
            mtxCNPJ.Clear();
            mtxTelefone.Clear();
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
                "SELECT fornec.id " +
                "FROM fornecedores AS fornec " +
                "WHERE fornec.id = @ID", conn);

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
            "SELECT  id, nome, telefone, CNPJ " +
            "FROM fornecedores " +
            "WHERE id = @ID", conn);

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

                    // Se encontrou um fornecedor...
                    if (reader.Read())
                    {

                        txNome.Text = reader["nome"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                        mtxCNPJ.Text = reader["CNPJ"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não existe no banco de dados!",
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

            comm = new SqlCommand(
                "INSERT INTO fornecedores (nome, telefone, CNPJ) " +
                "VALUES (@nome, @telefone, @CNPJ)", conn);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = txNome.Text;

            comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CNPJ"].Value = mtxCNPJ.Text;

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
                    MessageBox.Show("Fornecedor cadastrado com sucesso!",
                          "Registro Cadastrado",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                }
                Fornecedores_Load(sender, e);
                btLimpar_Click(sender, e);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

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

                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand(

                    "UPDATE fornecedores SET nome=@nome, telefone = @telefone, CNPJ = @CNPJ " +
                    "WHERE id = @id", conn);

                comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
                comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = txNome.Text;

                comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@telefone"].Value = mtxTelefone.Text;

                comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CNPJ"].Value = mtxCNPJ.Text;

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
                        MessageBox.Show("Fornecedor alterado com sucesso!",
                            "Registro Alterado!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                Fornecedores_Load(sender, e);
                btLimpar_Click(sender, e);
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
                    "DELETE FROM fornecedores " +
                    "WHERE id = @id", conn);

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
                        MessageBox.Show("Fornecedor excluído com sucesso!",
                            "Registro Excluído!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Chama o mesmo método usado no botão Limpar
                        btLimpar_Click(sender, e);
                    }
                }

                Fornecedores_Load(sender, e);
                btLimpar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Funcionário não pode ser excluído porque não existe no banco de dados!",
                          "Registro não existe",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                "SELECT id, nome, telefone, CNPJ " +
                "FROM fornecedores " +
                "WHERE id=@id ", conn);


            // Recupera o registro do banco de dados a partir da chave primária 'Codigo'
            comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
            comm.Parameters["@id"].Value = ID;
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
                        txNome.Text = reader["nome"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                        mtxCNPJ.Text = reader["CNPJ"].ToString();
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

