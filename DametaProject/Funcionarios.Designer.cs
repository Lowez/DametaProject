﻿namespace DametaProject
{
    partial class Funcionarios
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
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargosidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estabelecimentosidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dameta_dbDataSet = new DametaProject.dameta_dbDataSet();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.txID = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.txSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstabelecimento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.CheckBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new DametaProject.dameta_dbDataSetTableAdapters.funcionariosTableAdapter();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.funcionariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(79, 119);
            this.mtxCPF.Mask = "99,999,999/9999-99";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(118, 20);
            this.mtxCPF.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "CPF:";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(696, 25);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 38);
            this.btLimpar.TabIndex = 61;
            this.btLimpar.Text = "Limpar Form";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(696, 178);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 38);
            this.btExcluir.TabIndex = 60;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.cargosidDataGridViewTextBoxColumn,
            this.estabelecimentosidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(769, 187);
            this.dataGridView1.TabIndex = 56;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
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
            this.nascimentoDataGridViewTextBoxColumn.Width = 70;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Width = 70;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargosidDataGridViewTextBoxColumn
            // 
            this.cargosidDataGridViewTextBoxColumn.DataPropertyName = "cargos_id";
            this.cargosidDataGridViewTextBoxColumn.HeaderText = "cargos_id";
            this.cargosidDataGridViewTextBoxColumn.Name = "cargosidDataGridViewTextBoxColumn";
            this.cargosidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estabelecimentosidDataGridViewTextBoxColumn
            // 
            this.estabelecimentosidDataGridViewTextBoxColumn.DataPropertyName = "estabelecimentos_id";
            this.estabelecimentosidDataGridViewTextBoxColumn.HeaderText = "estabelecimentos_id";
            this.estabelecimentosidDataGridViewTextBoxColumn.Name = "estabelecimentosidDataGridViewTextBoxColumn";
            this.estabelecimentosidDataGridViewTextBoxColumn.ReadOnly = true;
            this.estabelecimentosidDataGridViewTextBoxColumn.Width = 120;
            // 
            // funcionariosBindingSource1
            // 
            this.funcionariosBindingSource1.DataMember = "funcionarios";
            this.funcionariosBindingSource1.DataSource = this.dameta_dbDataSet;
            // 
            // dameta_dbDataSet
            // 
            this.dameta_dbDataSet.DataSetName = "dameta_dbDataSet";
            this.dameta_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.ForeColor = System.Drawing.Color.Black;
            this.mtxTelefone.Location = new System.Drawing.Point(262, 119);
            this.mtxTelefone.Mask = "(99)99999-9999";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(118, 20);
            this.mtxTelefone.TabIndex = 55;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(79, 82);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(301, 20);
            this.txNome.TabIndex = 53;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(29, 85);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 52;
            this.nomeLabel.Text = "Nome:";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(146, 34);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(53, 20);
            this.txID.TabIndex = 51;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(696, 125);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 38);
            this.btAlterar.TabIndex = 59;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(696, 75);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 38);
            this.btIncluir.TabIndex = 58;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Codigo do Funcionário";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(205, 24);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 38);
            this.btConsultar.TabIndex = 57;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(204, 122);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 54;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(79, 157);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(301, 20);
            this.txEmail.TabIndex = 65;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(29, 160);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 64;
            this.emailLabel.Text = "Email:";
            // 
            // txSalario
            // 
            this.txSalario.Location = new System.Drawing.Point(79, 189);
            this.txSalario.Name = "txSalario";
            this.txSalario.Size = new System.Drawing.Size(100, 20);
            this.txSalario.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Salário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Senha:";
            // 
            // cbGenero
            // 
            this.cbGenero.DisplayMember = "NomeCid";
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(505, 114);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 71;
            this.cbGenero.ValueMember = "ID_Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Genero:";
            // 
            // cbCargo
            // 
            this.cbCargo.DisplayMember = "NomeCid";
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(505, 151);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 73;
            this.cbCargo.ValueMember = "ID_Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Cargo:";
            // 
            // cbEstabelecimento
            // 
            this.cbEstabelecimento.FormattingEnabled = true;
            this.cbEstabelecimento.Location = new System.Drawing.Point(505, 190);
            this.cbEstabelecimento.Name = "cbEstabelecimento";
            this.cbEstabelecimento.Size = new System.Drawing.Size(121, 21);
            this.cbEstabelecimento.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Estabelecimento:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Checked = true;
            this.c.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c.Location = new System.Drawing.Point(242, 191);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(136, 17);
            this.c.TabIndex = 76;
            this.c.Text = "Gerar automaticamente";
            this.c.UseVisualStyleBackColor = true;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.dameta_dbDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(527, 82);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(99, 20);
            this.dtpDataNascimento.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Data de Nascimento:";
            // 
            // funcionariosBindingSource2
            // 
            this.funcionariosBindingSource2.DataMember = "funcionarios";
            this.funcionariosBindingSource2.DataSource = this.dameta_dbDataSet;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c);
            this.Controls.Add(this.cbEstabelecimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.telefoneLabel);
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dameta_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox txID;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox txSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstabelecimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox c;
        private dameta_dbDataSet dameta_dbDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private dameta_dbDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargosidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estabelecimentosidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource funcionariosBindingSource1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource2;
    }
}