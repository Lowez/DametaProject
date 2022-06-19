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
    public partial class HomeEstabelecimentos : Form
    {

        public Estabelecimentos Estabelecimentos;
        public HomeEstabelecimentos()
        {
            InitializeComponent();
        }

        private void HomeEstabelecimentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dameta_dbDataSet.estabelecimentos' table. You can move, or remove it, as needed.
            this.estabelecimentosTableAdapter.Fill(this.dameta_dbDataSet.estabelecimentos);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            Estabelecimentos form = new Estabelecimentos(true);
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nome="2";
            Estabelecimentos form = new Estabelecimentos(false, nome);
            form.Show();
        }
    }
}
