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
    public partial class HomeEstabelecimentos : Form
    {
        public HomeEstabelecimentos()
        {
            InitializeComponent();
        }

        private void HomeEstabelecimentos_Load(object sender, EventArgs e)
        { 

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            estabelecimentos form = new estabelecimentos(true);
            form.Show();

        }
    }
}
