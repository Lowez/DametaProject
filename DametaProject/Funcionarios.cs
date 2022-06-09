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
                "SELECT func.id, func.funcionariosNome, func.CPF, func.nascimento, func.email, " +
                "func.CPF, func.salario, func.generos_id, func.cargos_id, func.estabelecimentos_id, " +
                "gen.id, gen.generosNome, " +
                "car.id, car.cargoNome, " +
                "estab.id, estab.estabelecimentosNome " +
                "FROM funcionarios AS func " +
                "INNER JOIN generos AS gen ON gen.id = func.generos_id " +
                "INNER JOIN cargos AS car ON car.id = func.cargo_id" +
                "INNER JOIN estabelecimentos AS estab ON estab.id func.estabelecimentos_id " +
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
                        mtxCPF.Text = reader["CPF"].ToString();
                        mtxTelefone.Text = reader["telefone"].ToString();
                        txEmail.Text = reader["email"].ToString();
                        txSalario.Text = reader["Salario"].ToString();
                        dtpDataNascimento.Text = reader["nascimento"].ToString();
                        cbGenero.Text = reader["generoNome"].ToString();
                        cbCargo.Text = reader["cargoNome"].ToString();
                        cbEstabelecimento.Text = reader["estabelecimentosNome"].ToString();
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





        private void txID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
