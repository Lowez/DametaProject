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
    public partial class Cedulas : Form
    {
        FormaDePagamento form_formaDePagamento;

        public Cedulas(FormaDePagamento form)
        {
            InitializeComponent();

            form_formaDePagamento = form;
        }

        private void btTerminar_Click(object sender, EventArgs e)
        {
            if (txValorPago.Text != "")
            {
                this.Close();
                form_formaDePagamento.Close();
            } else
            {
                MessageBox.Show("Informe o valor pago pelo cliente",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txValorPago.Focus();
            }
        }
    }
}
