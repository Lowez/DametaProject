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
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.dameta_dbDataSet.funcionarios);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.cargos' table. You can move, or remove it, as needed.
            this.cargosTableAdapter.Fill(this.dameta_dbDataSet.cargos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.dameta_dbDataSet.generos);

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
                "SELECT func.id, func.nome, func.CPF, func.nascimento, func.email, func.CPF, func.salario, " +
                "func.telefone, func.generos_id, func.cargos_id, func.estabelecimentos_id, gen.id, gen.nome, " +
                "car.id, car.nome, estab.id, estab.nome " +
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
                        txNome.Text = reader["nome"].ToString();
                        cbGenero.Text = reader["nome"].ToString();
                        cbCargo.Text = reader["nome"].ToString();
                        cbEstabelecimento.Text = reader["nome"].ToString();
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

        private void btIncluir_Click(object sender, EventArgs e)
        {
            {

                string senha = "";
                if (cbSenha.Checked == true)
                {
                    string chars = "abcdefghjkmnpqrstuvwxyz023456789";
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

                comm.Parameters.Add("@nascimento", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nascimento"].Value = dtpDataNascimento.Text;

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

                comm.Parameters.Add("@genero_id", System.Data.SqlDbType.Int);
                comm.Parameters["@genero_id"].Value = cbGenero.SelectedValue;

                comm.Parameters.Add("@cargos_id", System.Data.SqlDbType.Int);
                comm.Parameters["@cargos_id"].Value = cbCargo.SelectedValue;

                comm.Parameters.Add("@estabelecimento_id", System.Data.SqlDbType.Int);
                comm.Parameters["@estabelecimento_id"].Value = cbEstabelecimento.SelectedValue;

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

                        AtualizaListaDeFuncionarios();
                        btLimpar_Click(sender, e);
                    }
                }
            }
        }

        private void AtualizaListaDeFuncionarios()
        {
            this.funcionariosTableAdapter.Fill(this.dameta_dbDataSet.funcionarios);
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

            string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
                "UPDATE funcionarios SET nome=@nome, nascimento=@nascimento, email = @email, CPF=@CPF, salario=@salario, telefone = @telefone, generos_id = @generos_id, cargos_id = @cargos_id, estabelecimento_id=@estabelecimento_id  " +
                "WHERE id = @id", conn);

            comm.Parameters.Add("@id", System.Data.SqlDbType.Int);
            comm.Parameters["@id"].Value = Convert.ToInt32(txID.Text);

            comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nome"].Value = txNome.Text;

            comm.Parameters.Add("@nascimento", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nascimento"].Value = dtpDataNascimento.Text;

            comm.Parameters.Add("@email", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@email"].Value = txEmail.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@salario", System.Data.SqlDbType.Money);
            comm.Parameters["@salario"].Value = Convert.ToDouble(txSalario.Text);

            comm.Parameters.Add("@telefone", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@telefone"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@genero_id", System.Data.SqlDbType.Int);
            comm.Parameters["@genero_id"].Value = cbGenero.SelectedValue;

            comm.Parameters.Add("@cargos_id", System.Data.SqlDbType.Int);
            comm.Parameters["@cargos_id"].Value = cbCargo.SelectedValue;

            comm.Parameters.Add("@estabelecimento_id", System.Data.SqlDbType.Int);
            comm.Parameters["@estabelecimento_id"].Value = cbEstabelecimento.SelectedValue;

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
            AtualizaListaDeFuncionarios();
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
                    MessageBox.Show("Registro Excluído!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            AtualizaListaDeFuncionarios();
            btLimpar_Click(sender, e);
        }
    }
}
