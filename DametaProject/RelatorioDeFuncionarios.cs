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
    public partial class RelatorioDeFuncionarios : Form
    {
        public RelatorioDeFuncionarios()
        {
            InitializeComponent();
        }

        private void RelatorioDeFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.RelatorioDeFuncionarios' table. You can move, or remove it, as needed.
            this.relatorioDeFuncionariosTableAdapter.Fill(this.dameta_dbDataSet.RelatorioDeFuncionarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
