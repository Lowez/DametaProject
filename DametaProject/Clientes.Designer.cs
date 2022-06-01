namespace DametaProject
{
    partial class Clientes
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
            this.txID = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.txUF = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.dametadbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premiumusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premium_usuariosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.premium_usuariosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dametadbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumusuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(151, 40);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(53, 20);
            this.txID.TabIndex = 17;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(210, 30);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 38);
            this.btConsultar.TabIndex = 27;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "UF:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.premiumusuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 207);
            this.dataGridView1.TabIndex = 26;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(99, 88);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(301, 20);
            this.txNome.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cidade:";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(99, 129);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(118, 20);
            this.mtxCPF.TabIndex = 22;
            // 
            // cbCidade
            // 
            this.cbCidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cidadesBindingSource, "ID_Cidade", true));
            this.cbCidade.DataSource = this.cidadesBindingSource;
            this.cbCidade.DisplayMember = "NomeCid";
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(101, 173);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 21);
            this.cbCidade.TabIndex = 23;
            this.cbCidade.ValueMember = "ID_Cidade";
            // 
            // txUF
            // 
            this.txUF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "UF", true));
            this.txUF.Location = new System.Drawing.Point(302, 173);
            this.txUF.Name = "txUF";
            this.txUF.Size = new System.Drawing.Size(37, 20);
            this.txUF.TabIndex = 25;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(598, 30);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 38);
            this.btLimpar.TabIndex = 51;
            this.btLimpar.Text = "Limpar Form";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(598, 74);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 38);
            this.btExcluir.TabIndex = 50;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(504, 74);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 38);
            this.btAlterar.TabIndex = 49;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(504, 30);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 38);
            this.btIncluir.TabIndex = 48;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dametadbDataSetBindingSource
            // 
            this.dametadbDataSetBindingSource.DataSource = this.dameta_dbDataSet;
            this.dametadbDataSetBindingSource.Position = 0;
            // 
            // premiumusuariosBindingSource
            // 
            this.premiumusuariosBindingSource.DataMember = "premium_usuarios";
            this.premiumusuariosBindingSource.DataSource = this.dametadbDataSetBindingSource;
            // 
            // premium_usuariosTableAdapter
            // 
            this.premium_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 440);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txUF);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dametadbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumusuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.TextBox txUF;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.BindingSource dametadbDataSetBindingSource;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource premiumusuariosBindingSource;
        private dameta_dbDataSetTableAdapters.premium_usuariosTableAdapter premium_usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
    }
}