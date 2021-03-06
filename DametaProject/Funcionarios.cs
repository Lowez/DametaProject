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
    public struct Senha
    {
        public string senha;
    }

    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();

            // Seta a data do DateTimePicker para a data atual
            dtpDataNascimento.Value = DateTime.Now;
        }
        public string camposVazios(string operacao = null)
        {

            if (operacao == "only_id")
            {
                if (txID.Text == "")
                {
                    return "Código do Funcionário";
                }
            }
            else
            {
                if (operacao == "alterar")
                {
                    if (txID.Text == "")
                    {
                        return "Código do Funcionário";
                    }
                    else
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
                    return "Nome do Funcionário";
                }

                if (dtpDataNascimento.Value == null)
                {
                    return "Data de Nascimento";
                }

                if (mtxCPF.Text == "   .   .   -")
                {
                    return "CPF";
                }

                if (mtxTelefone.Text == "(  )     -")
                {
                    return "Telefone";
                }

                if (cbGenero.Text == "")
                {
                    return "Gênero";
                }

                if (txEmail.Text == "")
                {
                    return "Email";
                }

                if (cbCargo.Text == "")
                {
                    return "Cargo";
                }

                if (txSalario.Text == "")
                {
                    return "Salário";
                }

                if (cbEstabelecimento.Text == "")
                {
                    return "Estabelecimento";
                }
            }
            return "preenchido";
        }

        private void AtualizaListaDeFuncionarios()
        {
            this.dtFuncionariosTableAdapter.Fill(this.dameta_dbDataSet.dtFuncionarios);
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.dtFuncionarios' table. You can move, or remove it, as needed.
            this.dtFuncionariosTableAdapter.Fill(this.dameta_dbDataSet.dtFuncionarios);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.dameta_dbDataSet.funcionarios);

            // TODO: This line of code loads data into the 'dameta_dbDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.dameta_dbDataSet.funcionarios);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.cargos' table. You can move, or remove it, as needed.
            this.cargosTableAdapter.Fill(this.dameta_dbDataSet.cargos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.dameta_dbDataSet.generos);
            btLimpar_Click(sender, e);
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
                "SELECT func.id " +
                "FROM funcionarios AS func " +
                "WHERE func.id = @ID", conn);

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
                "SELECT func.id, func.nome AS funcNome, func.CPF, func.nascimento, func.email, func.CPF, func.salario, " +
                "func.telefone, func.generos_id, func.cargos_id, func.estabelecimentos_id, gen.id, gen.nome AS genNome, " +
                "car.id, car.nome AS carNome, estab.id, estab.nome AS estabNome " +
                "FROM funcionarios AS func " +
                "INNER JOIN generos AS gen ON gen.id = func.generos_id " +
                "INNER JOIN cargos AS car ON car.id = func.cargos_id " +
                "INNER JOIN estabelecimentos AS estab ON estab.id = func.estabelecimentos_id " +
                "WHERE func.id = @ID", conn);

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
                        txNome.Text = reader["funcNome"].ToString();
                        cbGenero.Text = reader["genNome"].ToString();
                        cbCargo.Text = reader["carNome"].ToString();
                        cbEstabelecimento.Text = reader["estabNome"].ToString();
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                        txEmail.Text = reader["email"].ToString();
                        txSalario.Text = reader["Salario"].ToString();
                        dtpDataNascimento.Text = reader["nascimento"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não existe no banco de dados!",
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
            if (!(camposVazios() == "preenchido"))
            {
                MessageBox.Show("Você deve preencher: " + camposVazios(),
                    "Informações incompletas!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string senha = "";
            if (cbSenha.Checked == true)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz0123456789";
                Random random = new Random();
                for (int f = 0; f < 6; f++)
                {
                    senha = senha + chars.Substring(random.Next(0, chars.Length - 1), 1);
                }
            }
            else
            {
                using (var form = new DigitaSenha())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        senha = form.Dado.senha;
                    }
                }
            }
            if (senha != "")
            {
                SqlConnection conn;
                SqlCommand comm;
                bool bIsOperationOK = true;

                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand(
                    "INSERT INTO funcionarios (nome, nascimento, email, CPF, senha, salario, telefone, generos_id,cargos_id, estabelecimentos_id) " +
                    "VALUES (@nome,@nascimento, @email, @CPF, @senha, @salario, @telefone, @generos_id, @cargos_id, @estabelecimentos_id)", conn);

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = txNome.Text;

                comm.Parameters.Add("@nascimento", System.Data.SqlDbType.Date);
                comm.Parameters["@nascimento"].Value = dtpDataNascimento.Value;

                comm.Parameters.Add("@email", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@email"].Value = txEmail.Text;

                comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CPF"].Value = mtxCPF.Text;

                comm.Parameters.Add("@senha", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@senha"].Value = senha;

                comm.Parameters.Add("@salario", System.Data.SqlDbType.Money);
                comm.Parameters["@salario"].Value = Convert.ToDouble(txSalario.Text);

                comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@telefone"].Value = mtxTelefone.Text;

                comm.Parameters.Add("@generos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@generos_id"].Value = cbGenero.SelectedValue;

                comm.Parameters.Add("@cargos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@cargos_id"].Value = cbCargo.SelectedValue;

                comm.Parameters.Add("@estabelecimentos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@estabelecimentos_id"].Value = cbEstabelecimento.SelectedValue;

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

                    if (bIsOperationOK == true && cbSenha.Checked == true)
                    {
                        MessageBox.Show("Login: " + mtxCPF.Text + "\nSenha gerada: " + senha,
                            "Funcionário Cadastrado com sucesso!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else if (bIsOperationOK == true)
                    {
                        MessageBox.Show("Login: " + mtxCPF.Text + "\nSenha: " + senha,
                            "Funcionário Cadastrado com sucesso!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    AtualizaListaDeFuncionarios();
                    btLimpar_Click(sender, e);
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txID.Clear();
            txNome.Clear();
            mtxCPF.Clear();
            txEmail.Clear();
            mtxTelefone.Clear();
            txSalario.Clear();
            cbSenha.Checked = true;
            cbCargo.Text = "";
            cbGenero.Text = "";
            cbEstabelecimento.Text = "";
            dtpDataNascimento.Text = DateTime.Now.ToShortDateString();
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
                    "UPDATE funcionarios SET nome=@nome, nascimento=@nascimento, email = @email, CPF=@CPF, salario=@salario, telefone = @telefone, generos_id = @generos_id, cargos_id = @cargos_id, estabelecimentos_id=@estabelecimentos_id  " +
                    "WHERE id = @id", conn);

                comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
                comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = txNome.Text;

                comm.Parameters.Add("@nascimento", System.Data.SqlDbType.Date);
                comm.Parameters["@nascimento"].Value = dtpDataNascimento.Value;

                comm.Parameters.Add("@email", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@email"].Value = txEmail.Text;

                comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CPF"].Value = mtxCPF.Text;

                comm.Parameters.Add("@salario", System.Data.SqlDbType.Money);
                comm.Parameters["@salario"].Value = Convert.ToDouble(txSalario.Text);

                comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@telefone"].Value = mtxTelefone.Text;

                comm.Parameters.Add("@generos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@generos_id"].Value = cbGenero.SelectedValue;

                comm.Parameters.Add("@cargos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@cargos_id"].Value = cbCargo.SelectedValue;

                comm.Parameters.Add("@estabelecimentos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@estabelecimentos_id"].Value = cbEstabelecimento.SelectedValue;

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
                        MessageBox.Show("Funcionário alterado com sucesso!",
                            "Registro Alterado!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                AtualizaListaDeFuncionarios();
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
                    "DELETE FROM funcionarios " +
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
                        MessageBox.Show("Funcionário excluído com sucesso!",
                            "Registro Excluído!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                AtualizaListaDeFuncionarios();
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

        private void buscarPeloNome(string nome)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            // Inicializa a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "SELECT func.id, func.nome AS funcNome, func.CPF, func.nascimento, func.email, func.CPF, func.salario, " +
                "func.telefone, func.generos_id, func.cargos_id, func.estabelecimentos_id, gen.id, gen.nome AS genNome, " +
                "car.id, car.nome AS carNome, estab.id, estab.nome AS estabNome " +
                "FROM funcionarios AS func " +
                "INNER JOIN generos AS gen ON gen.id = func.generos_id " +
                "INNER JOIN cargos AS car ON car.id = func.cargos_id " +
                "INNER JOIN estabelecimentos AS estab ON estab.id = func.estabelecimentos_id " +
                "WHERE func.nome = @nome", conn);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = nome;

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
                        txNome.Text = reader["funcNome"].ToString();
                        cbGenero.Text = reader["genNome"].ToString();
                        cbCargo.Text = reader["carNome"].ToString();
                        cbEstabelecimento.Text = reader["estabNome"].ToString();
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                        txEmail.Text = reader["email"].ToString();
                        txSalario.Text = reader["Salario"].ToString();
                        dtpDataNascimento.Text = reader["nascimento"].ToString();

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

        private void dgtdtFuncionarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string nome = dgtdtFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            buscarPeloNome(nome);
        }

      
    }
}
