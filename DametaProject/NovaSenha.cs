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
    public partial class NovaSenha : Form
    {
        string email_func;
        bool is_operation_ok = true;

        public Senha Dado;
        public NovaSenha(string email)
        {
            InitializeComponent();

            email_func = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txConfirmacaoSenha.Text != txSenha.Text)
            {
                MessageBox.Show("Senhas diferentes",
                    "As senhas devem ser iguais",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conn;
                SqlCommand comm;

                conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

                comm = new SqlCommand(
                    "UPDATE funcionarios " +
                    "SET senha = @senha " +
                    "WHERE email = @email", conn
                    );

                comm.Parameters.Add("@senha", SqlDbType.NVarChar);
                comm.Parameters["@senha"].Value = txConfirmacaoSenha.Text;

                comm.Parameters.Add("@email", SqlDbType.NVarChar);
                comm.Parameters["@email"].Value = email_func;

                try
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        is_operation_ok = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar conexão com a base de dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        is_operation_ok = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar execurar o comando SQL.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close();
                }

                if (is_operation_ok)
                {
                    MessageBox.Show("Registro Concluído",
                        "Registro Concluído com sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Dado.senha = txSenha.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}

