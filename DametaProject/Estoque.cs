using Microsoft.Reporting.WinForms;
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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet1.ControleDeEstoque' table. You can move, or remove it, as needed.
            this.controleDeEstoqueTableAdapter.Fill(this.dameta_dbDataSet1.ControleDeEstoque);

            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);

            this.reportViewer1.RefreshReport();
        }

    }
}