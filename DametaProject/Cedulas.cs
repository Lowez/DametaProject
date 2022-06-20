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

            txValorTotal.Text = Carrinho.preco_total.ToString();
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

        private void txValorPago_TextChanged(object sender, EventArgs e)
        {
            if (txValorPago.Text != "")
            {
                decimal valor_pago = Convert.ToDecimal(txValorPago.Text);
                decimal valor_total = Convert.ToDecimal(txValorTotal.Text);

                if (valor_pago < valor_total)
                {
                    MessageBox.Show("O valor pago é menor do que o total da compra!",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                } else
                {
                    decimal troco = valor_pago - valor_total;
                    txTroco.Text = troco.ToString();

                    btTerminar.Enabled = true;
                    Carrinho.preco_total = 0;
                }
            } else
            {
                btTerminar.Enabled = true;
            }
        }
    }
}
