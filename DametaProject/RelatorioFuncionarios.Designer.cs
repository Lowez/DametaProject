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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.relatorioDeFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorioDeFuncionariosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.RelatorioDeFuncionariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioDeFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioDeFuncionariosBindingSource
            // 
            this.relatorioDeFuncionariosBindingSource.DataMember = "RelatorioDeFuncionarios";
            this.relatorioDeFuncionariosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.relatorioDeFuncionariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DametaProject.RelatórioFuncionários.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 448);
            this.reportViewer1.TabIndex = 0;
            // 
            // relatorioDeFuncionariosTableAdapter
            // 
            this.relatorioDeFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioFuncionarios";
            this.Text = "RelatorioDeFuncionarios";
            this.Load += new System.EventHandler(this.RelatorioDeFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioDeFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource relatorioDeFuncionariosBindingSource;
        private dameta_dbDataSetTableAdapters.RelatorioDeFuncionariosTableAdapter relatorioDeFuncionariosTableAdapter;
    }
}