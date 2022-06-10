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
    public partial class Carrinho : Form
    {
        public Form form_inicial;
        public Carrinho(string nome, WelcomeForm form)
        {
            InitializeComponent();

            form_inicial = form;

            NovaCompra novaCompra = new NovaCompra(this);
            novaCompra.Show();

            // Adiciona o nome do  usuário que está logando no título do formulário
            this.Text = "Bem vindo(a) " + nome;
        }
    }
}
