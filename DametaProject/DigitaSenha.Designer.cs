namespace DametaProject
{
    partial class DigitaSenha
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLogar = new System.Windows.Forms.Button();
            this.lblFraseLogin = new System.Windows.Forms.Label();
            this.txConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Criar senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Confirme a senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Senha:";
            // 
            // btLogar
            // 
            this.btLogar.BackColor = System.Drawing.Color.YellowGreen;
            this.btLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogar.Location = new System.Drawing.Point(110, 270);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(150, 47);
            this.btLogar.TabIndex = 20;
            this.btLogar.Text = "Confirmar";
            this.btLogar.UseVisualStyleBackColor = false;
            this.btLogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFraseLogin
            // 
            this.lblFraseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFraseLogin.Location = new System.Drawing.Point(12, 68);
            this.lblFraseLogin.Name = "lblFraseLogin";
            this.lblFraseLogin.Size = new System.Drawing.Size(353, 16);
            this.lblFraseLogin.TabIndex = 21;
            this.lblFraseLogin.Text = "Digite sua senha e confirme para conclusão do cadastro\r\n\r\n\r\n";
            this.lblFraseLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txConfirmacaoSenha
            // 
            this.txConfirmacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConfirmacaoSenha.Location = new System.Drawing.Point(73, 202);
            this.txConfirmacaoSenha.MaxLength = 50;
            this.txConfirmacaoSenha.Name = "txConfirmacaoSenha";
            this.txConfirmacaoSenha.PasswordChar = '*';
            this.txConfirmacaoSenha.Size = new System.Drawing.Size(226, 23);
            this.txConfirmacaoSenha.TabIndex = 22;
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(73, 124);
            this.txSenha.MaxLength = 50;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(226, 23);
            this.txSenha.TabIndex = 0;
            // 
            // DigitaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 377);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txConfirmacaoSenha);
            this.Controls.Add(this.lblFraseLogin);
            this.Controls.Add(this.btLogar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DigitaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.Label lblFraseLogin;
        private System.Windows.Forms.TextBox txConfirmacaoSenha;
        private System.Windows.Forms.TextBox txSenha;
    }
}