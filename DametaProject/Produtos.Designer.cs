namespace DametaProject
{
    partial class Produtos
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
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label CodigoProdutoLabel;
            this.btLimparForm = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txPrecoUnit = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txCodigoProduto = new System.Windows.Forms.TextBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            categoriaLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            CodigoProdutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(14, 107);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(55, 13);
            categoriaLabel.TabIndex = 25;
            categoriaLabel.Text = "Categoria:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(14, 81);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(60, 13);
            precoUnitLabel.TabIndex = 23;
            precoUnitLabel.Text = "Preco Unit:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(14, 52);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 20;
            nomeLabel.Text = "Nome:";
            // 
            // CodigoProdutoLabel
            // 
            CodigoProdutoLabel.AutoSize = true;
            CodigoProdutoLabel.Location = new System.Drawing.Point(14, 22);
            CodigoProdutoLabel.Name = "CodigoProdutoLabel";
            CodigoProdutoLabel.Size = new System.Drawing.Size(101, 13);
            CodigoProdutoLabel.TabIndex = 19;
            CodigoProdutoLabel.Text = "Codigo do Produto: ";
            // 
            // btLimparForm
            // 
            this.btLimparForm.Location = new System.Drawing.Point(487, 81);
            this.btLimparForm.Name = "btLimparForm";
            this.btLimparForm.Size = new System.Drawing.Size(86, 34);
            this.btLimparForm.TabIndex = 32;
            this.btLimparForm.Text = "Limpar Form";
            this.btLimparForm.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(487, 41);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(86, 34);
            this.btExcluir.TabIndex = 31;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(384, 81);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(86, 34);
            this.btAlterar.TabIndex = 30;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(202, 15);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(98, 28);
            this.btConsultar.TabIndex = 28;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(384, 41);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(86, 34);
            this.btIncluir.TabIndex = 29;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.produtosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(596, 181);
            this.dataGridView1.TabIndex = 27;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "CPU",
            "GPU",
            "Monitor",
            "SSD"});
            this.cbCategoria.Location = new System.Drawing.Point(75, 107);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 26;
            // 
            // txPrecoUnit
            // 
            this.txPrecoUnit.Location = new System.Drawing.Point(75, 78);
            this.txPrecoUnit.Name = "txPrecoUnit";
            this.txPrecoUnit.Size = new System.Drawing.Size(121, 20);
            this.txPrecoUnit.TabIndex = 24;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(75, 49);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(225, 20);
            this.txNome.TabIndex = 22;
            // 
            // txCodigoProduto
            // 
            this.txCodigoProduto.Location = new System.Drawing.Point(111, 19);
            this.txCodigoProduto.Name = "txCodigoProduto";
            this.txCodigoProduto.Size = new System.Drawing.Size(85, 20);
            this.txCodigoProduto.TabIndex = 21;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 351);
            this.Controls.Add(this.btLimparForm);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(precoUnitLabel);
            this.Controls.Add(this.txPrecoUnit);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txCodigoProduto);
            this.Controls.Add(CodigoProdutoLabel);
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimparForm;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txPrecoUnit;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txCodigoProduto;
    }
}