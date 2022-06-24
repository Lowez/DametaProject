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
    public partial class FormaDePagamento : Form
    {
        bool cartaoOn = false;
        public FormaDePagamento()
        {
            InitializeComponent();
        }

        private void btDebito_Click(object sender, EventArgs e)
        {
            using (Cartao formDebito = new Cartao("Débito"))
            {
                var result = formDebito.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btCredito_Click(object sender, EventArgs e)
        {
            using (Cartao formCredito = new Cartao("Crédito"))
            {
                var result = formCredito.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btDinheiro_Click(object sender, EventArgs e)
        {
            if (cartaoOn)
            {
                btDebito.Visible = false;
                btCredito.Visible = false;
            }

            using (Cedulas formCedulas = new Cedulas())
            {
                var result = formCedulas.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }            
        }

        private void btCartao_Click(object sender, EventArgs e)
        {
            if (cartaoOn)
            {
                cartaoOn = false;
            }
            else
            {
                cartaoOn = true;
            }

            if (cartaoOn)
            {
                btDebito.Visible = true;
                btCredito.Visible = true;
            }
            else
            {
                btDebito.Visible = false;
                btCredito.Visible = false;
            }
        }
    }
}
