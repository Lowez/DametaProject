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
    public partial class TabelaDePrecos : Form
    {
        public TabelaDePrecos()
        {
            InitializeComponent();
        }

        private void TabelaDePrecos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.dameta_dbDataSet.produtos);

            this.reportViewer1.RefreshReport();
        }
    }
}
