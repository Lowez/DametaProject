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
            this.estabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estabelecimentosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FornecedoresEstabelecimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioDeFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleDeEstoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controleDeEstoqueBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet1 = new DametaProject.dameta_dbDataSet();
            this.controleDeEstoqueBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresEstabelecimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDeFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource4)).BeginInit();
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
            // estabelecimentosBindingSource
            // 
            this.estabelecimentosBindingSource.DataMember = "estabelecimentos";
            this.estabelecimentosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // estabelecimentosTableAdapter
            // 
            this.estabelecimentosTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.controleDeEstoqueBindingSource4;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DametaProject.Estoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(414, 551);
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
            // controleDeEstoqueBindingSource3
            // 
            this.controleDeEstoqueBindingSource3.DataMember = "ControleDeEstoque";
            this.controleDeEstoqueBindingSource3.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet1
            // 
            this.dameta_dbDataSet1.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controleDeEstoqueBindingSource4
            // 
            this.controleDeEstoqueBindingSource4.DataMember = "ControleDeEstoque";
            this.controleDeEstoqueBindingSource4.DataSource = this.dameta_dbDataSet1;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 552);
            this.Controls.Add(this.reportViewer1);
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
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeEstoqueBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource;
        private dameta_dbDataSet dameta_dbDataSet;
        private dameta_dbDataSetTableAdapters.ControleDeEstoqueTableAdapter controleDeEstoqueTableAdapter;
        private System.Windows.Forms.BindingSource estabelecimentosBindingSource;
        private dameta_dbDataSetTableAdapters.estabelecimentosTableAdapter estabelecimentosTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FornecedoresEstabelecimentosBindingSource;
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource1;
        private System.Windows.Forms.BindingSource RelatorioDeFuncionariosBindingSource;
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource2;
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource3;
        private dameta_dbDataSet dameta_dbDataSet1;
        private System.Windows.Forms.BindingSource controleDeEstoqueBindingSource4;
    }
}