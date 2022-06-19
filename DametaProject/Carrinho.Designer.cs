namespace DametaProject
{
    partial class Carrinho
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
            this.dvgCarrinho = new System.Windows.Forms.DataGridView();
            this.Código_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.btConcluirCompra = new System.Windows.Forms.Button();
            this.txCodigoProd = new System.Windows.Forms.TextBox();
            this.lblCodigoProd = new System.Windows.Forms.Label();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txValorParcial = new System.Windows.Forms.TextBox();
            this.txValorUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.rbtQtd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txTipoProd = new System.Windows.Forms.TextBox();
            this.txQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txNomeProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalItens = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgCarrinho
            // 
            this.dvgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código_Produto,
            this.Nome,
            this.Qtd,
            this.ValorUnit,
            this.ValorParcial});
            this.dvgCarrinho.Location = new System.Drawing.Point(446, 12);
            this.dvgCarrinho.Name = "dvgCarrinho";
            this.dvgCarrinho.Size = new System.Drawing.Size(569, 465);
            this.dvgCarrinho.TabIndex = 0;
            // 
            // Código_Produto
            // 
            this.Código_Produto.HeaderText = "Código_Produto";
            this.Código_Produto.Name = "Código_Produto";
            this.Código_Produto.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 175;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.Width = 50;
            // 
            // ValorUnit
            // 
            this.ValorUnit.HeaderText = "ValorUnit";
            this.ValorUnit.Name = "ValorUnit";
            // 
            // ValorParcial
            // 
            this.ValorParcial.HeaderText = "ValorParcial";
            this.ValorParcial.Name = "ValorParcial";
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btConcluirCompra
            // 
            this.btConcluirCompra.BackColor = System.Drawing.Color.YellowGreen;
            this.btConcluirCompra.Location = new System.Drawing.Point(821, 503);
            this.btConcluirCompra.Name = "btConcluirCompra";
            this.btConcluirCompra.Size = new System.Drawing.Size(193, 38);
            this.btConcluirCompra.TabIndex = 7;
            this.btConcluirCompra.Text = "Concluir";
            this.btConcluirCompra.UseVisualStyleBackColor = false;
            this.btConcluirCompra.Click += new System.EventHandler(this.btConcluirCompra_Click);
            // 
            // txCodigoProd
            // 
            this.txCodigoProd.Location = new System.Drawing.Point(19, 53);
            this.txCodigoProd.Name = "txCodigoProd";
            this.txCodigoProd.Size = new System.Drawing.Size(166, 20);
            this.txCodigoProd.TabIndex = 1;
            // 
            // lblCodigoProd
            // 
            this.lblCodigoProd.AutoSize = true;
            this.lblCodigoProd.Location = new System.Drawing.Point(16, 35);
            this.lblCodigoProd.Name = "lblCodigoProd";
            this.lblCodigoProd.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoProd.TabIndex = 3;
            this.lblCodigoProd.Text = "Código do Produto";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Location = new System.Drawing.Point(16, 91);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(90, 13);
            this.lblNomeProd.TabIndex = 5;
            this.lblNomeProd.Text = "Nome do Produto";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(214, 50);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(103, 23);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "Buscar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(939, 480);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 20);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(903, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "R$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txValorParcial);
            this.groupBox1.Controls.Add(this.txValorUnit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btRemover);
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.rbtQtd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txTipoProd);
            this.groupBox1.Controls.Add(this.txQtd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txNomeProd);
            this.groupBox1.Controls.Add(this.txCodigoProd);
            this.groupBox1.Controls.Add(this.lblCodigoProd);
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.lblNomeProd);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 335);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto à adicionar";
            // 
            // lblDiv
            // 
            this.lblDiv.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDiv.Location = new System.Drawing.Point(6, 197);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(394, 23);
            this.lblDiv.TabIndex = 22;
            this.lblDiv.Text = "_____________________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor Parcial";
            // 
            // txValorParcial
            // 
            this.txValorParcial.Location = new System.Drawing.Point(214, 236);
            this.txValorParcial.Name = "txValorParcial";
            this.txValorParcial.ReadOnly = true;
            this.txValorParcial.Size = new System.Drawing.Size(75, 20);
            this.txValorParcial.TabIndex = 0;
            // 
            // txValorUnit
            // 
            this.txValorUnit.Location = new System.Drawing.Point(19, 168);
            this.txValorUnit.Name = "txValorUnit";
            this.txValorUnit.ReadOnly = true;
            this.txValorUnit.Size = new System.Drawing.Size(166, 20);
            this.txValorUnit.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Valor Unitário";
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btRemover.Location = new System.Drawing.Point(214, 287);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 5;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.YellowGreen;
            this.btAdicionar.Location = new System.Drawing.Point(110, 287);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 4;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            // 
            // rbtQtd
            // 
            this.rbtQtd.AutoSize = true;
            this.rbtQtd.Checked = true;
            this.rbtQtd.Location = new System.Drawing.Point(100, 171);
            this.rbtQtd.Name = "rbtQtd";
            this.rbtQtd.Size = new System.Drawing.Size(14, 13);
            this.rbtQtd.TabIndex = 12;
            this.rbtQtd.TabStop = true;
            this.rbtQtd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo do Produto";
            // 
            // txTipoProd
            // 
            this.txTipoProd.Location = new System.Drawing.Point(214, 107);
            this.txTipoProd.Name = "txTipoProd";
            this.txTipoProd.ReadOnly = true;
            this.txTipoProd.Size = new System.Drawing.Size(166, 20);
            this.txTipoProd.TabIndex = 0;
            // 
            // txQtd
            // 
            this.txQtd.Location = new System.Drawing.Point(110, 236);
            this.txQtd.Name = "txQtd";
            this.txQtd.Size = new System.Drawing.Size(75, 20);
            this.txQtd.TabIndex = 3;
            this.txQtd.TextChanged += new System.EventHandler(this.txQtd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qtd/Peso";
            // 
            // txNomeProd
            // 
            this.txNomeProd.Location = new System.Drawing.Point(19, 107);
            this.txNomeProd.Name = "txNomeProd";
            this.txNomeProd.ReadOnly = true;
            this.txNomeProd.Size = new System.Drawing.Size(166, 20);
            this.txNomeProd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total de Itens:";
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItens.Location = new System.Drawing.Point(575, 480);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(57, 20);
            this.lblTotalItens.TabIndex = 11;
            this.lblTotalItens.Text = "0";
            this.lblTotalItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSair.Location = new System.Drawing.Point(15, 503);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(193, 38);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1027, 555);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lblTotalItens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btConcluirCompra);
            this.Controls.Add(this.dvgCarrinho);
            this.Controls.Add(this.groupBox1);
            this.Enabled = false;
            this.Name = "Carrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem vindo(a) [Nome do Usuário]";
            this.Shown += new System.EventHandler(this.Carrinho_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCarrinho;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.Button btConcluirCompra;
        private System.Windows.Forms.TextBox txCodigoProd;
        private System.Windows.Forms.Label lblCodigoProd;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalItens;
        private System.Windows.Forms.TextBox txNomeProd;
        private System.Windows.Forms.RadioButton rbtQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTipoProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txValorParcial;
        private System.Windows.Forms.TextBox txValorUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorParcial;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.TextBox txQtd;
    }
}