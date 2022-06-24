namespace DametaProject
{
    partial class Estoque
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.controleDeEstoqueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.controleDeEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleDeEstoqueTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.ControleDeEstoqueTableAdapter();
            this.GerarRelatorio = new System.Windows.Forms.Button();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.estabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FornecedoresEstabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioDeFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleDeEstoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresEstabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDeFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // controleDeEstoqueBindingSource2
            // 
            this.controleDeEstoqueBindingSource2.DataMember = "ControleDeEstoque";
            this.controleDeEstoqueBindingSource2.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controleDeEstoqueBindingSource
            // 
            this.controleDeEstoqueBindingSource.DataMember = "ControleDeEstoque";
            this.controleDeEstoqueBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // controleDeEstoqueTableAdapter
            // 
            this.controleDeEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // GerarRelatorio
            // 
            this.GerarRelatorio.Location = new System.Drawing.Point(442, 15);
            this.GerarRelatorio.Name = "GerarRelatorio";
            this.GerarRelatorio.Size = new System.Drawing.Size(100, 40);
            this.GerarRelatorio.TabIndex = 1;
            this.GerarRelatorio.Text = "Pesquisar";
            this.GerarRelatorio.UseVisualStyleBackColor = true;
            this.GerarRelatorio.Click += new System.EventHandler(this.GerarRelatorio_Click);
            // 
            // cbNome
            // 
            this.cbNome.DataSource = this.estabelecimentosBindingSource;
            this.cbNome.DisplayMember = "nome";
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(242, 26);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(194, 21);
            this.cbNome.TabIndex = 2;
            this.cbNome.ValueMember = "nome";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione o estabelecimento para pesquisa:";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Estoque";
            reportDataSource1.Value = this.controleDeEstoqueBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DametaProject.Estoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(807, 532);
            this.reportViewer1.TabIndex = 7;
            // 
            // FornecedoresEstabelecimentosBindingSource
            // 
            this.FornecedoresEstabelecimentosBindingSource.DataMember = "FornecedoresEstabelecimentos";
            this.FornecedoresEstabelecimentosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // RelatorioDeFuncionariosBindingSource
            // 
            this.RelatorioDeFuncionariosBindingSource.DataMember = "RelatorioDeFuncionarios";
            this.RelatorioDeFuncionariosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // controleDeEstoqueBindingSource1
            // 
            this.controleDeEstoqueBindingSource1.DataMember = "ControleDeEstoque";
            this.controleDeEstoqueBindingSource1.DataSource = this.dameta_dbDataSet;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 597);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.GerarRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresEstabelecimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDeFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource;
        private dameta_dbDataSet dameta_dbDataSet;
        private dameta_dbDataSetTableAdapters.ControleDeEstoqueTableAdapter controleDeEstoqueTableAdapter;
        private System.Windows.Forms.Button GerarRelatorio;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.BindingSource estabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter estabelecimentosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FornecedoresEstabelecimentosBindingSource;
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource1;
        private System.Windows.Forms.BindingSource RelatorioDeFuncionariosBindingSource;
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource2;
    }
}