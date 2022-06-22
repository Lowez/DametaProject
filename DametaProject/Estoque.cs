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

            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);

            this.reportViewer1.RefreshReport();
        }

        private void GerarRelatorio_Click(object sender, EventArgs e)
        {
            int qtd = 0;
            this.controleDeEstoqueTableAdapter.Fill(this.dameta_dbDataSet.ControleDeEstoque, cbNome.Text, qtd);
            this.reportViewer1.RefreshReport();

            if (cbNome.Text == "")
            {
                ReportParameter rp = new ReportParameter("estabelecimento", "");
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            }

            else
            {

                ReportParameter rp = new ReportParameter("estabelecimento", "Pesquisa por: " + cbNome.Text);


                if (radioButton2.Checked)
                {

                }
                else if (radioButton3.Checked)
                {
                    ReportParameter rp2 = new ReportParameter("qtd", "Exibindo produtos fora de estoque");
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp, rp2 });
                }
                else
                {
                    //    ReportParameter rp = new ReportParameter("qtd", "Exibindo todos os produtos cadastrados no estabelecimento");
                    //    ReportParameter rp3 = new ReportParameter("dataFim", "Até " + dtpDataFim.Text);

                    //}
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
                }

                this.reportViewer1.RefreshReport();
            }
        }
    }
}