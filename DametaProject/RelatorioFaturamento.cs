﻿using System;
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
    public partial class RelatorioFaturamento : Form
    {
        public RelatorioFaturamento()
        {
            InitializeComponent();
        }

        private void RelatorioFaturamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.compras' table. You can move, or remove it, as needed.
            this.comprasTableAdapter.Fill(this.dameta_dbDataSet.compras);

            this.reportViewer1.RefreshReport();
        }
    }
}
