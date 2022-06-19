namespace DametaProject
{
    partial class RelatoriosFornecedoresEstabelecimentos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.fornecedoresTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.fornecedoresTableAdapter();
            this.fornecedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet1 = new DametaProject.dameta_dbDataSet();
            this.fornecedoresEstabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresEstabelecimentos = new DametaProject.dameta_dbDataSetTableAdapters.FornecedoresEstabelecimentos();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresEstabelecimentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.fornecedoresEstabelecimentosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DametaProject.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(1, -1);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(801, 450);
            this.reportViewer2.TabIndex = 0;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresBindingSource1
            // 
            this.fornecedoresBindingSource1.DataMember = "Fornecedores";
            this.fornecedoresBindingSource1.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet1
            // 
            this.dameta_dbDataSet1.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresEstabelecimentosBindingSource
            // 
            this.fornecedoresEstabelecimentosBindingSource.DataMember = "FornecedoresEstabelecimentos";
            this.fornecedoresEstabelecimentosBindingSource.DataSource = this.dameta_dbDataSet1;
            // 
            // fornecedoresEstabelecimentos
            // 
            this.fornecedoresEstabelecimentos.ClearBeforeFill = true;
            // 
            // RelatoriosFornecedoresEstabelecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Name = "RelatoriosFornecedoresEstabelecimentos";
            this.Text = "RelatoriosFornecedoresEstabelecimentos";
            this.Load += new System.EventHandler(this.RelatoriosFornecedoresEstabelecimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresEstabelecimentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private dameta_dbDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource1;
        private dameta_dbDataSet dameta_dbDataSet1;
        private System.Windows.Forms.BindingSource fornecedoresEstabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.FornecedoresEstabelecimentos fornecedoresEstabelecimentos;
    }
}