namespace SysPecNSDesk
{
    partial class FormUsuario
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
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblSenha = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            cmbNivel = new ComboBox();
            btnInserir = new Button();
            txtSenha = new TextBox();
            txtConfSenha = new TextBox();
            lblConfSenha = new Label();
            chkAtivo = new CheckBox();
            btnEditar = new Button();
            btnDeletar = new Button();
            txtBusca = new TextBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(148, 288);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(500, 150);
            dgvUsuarios.TabIndex = 10;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 150;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 150;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 42);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 42);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 97);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 14;
            label4.Text = "Nivel";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(231, 149);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha";
            // 
            // txtId
            // 
            txtId.Location = new Point(231, 60);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(57, 23);
            txtId.TabIndex = 18;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(294, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(256, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 23);
            txtEmail.TabIndex = 1;
            // 
            // cmbNivel
            // 
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(429, 115);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(121, 23);
            cmbNivel.TabIndex = 2;
            // 
            // btnInserir
            // 
            btnInserir.Image = Properties.Resources.Add;
            btnInserir.Location = new Point(165, 205);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(84, 42);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(231, 167);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(338, 167);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(100, 23);
            txtConfSenha.TabIndex = 4;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // lblConfSenha
            // 
            lblConfSenha.AutoSize = true;
            lblConfSenha.Location = new Point(338, 149);
            lblConfSenha.Name = "lblConfSenha";
            lblConfSenha.Size = new Size(92, 15);
            lblConfSenha.TabIndex = 16;
            lblConfSenha.Text = "Confirma Senha";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(463, 169);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 17;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(299, 205);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 42);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(433, 205);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(84, 42);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "De&letar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(148, 268);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(500, 23);
            txtBusca.TabIndex = 9;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(567, 205);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 42);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(txtBusca);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(chkAtivo);
            Controls.Add(lblConfSenha);
            Controls.Add(txtConfSenha);
            Controls.Add(txtSenha);
            Controls.Add(btnInserir);
            Controls.Add(cmbNivel);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblSenha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblSenha;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private ComboBox cmbNivel;
        private Button btnInserir;
        private TextBox txtSenha;
        private TextBox txtConfSenha;
        private Label lblConfSenha;
        private CheckBox chkAtivo;
        private Button btnEditar;
        private Button btnDeletar;
        private TextBox txtBusca;
        private Button btnCancelar;
    }
}