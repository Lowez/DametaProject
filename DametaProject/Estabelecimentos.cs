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
    public partial class Estabelecimentos : Form
    {
        bool inserindo = false;
        string nomeEstabelecimento = "";
        public Estabelecimentos(bool isInserindo, string nome_estabelecimento = null)
        {
            InitializeComponent();
            this.inserindo = isInserindo;
            this.nomeEstabelecimento = nome_estabelecimento;
            AtualizaListaDeEstabelecimentos();
        }

        private void AtualizaListaDeEstabelecimentos()
        {
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);
        }

        private void Estabelecimentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.dtEstabelecimentos' table. You can move, or remove it, as needed.
            this.dtEstabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.dtEstabelecimentos);
            btLimpar_Click(sender, e);
            if (inserindo)
            {
                btAlterar.Enabled = false;
                btExcluir.Enabled = false;
                btConsultar.Enabled = false;
                btIncluir.Enabled = true;
                btLimpar.Enabled = true;
                txID.Enabled = false;
                label1.Enabled = false;
            }
            else
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btConsultar.Enabled = true;
                btIncluir.Enabled = false;
                btLimpar.Enabled = true;


                SqlConnection conn;
                SqlCommand comm;
                SqlDataReader reader;

                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                // Inicializa a conexão com o Banco de Dados
                conn = new SqlConnection(connectionString);

                comm = new SqlCommand(
                    "SELECT estab.id, estab.nome, estab.CEP, estab.nome_rua, estab.numero, estab.telefone, estab.cidades_id, cid.id, cid.nome AS cidNome " +
                    "FROM estabelecimentos AS estab " +
                    "INNER JOIN cidades AS cid ON cid.id = estab.cidades_id " +
                    "WHERE estab.nome = @nome", conn);

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = nomeEstabelecimento;

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
                            txID.Text = reader["id"].ToString();
                            txNome.Text = reader["nome"].ToString();
                            cbCidade.Text = reader["cidNome"].ToString();
                            txRua.Text = reader["nome_rua"].ToString();
                            mtxCEP.Text = reader["CEP"].ToString();
                            txNumero.Text = reader["numero"].ToString();
                            mtxTelefone.Text = reader["telefone"].ToString();
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
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.dameta_dbDataSet.cidades);
            AtualizaListaDeEstabelecimentos();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "INSERT INTO estabelecimento (nome, nome_rua, numero, telefone, CEP, cidades_id) " +
                "VALUES (@nome,@nome_rua, @numero, @telefone, @CEP, @cidades_id)", conn);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = txNome.Text;

            comm.Parameters.Add("@nome_rua", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome_rua"].Value = txRua.Text;

            comm.Parameters.Add("@numero", System.Data.SqlDbType.Int);
            comm.Parameters["@numero"].Value = Convert.ToInt32(txNumero.Text);

            comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;

            comm.Parameters.Add("@cidades_id", System.Data.SqlDbType.Int);
            comm.Parameters["@cidades_id"].Value = cbCidade.SelectedValue;

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
                    MessageBox.Show("Estabelecimento cadastrado com sucesso!",
                        "Registro Cadastrado!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                AtualizaListaDeEstabelecimentos();
                btLimpar_Click(sender, e);
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
                "UPDATE estabelecimentos SET nome=@nome, nome_rua=@nome_rua, numero = @numero, telefone = @telefone, CEP=@CEP, cidades_id=@cidades_id  " +
                "WHERE id = @id", conn);

            comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
            comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = txNome.Text;

            comm.Parameters.Add("@nome_rua", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome_rua"].Value = txRua.Text;

            comm.Parameters.Add("@numero", System.Data.SqlDbType.Int);
            comm.Parameters["@numero"].Value = Convert.ToInt32(txNumero.Text);

            comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;

            comm.Parameters.Add("@cidades_id", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@cidades_id"].Value = cbCidade.SelectedValue;

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
                    MessageBox.Show("Estabelecimento alterado com sucesso!",
                        "Registro Alterado!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            AtualizaListaDeEstabelecimentos();
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
                "DELETE FROM estabelecimentos " +
                "WHERE id = @id", conn);

            comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
            comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

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
                    MessageBox.Show("Estabelecimento excluído com sucesso!",
                        "Registro Excluído!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            AtualizaListaDeEstabelecimentos();
            btLimpar_Click(sender, e);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txID.Clear();
            txNome.Clear();
            txRua.Clear();
            mtxCEP.Clear();
            txNumero.Clear();
            mtxTelefone.Clear();
            cbCidade.Text = "";
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
                "SELECT estab.id, estab.nome, estab.CEP, estab.nome_rua, estab.numero, estab.telefone, estab.cidades_id, cid.id, cid.nome AS cidNome " +
                "FROM estabelecimentos AS estab " +
                "INNER JOIN cidades AS cid ON cid.id = estab.cidades_id " +
                "WHERE estab.id = @ID", conn);

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
                        txNome.Text = reader["nome"].ToString();
                        cbCidade.Text = reader["cidNome"].ToString();
                        txRua.Text = reader["nome_rua"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
                        txNumero.Text = reader["numero"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
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
    }
}
