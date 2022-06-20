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
    public partial class NovaCompra : Form
    {
        Carrinho form_carrinho;
        WelcomeForm form_inicial;

        public NovaCompra(WelcomeForm form, Carrinho form2)
        {
            InitializeComponent();

            form_inicial = form;
            form_carrinho = form2;
        }

        private void btNovaCompra_Click(object sender, EventArgs e)
        {
            PremiumUserCheck premiumUserCheck = new PremiumUserCheck(form_carrinho);
            premiumUserCheck.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            form_carrinho.Close();
            form_inicial.Show();
        }
    }
}
