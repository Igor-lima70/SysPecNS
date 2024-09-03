namespace SysPecNSDesk
{
    partial class FormProduto
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
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            lblDesconto = new Label();
            txtDesconto = new TextBox();
            nudEstoqMin = new NumericUpDown();
            lblDesc = new Label();
            lblEstoqMin = new Label();
            lblUnidVenda = new Label();
            lblValorUnit = new Label();
            lblCodBarras = new Label();
            lblId = new Label();
            txtUnidVenda = new TextBox();
            txtDescricao = new TextBox();
            txtValorUnit = new TextBox();
            txtCodbar = new TextBox();
            txtId = new TextBox();
            dgvProdutos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            lblProdutos = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstoqMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(lblDesconto);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(nudEstoqMin);
            groupBox1.Controls.Add(lblDesc);
            groupBox1.Controls.Add(lblEstoqMin);
            groupBox1.Controls.Add(lblUnidVenda);
            groupBox1.Controls.Add(lblValorUnit);
            groupBox1.Controls.Add(lblCodBarras);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(txtUnidVenda);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtValorUnit);
            groupBox1.Controls.Add(txtCodbar);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(73, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(382, 203);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 24);
            btnConsultar.TabIndex = 19;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(289, 203);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 24);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(197, 203);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 24);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(232, 145);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(319, 23);
            cmbCategoria.TabIndex = 16;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(232, 127);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoria";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(74, 185);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 13;
            lblDesconto.Text = "Desconto";
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(76, 203);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 12;
            // 
            // nudEstoqMin
            // 
            nudEstoqMin.Location = new Point(457, 91);
            nudEstoqMin.Name = "nudEstoqMin";
            nudEstoqMin.Size = new Size(36, 23);
            nudEstoqMin.TabIndex = 11;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(79, 127);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 10;
            lblDesc.Text = "Descrição";
            // 
            // lblEstoqMin
            // 
            lblEstoqMin.AutoSize = true;
            lblEstoqMin.Location = new Point(457, 72);
            lblEstoqMin.Name = "lblEstoqMin";
            lblEstoqMin.Size = new Size(94, 15);
            lblEstoqMin.TabIndex = 9;
            lblEstoqMin.Text = "Estoque Mínimo";
            // 
            // lblUnidVenda
            // 
            lblUnidVenda.AutoSize = true;
            lblUnidVenda.Location = new Point(338, 72);
            lblUnidVenda.Name = "lblUnidVenda";
            lblUnidVenda.Size = new Size(102, 15);
            lblUnidVenda.TabIndex = 8;
            lblUnidVenda.Text = "Unidade de Venda";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Location = new Point(212, 72);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(78, 15);
            lblValorUnit.TabIndex = 7;
            lblValorUnit.Text = "Valor Unitário";
            // 
            // lblCodBarras
            // 
            lblCodBarras.AutoSize = true;
            lblCodBarras.Location = new Point(79, 72);
            lblCodBarras.Name = "lblCodBarras";
            lblCodBarras.Size = new Size(97, 15);
            lblCodBarras.TabIndex = 6;
            lblCodBarras.Text = "Código de barras";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(79, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // txtUnidVenda
            // 
            txtUnidVenda.ForeColor = SystemColors.ScrollBar;
            txtUnidVenda.Location = new Point(340, 90);
            txtUnidVenda.Name = "txtUnidVenda";
            txtUnidVenda.Size = new Size(100, 23);
            txtUnidVenda.TabIndex = 4;
            txtUnidVenda.Tag = "";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(76, 145);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(136, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(212, 89);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(112, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodbar
            // 
            txtCodbar.Location = new Point(79, 90);
            txtCodbar.Name = "txtCodbar";
            txtCodbar.Size = new Size(117, 23);
            txtCodbar.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(79, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(52, 23);
            txtId.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvProdutos.Location = new Point(73, 335);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(643, 206);
            dgvProdutos.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Código de Barras";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 160;
            // 
            // Column3
            // 
            Column3.HeaderText = "Descrição";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 160;
            // 
            // Column4
            // 
            Column4.HeaderText = "Valor Unitário";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Unidade de Venda";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 130;
            // 
            // Column6
            // 
            Column6.HeaderText = "Categoria";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 130;
            // 
            // Column7
            // 
            Column7.HeaderText = "Estoque Minimo";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 120;
            // 
            // Column8
            // 
            Column8.HeaderText = "Desconto";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 120;
            // 
            // Column9
            // 
            Column9.HeaderText = "Data Cadastro";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 120;
            // 
            // lblProdutos
            // 
            lblProdutos.AutoSize = true;
            lblProdutos.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProdutos.Location = new Point(285, 22);
            lblProdutos.Name = "lblProdutos";
            lblProdutos.Size = new Size(154, 32);
            lblProdutos.TabIndex = 2;
            lblProdutos.Text = "Produtos";
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 582);
            Controls.Add(lblProdutos);
            Controls.Add(dgvProdutos);
            Controls.Add(groupBox1);
            Name = "FormProduto";
            Text = "FormProduto";
            Load += FormProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEstoqMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblEstoqMin;
        private Label lblUnidVenda;
        private Label lblValorUnit;
        private Label lblCodBarras;
        private Label lblId;
        private TextBox txtUnidVenda;
        private TextBox txtDescricao;
        private TextBox txtValorUnit;
        private TextBox txtCodbar;
        private TextBox txtId;
        private Label lblDesc;
        private NumericUpDown nudEstoqMin;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private Label lblDesconto;
        private TextBox txtDesconto;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private DataGridView dgvProdutos;
        private Label lblProdutos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}