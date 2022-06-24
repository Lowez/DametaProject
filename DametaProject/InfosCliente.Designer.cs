namespace DametaProject
{
    partial class InfosCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfosCliente));
            this.btConfirmar = new System.Windows.Forms.Button();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDataNascimento = new System.Windows.Forms.TextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTentarNovamente = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.YellowGreen;
            this.btConfirmar.Location = new System.Drawing.Point(76, 248);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(124, 47);
            this.btConfirmar.TabIndex = 0;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(31, 41);
            this.txNome.Name = "txNome";
            this.txNome.ReadOnly = true;
            this.txNome.Size = new System.Drawing.Size(215, 20);
            this.txNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Nascimento:";
            // 
            // txDataNascimento
            // 
            this.txDataNascimento.Location = new System.Drawing.Point(31, 95);
            this.txDataNascimento.Name = "txDataNascimento";
            this.txDataNascimento.ReadOnly = true;
            this.txDataNascimento.Size = new System.Drawing.Size(215, 20);
            this.txDataNascimento.TabIndex = 3;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCPF.Location = new System.Drawing.Point(31, 143);
            this.mtxCPF.Mask = "999,999,999-99";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.ReadOnly = true;
            this.mtxCPF.Size = new System.Drawing.Size(215, 23);
            this.mtxCPF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF:";
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTelefone.Location = new System.Drawing.Point(31, 192);
            this.mtxTelefone.Mask = "(99)99999-9999";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.ReadOnly = true;
            this.mtxTelefone.Size = new System.Drawing.Size(215, 23);
            this.mtxTelefone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone:";
            // 
            // lblTentarNovamente
            // 
            this.lblTentarNovamente.Location = new System.Drawing.Point(79, 298);
            this.lblTentarNovamente.Name = "lblTentarNovamente";
            this.lblTentarNovamente.Size = new System.Drawing.Size(121, 23);
            this.lblTentarNovamente.TabIndex = 11;
            this.lblTentarNovamente.TabStop = true;
            this.lblTentarNovamente.Text = "Tentar novamente";
            this.lblTentarNovamente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTentarNovamente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTentarNovamente_LinkClicked);
            // 
            // InfosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 337);
            this.Controls.Add(this.lblTentarNovamente);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.btConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infos Usuário Premium ";
            this.Load += new System.EventHandler(this.InfosCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblTentarNovamente;
    }
}