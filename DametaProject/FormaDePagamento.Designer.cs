namespace DametaProject
{
    partial class FormaDePagamento
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
            this.btCartao = new System.Windows.Forms.Button();
            this.btDinheiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btDebito = new System.Windows.Forms.Button();
            this.btCredito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCartao
            // 
            this.btCartao.BackColor = System.Drawing.Color.Khaki;
            this.btCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCartao.Location = new System.Drawing.Point(98, 125);
            this.btCartao.Name = "btCartao";
            this.btCartao.Size = new System.Drawing.Size(299, 65);
            this.btCartao.TabIndex = 0;
            this.btCartao.Text = "Cartão";
            this.btCartao.UseVisualStyleBackColor = false;
            this.btCartao.Click += new System.EventHandler(this.btCartao_Click);
            // 
            // btDinheiro
            // 
            this.btDinheiro.BackColor = System.Drawing.Color.YellowGreen;
            this.btDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDinheiro.Location = new System.Drawing.Point(98, 228);
            this.btDinheiro.Name = "btDinheiro";
            this.btDinheiro.Size = new System.Drawing.Size(299, 65);
            this.btDinheiro.TabIndex = 2;
            this.btDinheiro.Text = "Cédulas";
            this.btDinheiro.UseVisualStyleBackColor = false;
            this.btDinheiro.Click += new System.EventHandler(this.btDinheiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forma de Pagamento:";
            // 
            // btDebito
            // 
            this.btDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDebito.Location = new System.Drawing.Point(329, 160);
            this.btDebito.Name = "btDebito";
            this.btDebito.Size = new System.Drawing.Size(99, 30);
            this.btDebito.TabIndex = 4;
            this.btDebito.Text = "Débito";
            this.btDebito.UseVisualStyleBackColor = true;
            this.btDebito.Visible = false;
            this.btDebito.Click += new System.EventHandler(this.btDebito_Click);
            // 
            // btCredito
            // 
            this.btCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCredito.Location = new System.Drawing.Point(329, 189);
            this.btCredito.Name = "btCredito";
            this.btCredito.Size = new System.Drawing.Size(99, 30);
            this.btCredito.TabIndex = 5;
            this.btCredito.Text = "Crédito";
            this.btCredito.UseVisualStyleBackColor = true;
            this.btCredito.Visible = false;
            this.btCredito.Click += new System.EventHandler(this.btCredito_Click);
            // 
            // FormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 351);
            this.Controls.Add(this.btCredito);
            this.Controls.Add(this.btDebito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDinheiro);
            this.Controls.Add(this.btCartao);
            this.Name = "FormaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaDePagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCartao;
        private System.Windows.Forms.Button btDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDebito;
        private System.Windows.Forms.Button btCredito;
    }
}