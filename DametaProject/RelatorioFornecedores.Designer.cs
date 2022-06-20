namespace DametaProject
{
    partial class RelatorioFornecedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.fornecedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet1 = new DametaProject.dameta_dbDataSet();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fornecedoresTableAdapter1 = new DametaProject.dameta_dbDataSetTableAdapters.fornecedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fornecedoresBindingSource1
            // 
            this.fornecedoresBindingSource1.DataMember = "fornecedores";
            this.fornecedoresBindingSource1.DataSource = this.dameta_dbDataSet1;
            // 
            // dameta_dbDataSet1
            // 
            this.dameta_dbDataSet1.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.fornecedoresBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DametaProject.RelatorioFornecedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(612, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // fornecedoresTableAdapter1
            // 
            this.fornecedoresTableAdapter1.ClearBeforeFill = true;
            // 
            // RelatorioFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioFornecedores";
            this.Text = "Relatorio Fornecedores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private dameta_dbDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private dameta_dbDataSet dameta_dbDataSet1;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource1;
        private dameta_dbDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter1;
    }
}