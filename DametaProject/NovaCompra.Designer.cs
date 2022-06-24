namespace DametaProject
{
    partial class NovaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaCompra));
            this.btNovaCompra = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNovaCompra
            // 
            this.btNovaCompra.BackColor = System.Drawing.Color.YellowGreen;
            this.btNovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaCompra.Location = new System.Drawing.Point(27, 88);
            this.btNovaCompra.Name = "btNovaCompra";
            this.btNovaCompra.Size = new System.Drawing.Size(137, 57);
            this.btNovaCompra.TabIndex = 0;
            this.btNovaCompra.Text = "Nova Compra";
            this.btNovaCompra.UseVisualStyleBackColor = false;
            this.btNovaCompra.Click += new System.EventHandler(this.btNovaCompra_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(202, 88);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(137, 57);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "O que gostaria de fazer?";
            // 
            // NovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btNovaCompra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovaCompra;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label1;
    }
}