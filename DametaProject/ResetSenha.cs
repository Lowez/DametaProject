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
using System.IO;
using System.Text;

namespace DametaProject
{
    public partial class ResetSenha : Form
    {
        public ResetSenha()
        {
            InitializeComponent();
        }

        private string gerarCodigo()
        {
            string codigo = "";

            Random r = new Random();
            var x = r.Next(0, 1000000);
            codigo = x.ToString("000000");

            return codigo;
        }

        private void criaArquivoTxt()
        {
            string path = @"C:\Users\Public\Documents\codigo_ativacao.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(gerarCodigo());
                    tw.Close();
                }
            }
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(gerarCodigo());
                    tw.Close();
                }
            }
        }

        private void btEnviarEmail_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            conn = new SqlConnection(Properties.Settings.Default.dameta_dbConnectionString);

            comm = new SqlCommand(
                "SELECT * from funcionarios " +
                "WHERE email = @email", conn);

            comm.Parameters.Add("@email", SqlDbType.NVarChar);
            comm.Parameters["@email"].Value = txEmail.Text;

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
                        criaArquivoTxt();

                        CodigoValidacao codigoValidacao = new CodigoValidacao(reader["email"].ToString());

                        codigoValidacao.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email não encontrado na Base de Dados",
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
    }
}
