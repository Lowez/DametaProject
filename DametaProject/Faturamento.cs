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
    public partial class Faturamento : Form
    {
        public Faturamento()
        {
            InitializeComponent();
        }

        private void Faturamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.faturamento' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);

            this.reportViewer1.RefreshReport();
        }

        private void GerarRelatorio_Click(object sender, EventArgs e)
        {

            this.faturamentoTableAdapter.Fill(this.dameta_dbDataSet.faturamento, dtpDataInicio.Text, dtpDataFim.Text, cbNome.Text);
            this.reportViewer1.RefreshReport();

            if (cbNome.Text == "")
            {
                ReportParameter rp = new ReportParameter("estabelecimento", "");
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            }
            else
            {
                ReportParameter rp = new ReportParameter("estabelecimento", "Pesquisa por: " + cbNome.Text);
                ReportParameter rp2 = new ReportParameter("dataInicio", "De " + dtpDataInicio.Text);
                ReportParameter rp3 = new ReportParameter("dataFim", "Até " + dtpDataFim.Text);

                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp, rp2, rp3 });
            }



            this.reportViewer1.RefreshReport();
        }
    }
}
