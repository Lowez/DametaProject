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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void AtualizaListaDeClientes()
        {
            this.premium_usuariosTableAdapter.Fill(this.dameta_dbDataSet.premium_usuarios);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet3.cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.dameta_dbDataSet3.cidades);
            // TODO: This line of code loads data into the 'dameta_dbDataSet2.cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.dameta_dbDataSet2.cidades);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.dameta_dbDataSet.Estados);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.dameta_dbDataSet.cidades);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.dameta_dbDataSet.generos);
            // TODO: esta linha de código carrega dados na tabela 'dameta_dbDataSet.premium_usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.premium_usuariosTableAdapter.Fill(this.dameta_dbDataSet.premium_usuarios);

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

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT Cli.id, Cli.nome as clienteNome, Cli.nascimento, Cli.CPF, Cli.telefone, Cli.CEP, Cli.cidades_id, Cli.generos_id, Cli.telefone, " +
                "Cid.id, Cid.nome as cidNome, Cid.UF, " +
                "Gen.Nome as genNome FROM premium_usuarios AS Cli " +
                "INNER JOIN Cidades AS Cid ON Cid.id = Cli.cidades_id " +
                "INNER JOIN Generos AS Gen " +
                "ON Gen.id = Cli.generos_id " +
                "WHERE Cli.id = 1", conn);

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
                        txNome.Text = reader["clienteNome"].ToString();
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                        cbGenero.Text = reader["genNome"].ToString();
                        cbCidade.Text = reader["cidNome"].ToString();
                        cbUF.Text = reader["UF"].ToString();
                        dtpDataNasc.Text = reader["nascimento"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE premium_usuarios SET nome=@nome, CPF=@CPF, cidades_id=@cidades_id " +
                "WHERE ID_Cliente = @ID_Cliente", conn);

            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@cidades_id", System.Data.SqlDbType.Int);
            comm.Parameters["@cidades_id"].Value = Convert.ToInt32(cbCidade.SelectedValue.ToString());

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

  

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txID.Clear();
            txNome.Clear();
            mtxCPF.Clear();
            cbCidade.Text = "";
            cbUF.Text = "";
            txID.Focus();
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE Clientes SET Nome=@Nome, CPF=@CPF, cidades_id=@cidades_id " +
                "WHERE ID_Cliente = @ID_Cliente", conn);

            comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
            comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nome"].Value = txNome.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@cidades_id", System.Data.SqlDbType.Int);
            comm.Parameters["@cidades_id"].Value = Convert.ToInt32(cbCidade.SelectedValue.ToString());

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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cidadesTableAdapter.Fill(this.dameta_dbDataSet.cidades);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cidadesTableAdapter.Fill(this.dameta_dbDataSet.cidades);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
