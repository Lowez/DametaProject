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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.dameta_dbDataSet.fornecedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
