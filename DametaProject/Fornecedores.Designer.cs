namespace DametaProject
{
    partial class Fornecedores
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
            this.btLimpar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txNome = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.dametadbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dametadbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(539, 26);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 38);
            this.btLimpar.TabIndex = 47;
            this.btLimpar.Text = "Limpar Form";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(539, 70);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 38);
            this.btExcluir.TabIndex = 46;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 187);
            this.dataGridView1.TabIndex = 42;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(96, 84);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(301, 20);
            this.txNome.TabIndex = 35;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(46, 87);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 34;
            this.nomeLabel.Text = "Nome:";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(163, 36);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(53, 20);
            this.txID.TabIndex = 33;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(445, 70);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 38);
            this.btAlterar.TabIndex = 45;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(445, 26);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 38);
            this.btIncluir.TabIndex = 44;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Codigo do Fornecedor:";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(222, 26);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 38);
            this.btConsultar.TabIndex = 43;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(46, 121);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 36;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            // 
            // mtxCNPJ
            // 
            this.mtxCNPJ.Location = new System.Drawing.Point(96, 151);
            this.mtxCNPJ.Mask = "99,999,999/9999-99";
            this.mtxCNPJ.Name = "mtxCNPJ";
            this.mtxCNPJ.Size = new System.Drawing.Size(118, 20);
            this.mtxCNPJ.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "CNPJ:";
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.ForeColor = System.Drawing.Color.Black;
            this.mtxTelefone.Location = new System.Drawing.Point(96, 118);
            this.mtxTelefone.Mask = "(99)99999-9999";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(118, 20);
            this.mtxTelefone.TabIndex = 56;
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
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 418);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.mtxCNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.telefoneLabel);
            this.Name = "Fornecedores";
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dametadbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.MaskedTextBox mtxCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource dametadbDataSetBindingSource;
    }
}