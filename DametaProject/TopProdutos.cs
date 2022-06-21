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
    public partial class TopProdutos : Form
    {
        public TopProdutos()
        {
            InitializeComponent();
        }

        private void TopProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);

            this.reportViewer1.RefreshReport();
        }

        private void GerarRelatorio_Click(object sender, EventArgs e)
        {
            this.produtos_mais_vendidosTableAdapter.Fill(this.dameta_dbDataSet.produtos_mais_vendidos, cbNome.Text);
            this.reportViewer1.RefreshReport();

            if (cbNome.Text == "")
            {
                ReportParameter rp = new ReportParameter("estabelecimento", "");
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            }
            else
            {
                ReportParameter rp = new ReportParameter("estabelecimento", "Exibindo os top 3 produtos mais vendidos pelo estabelecimento:\n" + cbNome.Text);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            }






            this.reportViewer1.RefreshReport();
        }
    }
}
