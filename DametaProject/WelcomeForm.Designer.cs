namespace DametaProject
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.btAcessoCaixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAcessoAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAcessoCaixa
            // 
            this.btAcessoCaixa.BackColor = System.Drawing.Color.LightGray;
            this.btAcessoCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAcessoCaixa.ForeColor = System.Drawing.SystemColors.Window;
            this.btAcessoCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btAcessoCaixa.Image")));
            this.btAcessoCaixa.Location = new System.Drawing.Point(210, 217);
            this.btAcessoCaixa.Name = "btAcessoCaixa";
            this.btAcessoCaixa.Size = new System.Drawing.Size(140, 140);
            this.btAcessoCaixa.TabIndex = 0;
            this.btAcessoCaixa.UseVisualStyleBackColor = false;
            this.btAcessoCaixa.Click += new System.EventHandler(this.btAcessoCaixa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrador";
            // 
            // btAcessoAdmin
            // 
            this.btAcessoAdmin.BackColor = System.Drawing.Color.LightGray;
            this.btAcessoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAcessoAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btAcessoAdmin.Image")));
            this.btAcessoAdmin.Location = new System.Drawing.Point(465, 217);
            this.btAcessoAdmin.Name = "btAcessoAdmin";
            this.btAcessoAdmin.Size = new System.Drawing.Size(140, 140);
            this.btAcessoAdmin.TabIndex = 1;
            this.btAcessoAdmin.UseVisualStyleBackColor = false;
            this.btAcessoAdmin.Click += new System.EventHandler(this.btAcessoAdmin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "O que gostaria de acessar?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "SuperMercado Dameta";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcessoAdmin);
            this.Controls.Add(this.btAcessoCaixa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-Vindo(a)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAcessoCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAcessoAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

