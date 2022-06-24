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

        public CodigoValidacao(string email)
        {
            InitializeComponent();

            email_func = email;
        }

        private void btValidarCodigo_Click(object sender, EventArgs e)
        {
            if (mtxCodigo.Text == ResetSenha.codigo_senha)
            {
                using (NovaSenha form = new NovaSenha(email_func))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
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
