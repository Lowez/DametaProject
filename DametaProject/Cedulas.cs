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

        public Cedulas()
        {
            InitializeComponent();

            txValorTotal.Text = Carrinho.preco_total.ToString();
        }

        private void btTerminar_Click(object sender, EventArgs e)
        {
            if (txValorPago.Text != "")
            {
                MessageBox.Show("Compra concluída.",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
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
            decimal valor_pago = 0;
            decimal valor_total = 0;

            if (txValorPago.Text != "")
            {
                txTroco.TextAlign = HorizontalAlignment.Center;
                try
                {
                    valor_pago = Convert.ToDecimal(txValorPago.Text);
                    valor_total = Convert.ToDecimal(txValorTotal.Text);
                }
                catch
                {
                    MessageBox.Show("Digite apenas numeros!",
                             "Erro!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                            txValorPago.Text = "";
                            txValorPago.Focus();
                }

                if (valor_pago < valor_total)
                {
                    txTroco.Text = "Valor pago menor do que o total!";
                    btTerminar.Enabled = false;
                }
                else
                {
                    decimal troco = valor_pago - valor_total;
                    txTroco.Text = troco.ToString();
                    btTerminar.Enabled = true;
                    Carrinho.preco_total = 0;
                }
            }
            else
            {
                txTroco.Text = "";
            }
        }
    }
}
