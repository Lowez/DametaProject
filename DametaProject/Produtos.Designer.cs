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
            this.dtProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtProdutoTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.dtProdutoTableAdapter();
            this.cod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtProdutoBindingSource)).BeginInit();
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
            this.btLimparForm.Location = new System.Drawing.Point(447, 165);
            this.btLimparForm.Name = "btLimparForm";
            this.btLimparForm.Size = new System.Drawing.Size(100, 40);
            this.btLimparForm.TabIndex = 32;
            this.btLimparForm.Text = "Limpar Form";
            this.btLimparForm.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(447, 116);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 40);
            this.btExcluir.TabIndex = 31;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(447, 67);
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
            this.btIncluir.Location = new System.Drawing.Point(447, 20);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(100, 40);
            this.btIncluir.TabIndex = 29;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_produto,
            this.nome,
            this.preco,
            this.tipo,
            this.qtd,
            this.fornecedor});
            this.dataGridView1.DataSource = this.dtProdutoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 207);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dtProdutoBindingSource
            // 
            this.dtProdutoBindingSource.DataMember = "dtProduto";
            this.dtProdutoBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // dtProdutoTableAdapter
            // 
            this.dtProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // cod_produto
            // 
            this.cod_produto.DataPropertyName = "cod_produto";
            this.cod_produto.HeaderText = "cod_produto";
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.Width = 80;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "preco";
            this.preco.Name = "preco";
            this.preco.Width = 50;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "qtd";
            this.qtd.HeaderText = "qtd";
            this.qtd.Name = "qtd";
            this.qtd.Width = 40;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "fornecedor";
            this.fornecedor.Name = "fornecedor";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 458);
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
            this.Load += new System.EventHandler(this.Produtos_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoprodutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProdutoBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.BindingSource fKPRODUTOSESTABELECIMENTOPRODUTOBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimento_produtoTableAdapter estabelecimento_produtoTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private dameta_dbDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.BindingSource tipoprodutosBindingSource;
        private dameta_dbDataSetTableAdapters.tipo_produtosTableAdapter tipo_produtosTableAdapter;
        private System.Windows.Forms.BindingSource dtProdutoBindingSource;
        private dameta_dbDataSetTableAdapters.dtProdutoTableAdapter dtProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
    }
}