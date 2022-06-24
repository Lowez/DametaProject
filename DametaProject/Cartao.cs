using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DametaProject
{
    public partial class Cartao : Form
    {
        // Texto completo da caixa de operação:
        /*
         * Por favor, insira o cartão
         * Digita a senha
         * Operação finalizada, retire o cartão
         */

        string tipo_cartao;
        int tick_phase = 0;
        FormaDePagamento form_pagamento;

        public Cartao(string cartao)
        {
            tipo_cartao = "[" + cartao + " Selecionado]";

            InitializeComponent();

            rtbOperacao.Text = "";

            lblCartao.Text = tipo_cartao;

            this.Text = cartao;
        }

        private void Cartao_Shown(object sender, EventArgs e)
        {
            iniciaOperacao();
        }

        private void iniciaOperacao()
        {
            btCancelar.Visible = true;
            btCancelar.Enabled = true;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (tick_phase)
            {
                case 0:
                    rtbOperacao.Text = "Por favor, insira o cartão...";
                    tick_phase++;
                    break;

                case 1:
                    rtbOperacao.Text = "Por favor, insira o cartão.\n" +
                                        "Digite a senha...";
                    tick_phase++;
                    break;

                case 2:
                    rtbOperacao.Text = "Por favor, insira o cartão.\n" +
                                "Digite a senha.\n" +
                                "Operação bem sucedida, retire o cartão.";
                    tick_phase = 0;
                    btTerminar.Enabled = true;
                    btCancelar.Visible = false;
                    btCancelar.Enabled = false;
                    timer1.Stop();
                    break;
            }
        }

        private void btTerminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            rtbOperacao.Text = "";

            btCancelar.Visible = false;
            btCancelar.Enabled = false;
            btReiniciar.Visible = true;
            btReiniciar.Enabled = true;
        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            btReiniciar.Visible = false;
            btReiniciar.Enabled = false;
            btCancelar.Visible = true;
            btCancelar.Enabled = true;
            iniciaOperacao();
        }
    }
}
