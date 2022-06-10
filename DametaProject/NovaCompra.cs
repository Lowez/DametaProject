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

        public NovaCompra(Carrinho form)
        {
            InitializeComponent();

            form_carrinho = form;
            form_carrinho.Enabled = false;
        }

        private void btNovaCompra_Click(object sender, EventArgs e)
        {
            PremiumUserCheck premiumUserCheck = new PremiumUserCheck(this, form_carrinho);
            premiumUserCheck.Show();
        }
    }
}
