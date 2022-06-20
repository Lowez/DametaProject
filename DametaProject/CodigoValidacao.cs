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
    public partial class CodigoValidacao : Form
    {
        string codigo_senha;
        string email_func;
        ResetSenha form_resetsenha;

        public CodigoValidacao(string email, ResetSenha form)
        {
            InitializeComponent();

            form_resetsenha = form;
            email_func = email;
        }

        private void btValidarCodigo_Click(object sender, EventArgs e)
        {
            if (mtxCodigo.Text == ResetSenha.codigo_senha)
            {
                NovaSenha form = new NovaSenha(email_func);
                form.Show();

                form_resetsenha.Close();
                this.Close();
            } else
            {
                MessageBox.Show("O código está incorreto",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
