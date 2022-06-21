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
    public partial class RelatoriosFornecedoresEstabelecimentos : Form
    {
        public RelatoriosFornecedoresEstabelecimentos()
        {
            InitializeComponent();
            
        }

        private void RelatoriosFornecedoresEstabelecimentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet1.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet1.estabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.FornecedoresEstabelecimentos' table. You can move, or remove it, as needed.
            this.fornecedoresEstabelecimentos.Fill(this.dameta_dbDataSet.FornecedoresEstabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet1.FornecedoresEstabelecimentos' table. You can move, or remove it, as needed.
            this.fornecedoresEstabelecimentos.Fill(this.dameta_dbDataSet1.FornecedoresEstabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.dameta_dbDataSet.fornecedores);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);


            this.reportViewer2.RefreshReport();
        }


    }
}
