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
    public partial class PremiumUserCheck : Form
    {
        Carrinho form_carrinho;
        public string nome_cliente = "";
        public int id_cliente = 0;

        public PremiumUserCheck()
        {
            InitializeComponent();
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            // Checa se a compra será feita por um Usuário Premium
            if (cbxPremiumUser.Checked)
            {
                // A compra só pode continuar se o CPF do usuário for informado
                if (mtxCPF.Text != "   .   .   -")
                {
                    SqlConnection conn;
                    SqlCommand comm;
                    SqlDataReader reader;

                    conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

                    comm = new SqlCommand(
                        "SELECT CPF FROM premium_usuarios " +
                        "WHERE CPF = @CPF", conn);

                    comm.Parameters.Add("@CPF", SqlDbType.NVarChar);
                    comm.Parameters["@CPF"].Value = mtxCPF.Text;

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

                            if (reader.Read())
                            {
                                string CPF_cliente = reader["CPF"].ToString();

                                using (InfosCliente infosCliente = new InfosCliente(CPF_cliente, this, form_carrinho))
                                {
                                    var result = infosCliente.ShowDialog();
                                    if (result == DialogResult.OK)
                                    {
                                        this.nome_cliente = infosCliente.nome_cliente;
                                        this.id_cliente = infosCliente.id_cliente;
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }

                                //InfosCliente infosCliente = new InfosCliente(CPF_cliente, this, form_carrinho);
                                //infosCliente.Show();
                            } else
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
                } else
                {
                    MessageBox.Show("Você deve informar um CPF",
                                "Erro!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            } else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cbxPremiumUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPremiumUser.Checked)
            {
                mtxCPF.Enabled = true;
                lblCPF.Enabled = true;
            } else
            {
                mtxCPF.Enabled = false;
                lblCPF.Enabled = false;

                mtxCPF.Text = "";
            }
        }
    }
}
