﻿namespace DametaProject
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogar = new System.Windows.Forms.Button();
            this.lblResetSenha = new System.Windows.Forms.LinkLabel();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblIncorreto = new System.Windows.Forms.Label();
            this.lblFraseLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(74, 205);
            this.txSenha.MaxLength = 50;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(226, 23);
            this.txSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // btLogar
            // 
            this.btLogar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogar.Location = new System.Drawing.Point(138, 269);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(98, 43);
            this.btLogar.TabIndex = 3;
            this.btLogar.Text = "Entrar";
            this.btLogar.UseVisualStyleBackColor = false;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // lblResetSenha
            // 
            this.lblResetSenha.AutoSize = true;
            this.lblResetSenha.Location = new System.Drawing.Point(131, 325);
            this.lblResetSenha.Name = "lblResetSenha";
            this.lblResetSenha.Size = new System.Drawing.Size(113, 13);
            this.lblResetSenha.TabIndex = 4;
            this.lblResetSenha.TabStop = true;
            this.lblResetSenha.Text = "Esqueceu sua senha?";
            this.lblResetSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblResetSenha_LinkClicked);
            // 
            // mtxCPF
            // 
            this.mtxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCPF.Location = new System.Drawing.Point(74, 127);
            this.mtxCPF.Mask = "999,999,999-99";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(226, 23);
            this.mtxCPF.TabIndex = 1;
            // 
            // lblIncorreto
            // 
            this.lblIncorreto.AutoSize = true;
            this.lblIncorreto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblIncorreto.Location = new System.Drawing.Point(125, 243);
            this.lblIncorreto.Name = "lblIncorreto";
            this.lblIncorreto.Size = new System.Drawing.Size(125, 13);
            this.lblIncorreto.TabIndex = 5;
            this.lblIncorreto.Text = "CPF ou Senha incorretos";
            this.lblIncorreto.Visible = false;
            // 
            // lblFraseLogin
            // 
            this.lblFraseLogin.AutoSize = true;
            this.lblFraseLogin.Font = new System.Drawing.Font("Noto Sans Hebrew", 9.75F);
            this.lblFraseLogin.Location = new System.Drawing.Point(28, 57);
            this.lblFraseLogin.Name = "lblFraseLogin";
            this.lblFraseLogin.Size = new System.Drawing.Size(319, 18);
            this.lblFraseLogin.TabIndex = 6;
            this.lblFraseLogin.Text = "Por favor, entre com seu Usuário Operador de Caixa";
            this.lblFraseLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 377);
            this.Controls.Add(this.lblFraseLogin);
            this.Controls.Add(this.lblIncorreto);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.lblResetSenha);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txSenha);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginSalesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.LinkLabel lblResetSenha;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label lblIncorreto;
        private System.Windows.Forms.Label lblFraseLogin;
    }
}