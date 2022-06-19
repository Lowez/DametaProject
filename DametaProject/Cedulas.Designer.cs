namespace DametaProject
{
    partial class Cedulas
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
            this.txValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txValorPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTroco = new System.Windows.Forms.TextBox();
            this.btTerminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txValorTotal
            // 
            this.txValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValorTotal.Location = new System.Drawing.Point(22, 44);
            this.txValorTotal.Name = "txValorTotal";
            this.txValorTotal.ReadOnly = true;
            this.txValorTotal.Size = new System.Drawing.Size(150, 22);
            this.txValorTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor pago:";
            // 
            // txValorPago
            // 
            this.txValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValorPago.Location = new System.Drawing.Point(197, 44);
            this.txValorPago.Name = "txValorPago";
            this.txValorPago.Size = new System.Drawing.Size(150, 22);
            this.txValorPago.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Troco a devolver:";
            // 
            // txTroco
            // 
            this.txTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTroco.Location = new System.Drawing.Point(107, 138);
            this.txTroco.Name = "txTroco";
            this.txTroco.ReadOnly = true;
            this.txTroco.Size = new System.Drawing.Size(150, 22);
            this.txTroco.TabIndex = 3;
            // 
            // btTerminar
            // 
            this.btTerminar.BackColor = System.Drawing.Color.YellowGreen;
            this.btTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTerminar.Location = new System.Drawing.Point(107, 191);
            this.btTerminar.Name = "btTerminar";
            this.btTerminar.Size = new System.Drawing.Size(150, 47);
            this.btTerminar.TabIndex = 2;
            this.btTerminar.Text = "Terminar";
            this.btTerminar.UseVisualStyleBackColor = false;
            this.btTerminar.Click += new System.EventHandler(this.btTerminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "_______________________________________________________";
            // 
            // Cedulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btTerminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txTroco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txValorPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txValorTotal);
            this.Name = "Cedulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento em Cédulas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txValorPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txTroco;
        private System.Windows.Forms.Button btTerminar;
        private System.Windows.Forms.Label label4;
    }
}