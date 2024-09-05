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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblEmail = new Label();
            txtEmail = new TextBox();
            textBox1 = new TextBox();
            btnConsultar = new Button();
            btnInserir = new Button();
            btnEditar = new Button();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvFornecedor.Location = new Point(95, 263);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.Size = new Size(444, 180);
            dgvFornecedor.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Razao_Social";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fantasia";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "CNPJ";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Contato";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Telefone";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // lblRazao_social
            // 
            lblRazao_social.AutoSize = true;
            lblRazao_social.Location = new Point(181, 36);
            lblRazao_social.Name = "lblRazao_social";
            lblRazao_social.Size = new Size(74, 15);
            lblRazao_social.TabIndex = 8;
            lblRazao_social.Text = "Razao_Social";
            // 
            // lblFantasia
            // 
            lblFantasia.AutoSize = true;
            lblFantasia.Location = new Point(365, 36);
            lblFantasia.Name = "lblFantasia";
            lblFantasia.Size = new Size(50, 15);
            lblFantasia.TabIndex = 9;
            lblFantasia.Text = "Fantasia";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(95, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 7;
            lblId.Text = "ID";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(95, 98);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(34, 15);
            lblCnpj.TabIndex = 10;
            lblCnpj.Text = "CNPJ";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(216, 116);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(130, 23);
            txtContato.TabIndex = 4;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(216, 98);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(50, 15);
            lblContato.TabIndex = 11;
            lblContato.Text = "Contato";
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(95, 116);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(100, 23);
            txtCnpj.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(364, 98);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "Telefone";
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(365, 54);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(174, 23);
            txtFantasia.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(95, 54);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(56, 23);
            txtId.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(365, 116);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(174, 23);
            txtTelefone.TabIndex = 6;
            // 
            // txtRazao_social
            // 
            txtRazao_social.Location = new Point(181, 54);
            txtRazao_social.Name = "txtRazao_social";
            txtRazao_social.Size = new Size(165, 23);
            txtRazao_social.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(96, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(632, 483);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblEmail);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(btnConsultar);
            tabPage1.Controls.Add(dgvFornecedor);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(txtRazao_social);
            tabPage1.Controls.Add(txtContato);
            tabPage1.Controls.Add(lblContato);
            tabPage1.Controls.Add(lblCnpj);
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(txtCnpj);
            tabPage1.Controls.Add(lblId);
            tabPage1.Controls.Add(lblFantasia);
            tabPage1.Controls.Add(txtFantasia);
            tabPage1.Controls.Add(lblTelefone);
            tabPage1.Controls.Add(lblRazao_social);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(624, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(95, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(444, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(463, 161);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 32);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(271, 161);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 32);
            btnInserir.TabIndex = 14;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(367, 161);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(624, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 523);
            Controls.Add(tabControl1);
            Name = "FormFornecedor";
            Text = "FormFornecedor";
            Load += FormFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnConsultar;
        private Button btnInserir;
        private Button btnEditar;
        private TextBox textBox1;
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