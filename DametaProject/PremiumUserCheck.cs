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
    public partial class PremiumUserCheck : Form
    {
        NovaCompra form_novacompra;
        Carrinho form_carrinho;
        public PremiumUserCheck(NovaCompra form, Carrinho form2)
        {
            InitializeComponent();
        }
    }
}
