namespace DametaProject
{
    partial class ResetSenha
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEnviarEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Para mudar sua senha digite seu e-mail no campo abaixo.\r\nCaso ele for válido, ire" +
    "mos lhe enviar um e-mail com um código\r\npara redefinir sua senha.\r\n";
            // 
            // btEnviarEmail
            // 
            this.btEnviarEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnviarEmail.Location = new System.Drawing.Point(114, 108);
            this.btEnviarEmail.Name = "btEnviarEmail";
            this.btEnviarEmail.Size = new System.Drawing.Size(98, 43);
            this.btEnviarEmail.TabIndex = 11;
            this.btEnviarEmail.Text = "Enviar";
            this.btEnviarEmail.UseVisualStyleBackColor = false;
            this.btEnviarEmail.Click += new System.EventHandler(this.btEnviarEmail_Click);
            // 
            // ResetSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 163);
            this.Controls.Add(this.btEnviarEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ResetSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueceu sua senha?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEnviarEmail;
    }
}