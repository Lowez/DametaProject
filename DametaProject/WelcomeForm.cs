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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btAcessoCaixa_Click(object sender, EventArgs e)
        {
            using (Login loginForm = new Login("Por favor, entre com seu Usuário Operador de Caixa", 0, this))
            {
               loginForm.ShowDialog();
            }
        }

        private void btAcessoAdmin_Click(object sender, EventArgs e)
        {
            using (Login loginForm = new Login("Por favor, entre com sua conta Administrativa", 1, this))
            {
                loginForm.ShowDialog();
            }
        }
    }
}
