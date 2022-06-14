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
    public partial class InfosCliente : Form
    {
        string nome_usuario;
        NovaCompra form_novacompra;
        PremiumUserCheck form_premiumUserCheck;
        Carrinho form_carrinho;

        public InfosCliente(string nome, NovaCompra form, PremiumUserCheck form2, Carrinho form3)
        {
            InitializeComponent();

            nome_usuario = nome;
            form_novacompra = form;
            form_premiumUserCheck = form2;
            form_carrinho = form3;
        }

        private void InfosCliente_Load(object sender, EventArgs e)
        {

        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            // Fecha os demais forms e habilita o Form de Carrinho
            form_novacompra.Close();
            form_premiumUserCheck.Close();
            form_carrinho.Enabled = true;
            this.Close();
        }

        private void lblTentarNovamente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fecha o form para inserção de um novo CPF
            this.Close();
        }
    }
}
