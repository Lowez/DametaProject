namespace DametaProject
{
    partial class Cartao
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
            this.components = new System.ComponentModel.Container();
            this.lblCartao = new System.Windows.Forms.Label();
            this.rtbOperacao = new System.Windows.Forms.RichTextBox();
            this.btTerminar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartao.Location = new System.Drawing.Point(101, 22);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(160, 20);
            this.lblCartao.TabIndex = 0;
            this.lblCartao.Text = "[Crédito Selecionado]";
            // 
            // rtbOperacao
            // 
            this.rtbOperacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOperacao.Location = new System.Drawing.Point(25, 62);
            this.rtbOperacao.Name = "rtbOperacao";
            this.rtbOperacao.ReadOnly = true;
            this.rtbOperacao.Size = new System.Drawing.Size(312, 88);
            this.rtbOperacao.TabIndex = 2;
            this.rtbOperacao.Text = "";
            // 
            // btTerminar
            // 
            this.btTerminar.BackColor = System.Drawing.Color.YellowGreen;
            this.btTerminar.Enabled = false;
            this.btTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTerminar.Location = new System.Drawing.Point(105, 207);
            this.btTerminar.Name = "btTerminar";
            this.btTerminar.Size = new System.Drawing.Size(150, 47);
            this.btTerminar.TabIndex = 7;
            this.btTerminar.Text = "Terminar";
            this.btTerminar.UseVisualStyleBackColor = false;
            this.btTerminar.Click += new System.EventHandler(this.btTerminar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.Location = new System.Drawing.Point(105, 156);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(150, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // Cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 266);
            this.Controls.Add(this.btTerminar);
            this.Controls.Add(this.rtbOperacao);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.btCancelar);
            this.Name = "Cartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credito";
            this.Shown += new System.EventHandler(this.Cartao_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.RichTextBox rtbOperacao;
        private System.Windows.Forms.Button btTerminar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCancelar;
    }
}