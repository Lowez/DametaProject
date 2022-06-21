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
        public WelcomeForm form_inicial;

        public Login(string label_frase, int tipo_login, WelcomeForm form)
        {
            InitializeComponent();

            form_inicial = form;

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

        private void lblResetSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetSenha resetSenha = new ResetSenha();

            resetSenha.Show();
        }

        private void btLogar_Click(object sender, EventArgs e)
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

                    // Validação para login de Caixa
                    if (modo_login == "caixa")
                    {
                        // Caso o reader consiga ler o usuário foi identificado
                        if (reader.Read())
                        {
                            // Checa se o usuário é um operador de caixa ou administrador
                            if (reader["cargos_id"].ToString() != "1" && reader["cargos_id"].ToString() != "2")
                            {
                                MessageBox.Show("Você deve ser um Operador de Caixa ou Administrador para acessar esta sessão" + reader["cargos_id"].ToString(),
                                    "Erro!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else
                            {
                                Carrinho formCarrinho = new Carrinho(reader["nome"].ToString(), Convert.ToInt32(reader["estabelecimentos_id"]), form_inicial, true);
                                formCarrinho.Show();
                                form_inicial.Hide();
                                this.Close();
                            }

                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("CPF ou Senha incorretos!",
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    // Validação para login de Admin
                    else if (modo_login == "admin")
                    {
                        // Caso o reader consiga ler, o usuário foi identificado
                        if (reader.Read())
                        {
                            // Checa se o usuário é um administrador
                            if (reader["cargos_id"].ToString() != "2")
                            {
                                MessageBox.Show("Você deve ser um Administrador para acessar esta sessão",
                                    "Erro!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else
                            {
                                HomeManagerForm home_admin = new HomeManagerForm(reader["nome"].ToString(), form_inicial);

                                home_admin.Show();
                                form_inicial.Hide();
                                this.Close();
                            }

                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("CPF ou Senha incorretos!",
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
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
                conn.Close();
            }
        }
    }
}
