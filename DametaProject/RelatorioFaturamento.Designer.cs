namespace DametaProject
{
    partial class RelatorioFaturamento
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
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.comprasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Faturamento";
            reportDataSource1.Value = this.comprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DametaProject.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "compras";
            this.comprasBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioFaturamento";
            this.Text = "RelatorioFaturamento";
            this.Load += new System.EventHandler(this.RelatorioFaturamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private dameta_dbDataSetTableAdapters.comprasTableAdapter comprasTableAdapter;
    }
}