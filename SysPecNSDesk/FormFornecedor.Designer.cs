namespace SysPecNSDesk
{
    partial class FormFornecedor
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
            dgvFornecedor = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            lblRazao_social = new Label();
            lblFantasia = new Label();
            lblId = new Label();
            lblCnpj = new Label();
            txtContato = new TextBox();
            lblContato = new Label();
            txtCnpj = new TextBox();
            lblTelefone = new Label();
            txtFantasia = new TextBox();
            txtId = new TextBox();
            txtTelefone = new TextBox();
            txtRazao_social = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtBusca = new TextBox();
            btnConsultar = new Button();
            btnInserir = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvFornecedor.Location = new Point(232, 361);
            dgvFornecedor.Margin = new Padding(3, 4, 3, 4);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.RowHeadersWidth = 51;
            dgvFornecedor.Size = new Size(507, 240);
            dgvFornecedor.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Razao_Social";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fantasia";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "CNPJ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Contato";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Telefone";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // lblRazao_social
            // 
            lblRazao_social.AutoSize = true;
            lblRazao_social.Location = new Point(330, 58);
            lblRazao_social.Name = "lblRazao_social";
            lblRazao_social.Size = new Size(96, 20);
            lblRazao_social.TabIndex = 8;
            lblRazao_social.Text = "Razao_Social";
            // 
            // lblFantasia
            // 
            lblFantasia.AutoSize = true;
            lblFantasia.Location = new Point(540, 58);
            lblFantasia.Name = "lblFantasia";
            lblFantasia.Size = new Size(62, 20);
            lblFantasia.TabIndex = 9;
            lblFantasia.Text = "Fantasia";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(232, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 7;
            lblId.Text = "ID";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(232, 141);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(41, 20);
            lblCnpj.TabIndex = 10;
            lblCnpj.Text = "CNPJ";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(370, 165);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(148, 27);
            txtContato.TabIndex = 4;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(370, 141);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(62, 20);
            lblContato.TabIndex = 11;
            lblContato.Text = "Contato";
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(232, 165);
            txtCnpj.Margin = new Padding(3, 4, 3, 4);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(114, 27);
            txtCnpj.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(539, 141);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "Telefone";
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(540, 82);
            txtFantasia.Margin = new Padding(3, 4, 3, 4);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(198, 27);
            txtFantasia.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(232, 82);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(63, 27);
            txtId.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(540, 165);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(198, 27);
            txtTelefone.TabIndex = 6;
            // 
            // txtRazao_social
            // 
            txtRazao_social.Location = new Point(330, 82);
            txtRazao_social.Margin = new Padding(3, 4, 3, 4);
            txtRazao_social.Name = "txtRazao_social";
            txtRazao_social.Size = new Size(188, 27);
            txtRazao_social.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(232, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(232, 233);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(230, 303);
            txtBusca.Margin = new Padding(3, 4, 3, 4);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(507, 27);
            txtBusca.TabIndex = 16;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(652, 225);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 43);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(433, 225);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(86, 43);
            btnInserir.TabIndex = 14;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(542, 225);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 43);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 697);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(dgvFornecedor);
            Controls.Add(txtBusca);
            Controls.Add(lblRazao_social);
            Controls.Add(btnConsultar);
            Controls.Add(lblTelefone);
            Controls.Add(txtFantasia);
            Controls.Add(btnInserir);
            Controls.Add(lblFantasia);
            Controls.Add(btnEditar);
            Controls.Add(lblId);
            Controls.Add(txtTelefone);
            Controls.Add(txtCnpj);
            Controls.Add(txtRazao_social);
            Controls.Add(txtId);
            Controls.Add(txtContato);
            Controls.Add(lblCnpj);
            Controls.Add(lblContato);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFornecedor";
            Text = "FormFornecedor";
            Load += FormFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvFornecedor;
        private Label lblRazao_social;
        private Label lblFantasia;
        private Label lblId;
        private Label lblCnpj;
        private TextBox txtContato;
        private Label lblContato;
        private TextBox txtCnpj;
        private Label lblTelefone;
        private TextBox txtFantasia;
        private TextBox txtId;
        private TextBox txtTelefone;
        private TextBox txtRazao_social;
        private Button btnConsultar;
        private Button btnInserir;
        private Button btnEditar;
        private TextBox txtBusca;
        private Label lblEmail;
        private TextBox txtEmail;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}