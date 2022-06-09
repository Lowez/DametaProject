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
    public partial class HomeSalesForm : Form
    {
        public Form form_inicial;
        public HomeSalesForm(string nome, WelcomeForm form)
        {
            InitializeComponent();

            form_inicial = form;

            // Adiciona o nome do  usuário que está logando no título do formulário
            this.Text = "Bem vindo(a) " + nome;
        }
    }
}
