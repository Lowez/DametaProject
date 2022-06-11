namespace DametaProject
{
    partial class PremiumUserCheck
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
            this.cbxPremiumUser = new System.Windows.Forms.CheckBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxPremiumUser
            // 
            this.cbxPremiumUser.AutoSize = true;
            this.cbxPremiumUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPremiumUser.Location = new System.Drawing.Point(58, 34);
            this.cbxPremiumUser.Name = "cbxPremiumUser";
            this.cbxPremiumUser.Size = new System.Drawing.Size(210, 24);
            this.cbxPremiumUser.TabIndex = 1;
            this.cbxPremiumUser.Text = "Usuário Premium Dameta";
            this.cbxPremiumUser.UseVisualStyleBackColor = true;
            this.cbxPremiumUser.CheckedChanged += new System.EventHandler(this.cbxPremiumUser_CheckedChanged);
            // 
            // mtxCPF
            // 
            this.mtxCPF.Enabled = false;
            this.mtxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCPF.Location = new System.Drawing.Point(125, 77);
            this.mtxCPF.Mask = "999,999,999-99";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(120, 26);
            this.mtxCPF.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Enabled = false;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(75, 80);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            // 
            // btContinuar
            // 
            this.btContinuar.BackColor = System.Drawing.Color.YellowGreen;
            this.btContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinuar.Location = new System.Drawing.Point(109, 122);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(114, 40);
            this.btContinuar.TabIndex = 4;
            this.btContinuar.Text = "Continuar";
            this.btContinuar.UseVisualStyleBackColor = false;
            this.btContinuar.Click += new System.EventHandler(this.btContinuar_Click);
            // 
            // PremiumUserCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 187);
            this.Controls.Add(this.btContinuar);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.cbxPremiumUser);
            this.Name = "PremiumUserCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PremiumUserCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPremiumUser;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btContinuar;
    }
}