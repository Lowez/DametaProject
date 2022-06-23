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
    public partial class HomeEstabelecimentos : Form
    {

        public Estabelecimentos Estabelecimentos;
        public HomeEstabelecimentos()
        {
            InitializeComponent();
        }

        private void HomeEstabelecimentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.dtEstabelecimentos' table. You can move, or remove it, as needed.
            this.dtEstabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.dtEstabelecimentos);
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            Estabelecimentos form = new Estabelecimentos(true);
            form.Show();
        }

        private void dgtdtEstabelecimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeEstabelecimento = dgtdtEstabelecimentos.Rows[e.RowIndex].Cells[0].Value.ToString();
            Estabelecimentos form = new Estabelecimentos(false, nomeEstabelecimento);
            form.Show();
        }

    }
}
