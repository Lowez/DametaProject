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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.btLimparForm = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoprodutosidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tipoprodutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txPrecoUnit = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txID = new System.Windows.Forms.TextBox();
            this.txQtdEstoque = new System.Windows.Forms.TextBox();
            this.produtosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.produtosTableAdapter();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estabelecimento_produtoTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.estabelecimento_produtoTableAdapter();
            this.fornecedoresTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.fornecedoresTableAdapter();
            this.tipo_produtosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.tipo_produtosTableAdapter();
            categoriaLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            CodigoProdutoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoprodutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(230, 174);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(85, 13);
            categoriaLabel.TabIndex = 25;
            categoriaLabel.Text = "Tipo do produto:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(30, 131);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(60, 13);
            precoUnitLabel.TabIndex = 23;
            precoUnitLabel.Text = "Preco Unit:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(30, 90);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 20;
            nomeLabel.Text = "Nome:";
            // 
            // CodigoProdutoLabel
            // 
            CodigoProdutoLabel.AutoSize = true;
            CodigoProdutoLabel.Location = new System.Drawing.Point(30, 43);
            CodigoProdutoLabel.Name = "CodigoProdutoLabel";
            CodigoProdutoLabel.Size = new System.Drawing.Size(101, 13);
            CodigoProdutoLabel.TabIndex = 19;
            CodigoProdutoLabel.Text = "Codigo do Produto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(230, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 13);
            label2.TabIndex = 35;
            label2.Text = "Qtd em estoque:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 174);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 13);
            label1.TabIndex = 37;
            label1.Text = "Fornecedor:";
            // 
            // btLimparForm
            // 
            this.btLimparForm.Location = new System.Drawing.Point(680, 174);
            this.btLimparForm.Name = "btLimparForm";
            this.btLimparForm.Size = new System.Drawing.Size(100, 40);
            this.btLimparForm.TabIndex = 32;
            this.btLimparForm.Text = "Limpar Form";
            this.btLimparForm.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(680, 125);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 40);
            this.btExcluir.TabIndex = 31;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(680, 76);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(100, 40);
            this.btAlterar.TabIndex = 30;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(233, 29);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(100, 40);
            this.btConsultar.TabIndex = 28;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(680, 29);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(100, 40);
            this.btIncluir.TabIndex = 29;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprodutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.tipoprodutosidDataGridViewTextBoxColumn,
            this.fornecedoresidDataGridViewTextBoxColumn,
            this.estoqueidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 207);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codprodutoDataGridViewTextBoxColumn
            // 
            this.codprodutoDataGridViewTextBoxColumn.DataPropertyName = "cod_produto";
            this.codprodutoDataGridViewTextBoxColumn.HeaderText = "Codigo do Produto";
            this.codprodutoDataGridViewTextBoxColumn.Name = "codprodutoDataGridViewTextBoxColumn";
            this.codprodutoDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 120;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço Unit";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.Width = 120;
            // 
            // tipoprodutosidDataGridViewTextBoxColumn
            // 
            this.tipoprodutosidDataGridViewTextBoxColumn.DataPropertyName = "tipo_produtos_id";
            this.tipoprodutosidDataGridViewTextBoxColumn.HeaderText = "Tipo do produto";
            this.tipoprodutosidDataGridViewTextBoxColumn.Name = "tipoprodutosidDataGridViewTextBoxColumn";
            this.tipoprodutosidDataGridViewTextBoxColumn.Width = 120;
            // 
            // fornecedoresidDataGridViewTextBoxColumn
            // 
            this.fornecedoresidDataGridViewTextBoxColumn.DataPropertyName = "fornecedores_id";
            this.fornecedoresidDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedoresidDataGridViewTextBoxColumn.Name = "fornecedoresidDataGridViewTextBoxColumn";
            this.fornecedoresidDataGridViewTextBoxColumn.Width = 120;
            // 
            // estoqueidDataGridViewTextBoxColumn
            // 
            this.estoqueidDataGridViewTextBoxColumn.DataPropertyName = "estoque_id";
            this.estoqueidDataGridViewTextBoxColumn.HeaderText = "Qtd em estoque";
            this.estoqueidDataGridViewTextBoxColumn.Name = "estoqueidDataGridViewTextBoxColumn";
            this.estoqueidDataGridViewTextBoxColumn.Width = 120;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            this.produtosBindingSource1.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            // 
            // cbTipo
            // 
            this.cbTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoprodutosBindingSource, "nome", true));
            this.cbTipo.DataSource = this.tipoprodutosBindingSource;
            this.cbTipo.DisplayMember = "nome";
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(317, 171);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(112, 21);
            this.cbTipo.TabIndex = 26;
            this.cbTipo.ValueMember = "id";
            // 
            // tipoprodutosBindingSource
            // 
            this.tipoprodutosBindingSource.DataMember = "tipo_produtos";
            this.tipoprodutosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // txPrecoUnit
            // 
            this.txPrecoUnit.Location = new System.Drawing.Point(100, 128);
            this.txPrecoUnit.Name = "txPrecoUnit";
            this.txPrecoUnit.Size = new System.Drawing.Size(121, 20);
            this.txPrecoUnit.TabIndex = 24;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(100, 87);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(329, 20);
            this.txNome.TabIndex = 22;
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(127, 40);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(94, 20);
            this.txID.TabIndex = 21;
            // 
            // txQtdEstoque
            // 
            this.txQtdEstoque.Location = new System.Drawing.Point(317, 128);
            this.txQtdEstoque.Name = "txQtdEstoque";
            this.txQtdEstoque.Size = new System.Drawing.Size(112, 20);
            this.txQtdEstoque.TabIndex = 36;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedoresBindingSource, "nome", true));
            this.cbFornecedor.DataSource = this.fornecedoresBindingSource;
            this.cbFornecedor.DisplayMember = "nome";
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(100, 171);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cbFornecedor.TabIndex = 38;
            this.cbFornecedor.ValueMember = "id";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource
            // 
            this.fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource.DataMember = "FK_PRODUTOS_ESTABELECIMENTOPRODUTO";
            this.fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource.DataSource = this.produtosBindingSource1;
            // 
            // estabelecimento_produtoTableAdapter
            // 
            this.estabelecimento_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_produtosTableAdapter
            // 
            this.tipo_produtosTableAdapter.ClearBeforeFill = true;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(label1);
            this.Controls.Add(this.txQtdEstoque);
            this.Controls.Add(label2);
            this.Controls.Add(this.btLimparForm);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(precoUnitLabel);
            this.Controls.Add(this.txPrecoUnit);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txID);
            this.Controls.Add(CodigoProdutoLabel);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoprodutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txPrecoUnit;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.TextBox txQtdEstoque;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private dameta_dbDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoprodutosidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedoresidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.BindingSource fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimento_produtoTableAdapter estabelecimento_produtoTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private dameta_dbDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.BindingSource tipoprodutosBindingSource;
        private dameta_dbDataSetTableAdapters.tipo_produtosTableAdapter tipo_produtosTableAdapter;
    }
}