namespace SysPecNSDesk
{
    partial class FormCliente
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
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            txtNome = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            dtpDataNasc = new DateTimePicker();
            lblDataNasc = new Label();
            btnInserir = new Button();
            dgvCliente = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(402, 108);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(183, 27);
            txtTelefone.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(207, 108);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(180, 27);
            txtCpf.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(207, 44);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(69, 27);
            txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(287, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(298, 27);
            txtNome.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(207, 21);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(287, 21);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(207, 85);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 20);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(402, 85);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(66, 20);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(207, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(426, 172);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(159, 27);
            dtpDataNasc.TabIndex = 10;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(426, 149);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(145, 20);
            lblDataNasc.TabIndex = 11;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(207, 224);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(90, 32);
            btnInserir.TabIndex = 12;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvCliente.Location = new Point(73, 318);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(655, 237);
            dgvCliente.TabIndex = 13;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "CPF";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Data de Nascimento";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 180;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(73, 276);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(655, 27);
            txtBusca.TabIndex = 14;
            txtBusca.TextChanged += txtBusca_TextChanged_1;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 592);
            Controls.Add(txtBusca);
            Controls.Add(btnInserir);
            Controls.Add(lblDataNasc);
            Controls.Add(dtpDataNasc);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(dgvCliente);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefone;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lblId;
        private Label lblNome;
        private Label lblCpf;
        private Label lblTelefone;
        private Label lblEmail;
        private DateTimePicker dtpDataNasc;
        private Label lblDataNasc;
        private Button btnInserir;
        private DataGridView dgvCliente;
        private TextBox txtBusca;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}