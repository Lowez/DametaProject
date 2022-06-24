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
    public partial class DigitaSenha : Form
    {
        public Senha Dado;
        public DigitaSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txConfirmacaoSenha.Text != txSenha.Text)
            {
                MessageBox.Show("Senhas diferentes",
                    "As senhas devem ser iguais",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro Concluído",
                    "Registro Concluído com sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Dado.senha = txSenha.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
