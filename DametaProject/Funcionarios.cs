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
            // TODO: This line of code loads data into the 'dameta_dbDataSet.cargos' table. You can move, or remove it, as needed.
            this.cargosTableAdapter.Fill(this.dameta_dbDataSet.cargos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.dameta_dbDataSet.generos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.dameta_dbDataSet.funcionarios);

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
                "SELECT func.id, func.nome, func.CPF, func.nascimento, func.email, "+
                "func.CPF, func.salario, func.generos_id, func.cargos_id, func.estabelecimentos_id, "+
                "gen.id, gen.nome, car.id, car.nome, estab.id, estab.nome "+
                "FROM funcionarios AS func " +
                "INNER JOIN generos AS gen ON gen.id = func.generos_id " +
                "INNER JOIN cargos AS car ON car.id = func.cargos_id " +
                "INNER JOIN estabelecimentos AS estab ON estab.id = func.estabelecimentos_id  " +
                "WHERE func.id = @ID ", conn);

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

                string senha;
                if (cbSenha.Checked == true)
                {
                    using (var form = new DigitaSenha())
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            string Nome = form.dados.Nome;
                            string Descricao = form.dados.Descricao;
                            int Idade = form.dados.Idade;

                            textBox1.Text = Nome;
                            textBox2.Text = Descricao;
                            textBox3.Text = Convert.ToString(Idade);
                        }
                else
                {
                    senha = "Digitada";
                }
                SqlConnection conn;
                SqlCommand comm;
                SqlDataReader reader;
                bool bIsOperationOK = true;

                string connectionString = Properties.Settings.Default.dameta_dbConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand(
                    "INSERT INTO funcionarios (nome, nascimento, email, CPF, senha, salario,generos_id,cargos_id, estabelecimentos_id) " +
                    "VALUES (@nome,@nascimento, @email, @CPF, @senha, @salario, @generos_id, @cargos_id, @estabelecimentos_id)", conn);

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
                
                comm.Parameters.Add("@genero_id", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@genero_id"].Value = cbGenero.Text;

                comm.Parameters.Add("@cargos_id", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@cargos_id"].Value = cbCargo.Text;

                comm.Parameters.Add("@estabelecimento_id", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@estabelecimento_id"].Value = cbEstabelecimento.Text;

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
    }
}
