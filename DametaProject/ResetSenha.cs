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
    public partial class ResetSenha : Form
    {
        public ResetSenha()
        {
            InitializeComponent();
        }

        private void btEnviarEmail_Click(object sender, EventArgs e)
        {
            CodigoValidacao codigoValidacao = new CodigoValidacao();

            codigoValidacao.Show();
        }
    }
}
