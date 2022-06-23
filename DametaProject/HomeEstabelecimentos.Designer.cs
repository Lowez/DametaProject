namespace DametaProject
{
    partial class HomeEstabelecimentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgtdtEstabelecimentos = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEstabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.estabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter();
            this.btIncluir = new System.Windows.Forms.Button();
            this.dtEstabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.dtEstabelecimentosTableAdapter();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtdtEstabelecimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Incluir novo estabelecimento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgtdtEstabelecimentos);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 359);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estabelecimentos";
            // 
            // dgtdtEstabelecimentos
            // 
            this.dgtdtEstabelecimentos.AutoGenerateColumns = false;
            this.dgtdtEstabelecimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtdtEstabelecimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cidades,
            this.nomeruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dgtdtEstabelecimentos.DataSource = this.dtEstabelecimentosBindingSource;
            this.dgtdtEstabelecimentos.Location = new System.Drawing.Point(6, 43);
            this.dgtdtEstabelecimentos.Name = "dgtdtEstabelecimentos";
            this.dgtdtEstabelecimentos.ReadOnly = true;
            this.dgtdtEstabelecimentos.Size = new System.Drawing.Size(764, 310);
            this.dgtdtEstabelecimentos.TabIndex = 0;
            this.dgtdtEstabelecimentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtdtEstabelecimentos_CellDoubleClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 180;
            // 
            // cidades
            // 
            this.cidades.DataPropertyName = "cidades";
            this.cidades.HeaderText = "Cidade";
            this.cidades.Name = "cidades";
            this.cidades.ReadOnly = true;
            this.cidades.Width = 110;
            // 
            // nomeruaDataGridViewTextBoxColumn
            // 
            this.nomeruaDataGridViewTextBoxColumn.DataPropertyName = "nome_rua";
            this.nomeruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.nomeruaDataGridViewTextBoxColumn.Name = "nomeruaDataGridViewTextBoxColumn";
            this.nomeruaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeruaDataGridViewTextBoxColumn.Width = 180;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 50;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtEstabelecimentosBindingSource
            // 
            this.dtEstabelecimentosBindingSource.DataMember = "dtEstabelecimentos";
            this.dtEstabelecimentosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estabelecimentosBindingSource
            // 
            this.estabelecimentosBindingSource.DataMember = "estabelecimentos";
            this.estabelecimentosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // estabelecimentosTableAdapter
            // 
            this.estabelecimentosTableAdapter.ClearBeforeFill = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(166, 13);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(100, 40);
            this.btIncluir.TabIndex = 45;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // dtEstabelecimentosTableAdapter
            // 
            this.dtEstabelecimentosTableAdapter.ClearBeforeFill = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(484, 13);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(100, 40);
            this.btAtualizar.TabIndex = 47;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Atualizar lista de estabelecimentos:";
            // 
            // HomeEstabelecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomeEstabelecimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeEstabelecimentos";
            this.Load += new System.EventHandler(this.HomeEstabelecimentos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtdtEstabelecimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstabelecimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgtdtEstabelecimentos;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource estabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter estabelecimentosTableAdapter;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.BindingSource dtEstabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.dtEstabelecimentosTableAdapter dtEstabelecimentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label label2;
    }
}