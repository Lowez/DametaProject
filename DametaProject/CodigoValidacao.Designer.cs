namespace DametaProject
{
    partial class CodigoValidacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoValidacao));
            this.mtxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.btValidarCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxCodigo
            // 
            this.mtxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCodigo.Location = new System.Drawing.Point(77, 89);
            this.mtxCodigo.Mask = "9 9 9 9 9";
            this.mtxCodigo.Name = "mtxCodigo";
            this.mtxCodigo.Size = new System.Drawing.Size(124, 41);
            this.mtxCodigo.TabIndex = 0;
            // 
            // btValidarCodigo
            // 
            this.btValidarCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btValidarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValidarCodigo.Location = new System.Drawing.Point(95, 152);
            this.btValidarCodigo.Name = "btValidarCodigo";
            this.btValidarCodigo.Size = new System.Drawing.Size(98, 43);
            this.btValidarCodigo.TabIndex = 12;
            this.btValidarCodigo.Text = "Validar";
            this.btValidarCodigo.UseVisualStyleBackColor = false;
            this.btValidarCodigo.Click += new System.EventHandler(this.btValidarCodigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Insira o código que recebeu em seu e-mail:";
            // 
            // CodigoValidacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btValidarCodigo);
            this.Controls.Add(this.mtxCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodigoValidacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de Validacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxCodigo;
        private System.Windows.Forms.Button btValidarCodigo;
        private System.Windows.Forms.Label label1;
    }
}