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
                "SELECT cli.id " +
                "FROM premium_usuarios AS cli " +
                "WHERE cli.id = @ID", conn);

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
                    return "Código do Cliente";
                }
            }
            else
            {
                if (operacao == "alterar")
                {
                    if (txID.Text == "")
                    {
                        return "Código do Cliente";
                    }
                    else
                    {
                        bool existe = ConsultarExistencia(Convert.ToInt32(txID.Text));
                        if (!existe)
                        {
                            MessageBox.Show("Cliente não existe no banco de dados!",
                          "Registro não existe",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                            return "nao existe";
                        }
                    }
                }

                if (txNome.Text == "")
                {
                    return "Nome do Cliente";
                }

                if (mtxCPF.Text == "   .   .   -")
                {
                    return "CPF";
                }

                if (dtpDataNasc.Value == null)
                {
                    return "Data de Nascimento";
                }

                if (mtxTelefone.Text == "(  )     -")
                {
                    return "Telefone";
                }

                if (cbGenero.Text == "")
                {
                    return "Gênero";
                }

                if (mtxCEP.Text == "     -")
                {
                    return "CEP";
                }

                if (cbUF.Text == "")
                {
                    return "UF";
                }

                if (cbCidade.Text == "")
                {
                    return "Cidade";
                }
            }

            return "preenchido";
        }

        private void AtualizaListaDeClientes()
        {
            this.premium_usuariosTableAdapter.Fill(this.dameta_dbDataSet.premium_usuarios);
            this.dtClientesTableAdapter.Fill(this.dameta_dbDataSet.dtClientes);

        }

        private void filtrarCidades(bool flag = true)
        {
            cbCidade.Items.Clear();
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT nome FROM cidades WHERE UF = @UF", conn);
            conn.Open();

            comm.Parameters.Add("@UF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@UF"].Value = Convert.ToString(cbUF.SelectedValue);


            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                cbCidade.Items.Add(reader["nome"]);
                if (flag)
                {
                    cbCidade.Text = reader["nome"].ToString();
                }
                flag = false;
            }

            reader.Close();
            conn.Close();
        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarCidades();
        }

        private int procurarCidade()
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT cid.id, cid.nome " +
                "FROM cidades AS cid " +
                "WHERE cid.nome = @nome", conn);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = cbCidade.Text.ToString();

            int auxID = 0;
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
                        auxID = Convert.ToInt32(reader["id"]);
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
            return auxID;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet5.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.dameta_dbDataSet5.Estados);
            this.dtClientesTableAdapter.Fill(this.dameta_dbDataSet.dtClientes);
            this.cidadesTableAdapter.Fill(this.dameta_dbDataSet.cidades);
            this.generosTableAdapter.Fill(this.dameta_dbDataSet.generos);
            filtrarCidades();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;
            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;
            conn = new SqlConnection(connectionString);

            if (!(camposVazios() == "preenchido"))
            {
                MessageBox.Show("Você deve preencher: " + camposVazios(),
                    "Informações incompletas!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }


            comm = new SqlCommand(
                "INSERT INTO premium_usuarios (nome, nascimento, CPF, telefone, CEP, cidades_id, generos_id) " +
                "VALUES (@nome, @nascimento, @CPF, @telefone, @CEP, @cidades_id, @generos_id)", conn);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = txNome.Text;

            comm.Parameters.Add("@nascimento", System.Data.SqlDbType.Date);
            comm.Parameters["@nascimento"].Value = dtpDataNasc.Value;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CEP"].Value = mtxCEP.Text;

            comm.Parameters.Add("@cidades_id", System.Data.SqlDbType.Int);
            comm.Parameters["@cidades_id"].Value = procurarCidade();

            comm.Parameters.Add("@generos_id", System.Data.SqlDbType.Int);
            comm.Parameters["@generos_id"].Value = Convert.ToInt32(cbGenero.SelectedValue);


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
                "SELECT Cli.id, Cli.nome as clienteNome, Cli.nascimento, Cli.CPF, Cli.telefone, Cli.CEP, Cli.cidades_id, Cli.generos_id, Cli.telefone, " +
                "Cid.id, Cid.nome as cidNome, Cid.UF, " +
                "Gen.Nome as genNome FROM premium_usuarios AS Cli " +
                "INNER JOIN Cidades AS Cid ON Cid.id = Cli.cidades_id " +
                "INNER JOIN Generos AS Gen " +
                "ON Gen.id = Cli.generos_id " +
                "WHERE Cli.id = @ID", conn);

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
                        cbCidade.Text = reader["cidNome"].ToString();
                        txNome.Text = reader["clienteNome"].ToString();
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                        cbGenero.Text = reader["genNome"].ToString();
                        cbUF.Text = reader["UF"].ToString();
                        cbCidade.Text = reader["cidNome"].ToString();
                        dtpDataNasc.Text = reader["nascimento"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não existe no banco de dados!",
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

        private void btAlterar_Click(object sender, EventArgs e)
        {

            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;
            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;
            conn = new SqlConnection(connectionString);

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
               
                comm = new SqlCommand(
                    "UPDATE premium_usuarios SET nome=@nome, nascimento = @nascimento, CPF=@CPF, telefone = @telefone, CEP = @CEP, " +
                    "cidades_id = @cidades_id, generos_id = @generos_id " +
                    "WHERE id = @id", conn);

                comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
                comm.Parameters["@id"].Value = txID.Text;

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = txNome.Text;

                comm.Parameters.Add("@nascimento", System.Data.SqlDbType.Date);
                comm.Parameters["@nascimento"].Value = dtpDataNasc.Value;

                comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CPF"].Value = mtxCPF.Text;

                comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@telefone"].Value = mtxTelefone.Text;

                comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CEP"].Value = mtxCEP.Text;

                comm.Parameters.Add("@cidades_id", System.Data.SqlDbType.Int);
                comm.Parameters["@cidades_id"].Value = procurarCidade();

                comm.Parameters.Add("@generos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@generos_id"].Value = Convert.ToInt32(cbGenero.SelectedValue);

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
                conn.Close();


                if (bIsOperationOK == true)
                {
                    MessageBox.Show("Cliente alterado com sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    AtualizaListaDeClientes();
                    btLimpar_Click(sender, e);
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txID.Clear();
            txNome.Clear();
            dtpDataNasc.ResetText();
            mtxCPF.Clear();
            mtxTelefone.Text = "";
            mtxCEP.Text = "";
            cbUF.Text = "";
            cbGenero.Text = "";
            cbCidade.Text = "";
            txID.Focus();
        }

        private void btExcluir_Click_1(object sender, EventArgs e)
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
                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand(
                    "DELETE FROM  premium_usuarios " +
                    "WHERE id = @ID_Cliente", conn);

                comm.Parameters.Add("@ID_Cliente", System.Data.SqlDbType.Int);
                comm.Parameters["@ID_Cliente"].Value = Convert.ToInt32(txID.Text);


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
                        MessageBox.Show("Registro Excluido!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                AtualizaListaDeClientes();
                btLimpar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Cliente não pode ser excluído porque não existe no banco de dados!",
                           "Registro não existe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
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
