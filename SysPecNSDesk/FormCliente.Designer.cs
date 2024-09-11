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
            txtTelefone.Location = new Point(352, 81);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(161, 23);
            txtTelefone.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(181, 81);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(158, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 129);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(181, 33);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(61, 23);
            txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(251, 33);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(261, 23);
            txtNome.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(181, 16);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(251, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(181, 64);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(352, 64);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 8;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(181, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(373, 129);
            dtpDataNasc.Margin = new Padding(3, 2, 3, 2);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(140, 23);
            dtpDataNasc.TabIndex = 10;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(373, 112);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 11;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(181, 165);
            btnInserir.Margin = new Padding(3, 2, 3, 2);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(79, 28);
            btnInserir.TabIndex = 12;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click_1;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvCliente.Location = new Point(64, 238);
            dgvCliente.Margin = new Padding(3, 2, 3, 2);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(573, 178);
            dgvCliente.TabIndex = 13;
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
            txtBusca.Location = new Point(64, 207);
            txtBusca.Margin = new Padding(3, 2, 3, 2);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(574, 23);
            txtBusca.TabIndex = 14;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 444);
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
            Margin = new Padding(3, 2, 3, 2);
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