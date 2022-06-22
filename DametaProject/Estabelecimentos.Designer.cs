namespace DametaProject
{
    partial class Estabelecimentos
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
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txRua = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEstabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txNome = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cidadesTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.cidadesTableAdapter();
            this.estabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.dtEstabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.dtEstabelecimentosTableAdapter();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.EstadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxCEP
            // 
            this.mtxCEP.ForeColor = System.Drawing.Color.Black;
            this.mtxCEP.Location = new System.Drawing.Point(417, 105);
            this.mtxCEP.Mask = "99999-999";
            this.mtxCEP.Name = "mtxCEP";
            this.mtxCEP.Size = new System.Drawing.Size(118, 20);
            this.mtxCEP.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 129;
            this.label3.Text = "CEP:";
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.ForeColor = System.Drawing.Color.Black;
            this.mtxTelefone.Location = new System.Drawing.Point(119, 185);
            this.mtxTelefone.Mask = "(99)99999-9999";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(118, 20);
            this.mtxTelefone.TabIndex = 128;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(53, 188);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 127;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // cbCidade
            // 
            this.cbCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cidadesBindingSource, "id", true));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(239, 147);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 21);
            this.cbCidade.TabIndex = 126;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "cidades";
            this.cidadesBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 125;
            this.label5.Text = "Cidade:";
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(435, 148);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(100, 20);
            this.txNumero.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "Número:";
            // 
            // txRua
            // 
            this.txRua.Location = new System.Drawing.Point(303, 185);
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(232, 20);
            this.txRua.TabIndex = 122;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(253, 185);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(30, 13);
            this.emailLabel.TabIndex = 121;
            this.emailLabel.Text = "Rua:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cidades,
            this.nomeruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dtEstabelecimentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(681, 207);
            this.dataGridView1.TabIndex = 115;
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
            this.cidades.HeaderText = "Cidades";
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
            // estabelecimentosBindingSource
            // 
            this.estabelecimentosBindingSource.DataMember = "estabelecimentos";
            this.estabelecimentosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(116, 105);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(244, 20);
            this.txNome.TabIndex = 114;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(53, 108);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 113;
            this.nomeLabel.Text = "Nome:";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(197, 40);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(53, 20);
            this.txID.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Codigo do estabelecimento:";
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // estabelecimentosTableAdapter
            // 
            this.estabelecimentosTableAdapter.ClearBeforeFill = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(637, 171);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(100, 40);
            this.btLimpar.TabIndex = 134;
            this.btLimpar.Text = "Limpar Form";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(637, 121);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 40);
            this.btExcluir.TabIndex = 133;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(637, 75);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(100, 40);
            this.btAlterar.TabIndex = 132;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(637, 29);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(100, 40);
            this.btIncluir.TabIndex = 131;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(269, 29);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(100, 40);
            this.btConsultar.TabIndex = 135;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // dtEstabelecimentosTableAdapter
            // 
            this.dtEstabelecimentosTableAdapter.ClearBeforeFill = true;
            // 
            // cbUF
            // 
            this.cbUF.DataSource = this.estadosBindingSource;
            this.cbUF.DisplayMember = "UF";
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(116, 147);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(48, 21);
            this.cbUF.TabIndex = 137;
            this.cbUF.ValueMember = "UF";
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 136;
            this.label4.Text = "UF:";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // Estabelecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.mtxCEP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txRua);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.label1);
            this.Name = "Estabelecimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estabelecimentos";
            this.Load += new System.EventHandler(this.Estabelecimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstabelecimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txRua;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Label label1;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private dameta_dbDataSetTableAdapters.cidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.BindingSource estabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter estabelecimentosTableAdapter;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.BindingSource dtEstabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.dtEstabelecimentosTableAdapter dtEstabelecimentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private dameta_dbDataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
    }
}