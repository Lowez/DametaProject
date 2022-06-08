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
    public partial class Login : Form
    {
        // Variável a ser usada ao usuário tentar logar para que seja encaminhado para o Caixa ou Admin, entre outras validações
        private string modo_login;

        public Login(string label_frase, int tipo_login)
        {
            InitializeComponent();

            // Caso receba 0 na chamada do Form, significa que um acesso ao setor de caixa está sendo feito, caso contrário é um acesso de admin
            if (tipo_login == 0)
            {
                modo_login = "caixa";
            } else
            {
                modo_login = "admin";
            }
            lblFraseLogin.Text = label_frase;
        }

        private void LoginSalesForm_Load(object sender, EventArgs e)
        {

        }

        private void lblResetSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetSenha resetSenha = new ResetSenha();

            resetSenha.Show();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            // Validação para login de Caixa
            if (modo_login == "caixa")
            {
                SqlConnection conn;
                SqlCommand comm;
                SqlDataReader reader;

                conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

                comm = new SqlCommand(
                    "SELECT * FROM funcionarios " +
                    "WHERE CPF = @CPF AND senha = @senha", conn);

                comm.Parameters.Add("@CPF", SqlDbType.NVarChar);
                comm.Parameters["@CPF"].Value = mtxCPF.Text;

                comm.Parameters.Add("@senha", SqlDbType.NVarChar);
                comm.Parameters["@senha"].Value = txSenha.Text;

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

                    // Tenta executar o comando e login
                    try
                    {
                        reader = comm.ExecuteReader();

                        // Caso o reader consiga ler o usuário foi identificado
                        if (reader.Read())
                        {
                            lblIncorreto.Visible = false;
                        } else
                        {
                            lblIncorreto.Visible = true;
                        }
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

                }

                /*
                reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    cbCliente.Text = reader["Nome"].ToString();
                    dtpDataVenda.Text = reader["Data_Venda"].ToString();
                    txPrecoTotal.Text = reader["Preco_Total"].ToString();
                }

                reader.Close();
                */
            }
            // Validação para login de Admin
            else if (modo_login == "admin")
            {

            }
        }
    }
}
