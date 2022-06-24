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
        string nomeEstabelecimento = "";
        public Estabelecimentos(string nome_estabelecimento = "")
        {
            InitializeComponent();
            this.nomeEstabelecimento = nome_estabelecimento;
            AtualizaListaDeEstabelecimentos();
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
                "SELECT estab.id " +
                "FROM estabelecimentos AS estab " +
                "WHERE estab.id = @ID", conn);

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
                    return "Código do Estabelecimento";
                }
            }
            else
            {
                if (operacao == "alterar")
                {
                    if (txID.Text == "")
                    {
                        return "Código do Estabelecimento";
                    }
                    else
                    {
                        bool existe = ConsultarExistencia(Convert.ToInt32(txID.Text));
                        if (!existe)
                        {
                            MessageBox.Show("Estabelecimento não existe no banco de dados!",
                          "Registro não existe",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                            return "nao existe";
                        }
                    }
                }

                if (txNome.Text == "")
                {
                    return "Nome do Estabelecimento";
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

                if (txNumero.Text == "")
                {
                    return "Número";
                }

                if (mtxTelefone.Text == "(  )     -")
                {
                    return "Telefone";
                }

                if (txRua.Text == "")
                {
                    return "Rua";
                }
            }

            return "preenchido";
        }

        private void AtualizaListaDeEstabelecimentos()
        {
            this.dtEstabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.dtEstabelecimentos);
        }

        private void Estabelecimentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.Estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.dameta_dbDataSet.Estados);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.dtEstabelecimentos' table. You can move, or remove it, as needed.
            this.dtEstabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.dtEstabelecimentos);
            btLimpar_Click(sender, e);
            if (nomeEstabelecimento != "")
            {
                buscarPelaCidade(nomeEstabelecimento);
            }
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.dameta_dbDataSet.cidades);
            AtualizaListaDeEstabelecimentos();
        }


        private void buscarPelaCidade(string nome)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT estab.id, estab.nome, estab.CEP, estab.nome_rua, estab.numero, estab.telefone, estab.cidades_id, cid.id, cid.nome AS cidNome, cid.UF " +
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
                        cbUF.Text = reader["UF"].ToString();
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
                "INSERT INTO estabelecimentos (nome, nome_rua, numero, telefone, CEP, cidades_id) " +
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
            comm.Parameters["@cidades_id"].Value = procurarCidade();

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
            }
            AtualizaListaDeEstabelecimentos();
            btLimpar_Click(sender, e);
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

                comm.Parameters.Add("@cidades_id", System.Data.SqlDbType.Int);
                comm.Parameters["@cidades_id"].Value = procurarCidade();

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
            else
            {
                MessageBox.Show("Estabelecimento não pode ser excluído porque não existe no banco de dados!",
                           "Registro não existe",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
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
            cbUF.Text = "";
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
                "SELECT estab.id, estab.nome, estab.CEP, estab.nome_rua, estab.numero, estab.telefone, estab.cidades_id, cid.id, cid.nome AS cidNome, cid.UF " +
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
                        cbUF.Text = reader["UF"].ToString();
                        cbCidade.Text = reader["cidNome"].ToString();
                        txRua.Text = reader["nome_rua"].ToString();
                        mtxCEP.Text = reader["CEP"].ToString();
                        txNumero.Text = reader["numero"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Estabelecimento não existe no banco de dados!",
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
            filtrarCidades(false);

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

        private void dgtdtEstabelecimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeEstabelecimento = dgtdtEstabelecimentos.Rows[e.RowIndex].Cells[1].Value.ToString();
            buscarPelaCidade(nomeEstabelecimento);
        }
    }
}
