namespace SysPecNSDesk
{
    partial class FormEndereco
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
            txtClienteID = new TextBox();
            txtTipoEndereco = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtCep = new TextBox();
            txtUF = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            lblCliente_id = new Label();
            lblTipo_endereco = new Label();
            lblCep = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnInserir = new Button();
            dgvEndereco = new DataGridView();
            txtBusca = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            clnID = new DataGridViewTextBoxColumn();
            clnClienteID = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUF = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).BeginInit();
            SuspendLayout();
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(291, 52);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(59, 23);
            txtClienteID.TabIndex = 0;
            // 
            // txtTipoEndereco
            // 
            txtTipoEndereco.Location = new Point(360, 52);
            txtTipoEndereco.Name = "txtTipoEndereco";
            txtTipoEndereco.Size = new Size(117, 23);
            txtTipoEndereco.TabIndex = 1;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(227, 109);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(204, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(442, 109);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(50, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(503, 109);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(83, 23);
            txtComplemento.TabIndex = 4;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(487, 52);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(99, 23);
            txtCep.TabIndex = 5;
            // 
            // txtUF
            // 
            txtUF.Location = new Point(452, 162);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(31, 23);
            txtUF.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(366, 162);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(71, 23);
            txtCidade.TabIndex = 7;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(227, 162);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(124, 23);
            txtBairro.TabIndex = 8;
            // 
            // lblCliente_id
            // 
            lblCliente_id.AutoSize = true;
            lblCliente_id.Location = new Point(286, 34);
            lblCliente_id.Name = "lblCliente_id";
            lblCliente_id.Size = new Size(60, 15);
            lblCliente_id.TabIndex = 9;
            lblCliente_id.Text = "Cliente_ID";
            // 
            // lblTipo_endereco
            // 
            lblTipo_endereco.AutoSize = true;
            lblTipo_endereco.Location = new Point(358, 34);
            lblTipo_endereco.Name = "lblTipo_endereco";
            lblTipo_endereco.Size = new Size(84, 15);
            lblTipo_endereco.TabIndex = 10;
            lblTipo_endereco.Text = "Tipo_Endereco";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(487, 34);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 11;
            lblCep.Text = "Cep";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 91);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Logradouro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 91);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Número";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(504, 91);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Complemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 144);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 15;
            label7.Text = "Bairro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(366, 144);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 16;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(457, 144);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 17;
            label9.Text = "UF";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(498, 157);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(83, 31);
            btnInserir.TabIndex = 18;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvEndereco
            // 
            dgvEndereco.AllowUserToAddRows = false;
            dgvEndereco.AllowUserToDeleteRows = false;
            dgvEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEndereco.Columns.AddRange(new DataGridViewColumn[] { clnID, clnClienteID, clnTipoEndereco, clnCep, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUF });
            dgvEndereco.Location = new Point(144, 245);
            dgvEndereco.Name = "dgvEndereco";
            dgvEndereco.ReadOnly = true;
            dgvEndereco.RowHeadersVisible = false;
            dgvEndereco.Size = new Size(519, 193);
            dgvEndereco.TabIndex = 19;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(144, 216);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(519, 23);
            txtBusca.TabIndex = 20;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(227, 52);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 34);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 22;
            label1.Text = "ID";
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 80;
            // 
            // clnClienteID
            // 
            clnClienteID.HeaderText = "Cliente ID";
            clnClienteID.Name = "clnClienteID";
            clnClienteID.ReadOnly = true;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.HeaderText = "Tipo Endereço";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            clnTipoEndereco.Width = 120;
            // 
            // clnCep
            // 
            clnCep.HeaderText = "Cep";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            // 
            // clnNumero
            // 
            clnNumero.HeaderText = "Número";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            // 
            // clnUF
            // 
            clnUF.HeaderText = "UF";
            clnUF.Name = "clnUF";
            clnUF.ReadOnly = true;
            // 
            // FormEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtBusca);
            Controls.Add(dgvEndereco);
            Controls.Add(btnInserir);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblCep);
            Controls.Add(lblTipo_endereco);
            Controls.Add(lblCliente_id);
            Controls.Add(txtBairro);
            Controls.Add(txtCidade);
            Controls.Add(txtUF);
            Controls.Add(txtCep);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtTipoEndereco);
            Controls.Add(txtClienteID);
            Name = "FormEndereco";
            Text = "FormEndereco";
            Load += FormEndereco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEndereco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClienteID;
        private TextBox txtTipoEndereco;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtCep;
        private TextBox txtUF;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label lblCliente_id;
        private Label lblTipo_endereco;
        private Label lblCep;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnInserir;
        private DataGridView dgvEndereco;
        private TextBox txtBusca;
        private TextBox txtId;
        private Label label1;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnClienteID;
        private DataGridViewTextBoxColumn clnTipoEndereco;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUF;
    }
}