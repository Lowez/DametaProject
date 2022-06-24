namespace DametaProject
{
    partial class RelatorioFuncionarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.GerarRelatorio = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.estabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioDeFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioDeFuncionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioDeFuncionariosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.RelatorioDeFuncionariosTableAdapter();
            this.dametadbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estabelecimentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtEstabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtEstabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.dtEstabelecimentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDeFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioDeFuncionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dametadbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstabelecimentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o estabelecimento para pesquisa:";
            // 
            // cbNome
            // 
            this.cbNome.DataSource = this.dtEstabelecimentosBindingSource;
            this.cbNome.DisplayMember = "nome";
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(272, 32);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(194, 21);
            this.cbNome.TabIndex = 5;
            this.cbNome.ValueMember = "nome";
            // 
            // GerarRelatorio
            // 
            this.GerarRelatorio.Location = new System.Drawing.Point(472, 21);
            this.GerarRelatorio.Name = "GerarRelatorio";
            this.GerarRelatorio.Size = new System.Drawing.Size(100, 40);
            this.GerarRelatorio.TabIndex = 4;
            this.GerarRelatorio.Text = "Pesquisar";
            this.GerarRelatorio.UseVisualStyleBackColor = true;
            this.GerarRelatorio.Click += new System.EventHandler(this.GerarRelatorio_Click);
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.relatorioDeFuncionariosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DametaProject.RelatorioFuncionarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 481);
            this.reportViewer1.TabIndex = 7;
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
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // RelatorioDeFuncionariosBindingSource
            // 
            this.RelatorioDeFuncionariosBindingSource.DataMember = "RelatorioDeFuncionarios";
            this.RelatorioDeFuncionariosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // relatorioDeFuncionariosBindingSource1
            // 
            this.relatorioDeFuncionariosBindingSource1.DataMember = "RelatorioDeFuncionarios";
            this.relatorioDeFuncionariosBindingSource1.DataSource = this.dameta_dbDataSet;
            // 
            // relatorioDeFuncionariosTableAdapter
            // 
            this.relatorioDeFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // dametadbDataSetBindingSource
            // 
            this.dametadbDataSetBindingSource.DataSource = this.dameta_dbDataSet;
            this.dametadbDataSetBindingSource.Position = 0;
            // 
            // estabelecimentosBindingSource1
            // 
            this.estabelecimentosBindingSource1.DataMember = "estabelecimentos";
            this.estabelecimentosBindingSource1.DataSource = this.dameta_dbDataSet;
            // 
            // dtEstabelecimentosBindingSource
            // 
            this.dtEstabelecimentosBindingSource.DataMember = "dtEstabelecimentos";
            this.dtEstabelecimentosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // dtEstabelecimentosTableAdapter
            // 
            this.dtEstabelecimentosTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 550);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.GerarRelatorio);
            this.Name = "RelatorioFuncionarios";
            this.Text = "RelatorioDeFuncionarios";
            this.Load += new System.EventHandler(this.RelatorioDeFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDeFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioDeFuncionariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dametadbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEstabelecimentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Button GerarRelatorio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource estabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter estabelecimentosTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.BindingSource relatorioDeFuncionariosBindingSource1;
        private System.Windows.Forms.BindingSource RelatorioDeFuncionariosBindingSource;
        private dameta_dbDataSetTableAdapters.RelatorioDeFuncionariosTableAdapter relatorioDeFuncionariosTableAdapter;
        private System.Windows.Forms.BindingSource estabelecimentosBindingSource1;
        private System.Windows.Forms.BindingSource dametadbDataSetBindingSource;
        private System.Windows.Forms.BindingSource dtEstabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.dtEstabelecimentosTableAdapter dtEstabelecimentosTableAdapter;
    }
}