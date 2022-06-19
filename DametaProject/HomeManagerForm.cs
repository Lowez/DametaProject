using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DametaProject
{
    public partial class HomeManagerForm : Form
    {
        public Form form_inicial;
        public HomeManagerForm(string nome, WelcomeForm form)
        {
            InitializeComponent();

            form_inicial = form;

            // Adiciona o nome do  usuário que está logando no título do formulário
            this.Text = "Bem vindo(a) " + nome;
        }

        private void btEstabelecimentos_Click(object sender, EventArgs e)
        {
            HomeEstabelecimentos form = new HomeEstabelecimentos();
            form.Show();
        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios form = new Funcionarios();
            form.Show();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Show();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            Produtos form = new Produtos();
            form.Show();
        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores form = new Fornecedores();
            form.Show();
        }
    }
}
