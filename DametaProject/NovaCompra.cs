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
        WelcomeForm form_welcome;

        public NovaCompra(string nome, WelcomeForm form)
        {
            InitializeComponent();

            form_carrinho = new Carrinho(nome, form);
            form_carrinho.Show();

            form_welcome = form;
        }

        private void btNovaCompra_Click(object sender, EventArgs e)
        {
            PremiumUserCheck premiumUserCheck = new PremiumUserCheck(this, form_carrinho);
            premiumUserCheck.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            form_carrinho.Close();
            this.Close();
            form_welcome.Show();
        }
    }
}
