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
    public partial class RelatorioFuncionarios : Form
    {
        public RelatorioFuncionarios()
        {
            InitializeComponent();
        }

        private void RelatorioDeFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.dtEstabelecimentos' table. You can move, or remove it, as needed.
            this.dtEstabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.dtEstabelecimentos);
            this.reportViewer1.RefreshReport();
        }

        private void GerarRelatorio_Click(object sender, EventArgs e)
        {
            this.relatorioDeFuncionariosTableAdapter.Fill(this.dameta_dbDataSet.RelatorioDeFuncionarios, cbNome.Text);
            this.reportViewer1.RefreshReport();

            if (cbNome.Text == "")
            {
                ReportParameter rp = new ReportParameter("estabelecimento", "");
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            }

            else
            {
                ReportParameter rp = new ReportParameter("estabelecimento", "Pesquisando no estabelecimento:\n" + cbNome.Text);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
