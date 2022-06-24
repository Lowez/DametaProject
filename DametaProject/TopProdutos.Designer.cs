namespace DametaProject
{
    partial class TopProdutos
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
            this.produtosmaisvendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.estabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GerarRelatorio = new System.Windows.Forms.Button();
            this.estabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter();
            this.produtos_mais_vendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtos_mais_vendidosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.produtos_mais_vendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produtosmaisvendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtos_mais_vendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosmaisvendidosBindingSource
            // 
            this.produtosmaisvendidosBindingSource.DataMember = "produtos_mais_vendidos";
            this.produtosmaisvendidosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TopProdutos";
            reportDataSource1.Value = this.produtosmaisvendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DametaProject.TopProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 141);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(459, 411);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o estabelecimento para pesquisa:";
            // 
            // cbNome
            // 
            this.cbNome.DataSource = this.estabelecimentosBindingSource;
            this.cbNome.DisplayMember = "nome";
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(233, 32);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(238, 21);
            this.cbNome.TabIndex = 5;
            this.cbNome.ValueMember = "nome";
            // 
            // estabelecimentosBindingSource
            // 
            this.estabelecimentosBindingSource.DataMember = "estabelecimentos";
            this.estabelecimentosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // GerarRelatorio
            // 
            this.GerarRelatorio.Location = new System.Drawing.Point(196, 95);
            this.GerarRelatorio.Name = "GerarRelatorio";
            this.GerarRelatorio.Size = new System.Drawing.Size(100, 40);
            this.GerarRelatorio.TabIndex = 4;
            this.GerarRelatorio.Text = "Pesquisar";
            this.GerarRelatorio.UseVisualStyleBackColor = true;
            this.GerarRelatorio.Click += new System.EventHandler(this.GerarRelatorio_Click);
            // 
            // estabelecimentosTableAdapter
            // 
            this.estabelecimentosTableAdapter.ClearBeforeFill = true;
            // 
            // produtos_mais_vendidosBindingSource
            // 
            this.produtos_mais_vendidosBindingSource.DataMember = "produtos_mais_vendidos";
            this.produtos_mais_vendidosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // produtos_mais_vendidosTableAdapter
            // 
            this.produtos_mais_vendidosTableAdapter.ClearBeforeFill = true;
            // 
            // TopProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.GerarRelatorio);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TopProdutos";
            this.Text = "Top Produtos";
            this.Load += new System.EventHandler(this.TopProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosmaisvendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtos_mais_vendidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Button GerarRelatorio;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource estabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter estabelecimentosTableAdapter;
        private System.Windows.Forms.BindingSource produtosmaisvendidosBindingSource;
        private System.Windows.Forms.BindingSource produtos_mais_vendidosBindingSource;
        private dameta_dbDataSetTableAdapters.produtos_mais_vendidosTableAdapter produtos_mais_vendidosTableAdapter;
    }
}