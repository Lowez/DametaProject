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
    public partial class HomeRelatorios : Form
    {
        public HomeRelatorios()
        {
            InitializeComponent();
        }

        private void HomeRelatorios_Load(object sender, EventArgs e)
        {

        }

        private void btControleEstoque_Click(object sender, EventArgs e)
        {
            //Estoque form = new Estoque();
            //form.Show();
        }

        private void btFornecedores_Click(object sender, EventArgs e)
        {
            //RelatorioFornecedores form = new RelatorioFornecedores();
            //form.Show();
        }

        private void btForncEstabelecimentos_Click(object sender, EventArgs e)
        {
            //RelatoriosFornecedoresEstabelecimentos form = new RelatoriosFornecedoresEstabelecimentos();
           // form.Show();
        }

        private void btFuncEstabelecimento_Click(object sender, EventArgs e)
        {
            //RelatorioFuncionarios form = new RelatorioFuncionarios();
           // form.Show();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            //TopProdutos form = new TopProdutos();
            //form.Show();
        }

        private void btFaturamento_Click(object sender, EventArgs e)
        {
            //Faturamento form = new Faturamento();
            //form.Show();
        }

        private void btTabelaPrecos_Click(object sender, EventArgs e)
        {
            //TabelaDePrecos form = new TabelaDePrecos();
            //form.Show();
        }
    }
}
