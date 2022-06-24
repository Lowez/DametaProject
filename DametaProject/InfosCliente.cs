using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DametaProject
{
    public partial class InfosCliente : Form
    {
        public string nome_cliente = "";
        public int id_cliente = 0;

        string CPF_cliente;
        PremiumUserCheck form_premiumUserCheck;
        Carrinho form_carrinho;

        public InfosCliente(string cpf, PremiumUserCheck form2, Carrinho form3)
        {
            InitializeComponent();

            CPF_cliente = cpf;
            form_premiumUserCheck = form2;
            form_carrinho = form3;
        }

        private void InfosCliente_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

            comm = new SqlCommand(
                "SELECT * FROM premium_usuarios " +
                "WHERE CPF = @CPF", conn
                );

            comm.Parameters.Add("@CPF", SqlDbType.NVarChar);
            comm.Parameters["@CPF"].Value = CPF_cliente;

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
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        txNome.Text = reader["nome"].ToString();
                        string nascimento = reader["nascimento"].ToString();
                        txDataNascimento.Text = nascimento.Remove(nascimento.Length - 9);
                        mtxCPF.Text = CPF_cliente;
                        mtxTelefone.Text = reader["telefone"].ToString();
                        txNome.Text = reader["nome"].ToString();

                        id_cliente = Convert.ToInt32(reader["id"]);
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado",
                        "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar comando",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            // Fecha os demais forms
            nome_cliente = txNome.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblTentarNovamente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fecha o form para inserção de um novo CPF
            this.Close();
        }
    }
}
