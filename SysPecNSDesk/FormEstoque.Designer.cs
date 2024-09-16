namespace SysPecNSDesk
{
    partial class FormEstoque
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtQuantidade = new TextBox();
            txtProduto_id = new TextBox();
            dgvEstoque = new DataGridView();
            clnProduto_id = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnData_Ultimo_Movimento = new DataGridViewTextBoxColumn();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Hv BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 29);
            label1.TabIndex = 0;
            label1.Text = "Estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 58);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Produto ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 58);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(204, 76);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(75, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // txtProduto_id
            // 
            txtProduto_id.Location = new Point(113, 76);
            txtProduto_id.Name = "txtProduto_id";
            txtProduto_id.Size = new Size(75, 23);
            txtProduto_id.TabIndex = 4;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnProduto_id, clnQuantidade, clnData_Ultimo_Movimento });
            dgvEstoque.Location = new Point(27, 175);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(345, 209);
            dgvEstoque.TabIndex = 5;
            // 
            // clnProduto_id
            // 
            clnProduto_id.HeaderText = "Produto ID";
            clnProduto_id.Name = "clnProduto_id";
            clnProduto_id.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            // 
            // clnData_Ultimo_Movimento
            // 
            clnData_Ultimo_Movimento.HeaderText = "Data_Ultimo_Movimento";
            clnData_Ultimo_Movimento.Name = "clnData_Ultimo_Movimento";
            clnData_Ultimo_Movimento.ReadOnly = true;
            clnData_Ultimo_Movimento.Width = 144;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(61, 128);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 30);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(161, 128);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 30);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "&Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnProduto
            // 
            btnProduto.Font = new Font("Segoe UI", 8.25F);
            btnProduto.Location = new Point(261, 128);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(75, 30);
            btnProduto.TabIndex = 8;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // FormEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 450);
            Controls.Add(label1);
            Controls.Add(btnProduto);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Controls.Add(dgvEstoque);
            Controls.Add(txtProduto_id);
            Controls.Add(txtQuantidade);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormEstoque";
            Text = "FormEstoque";
            Load += FormEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtQuantidade;
        private TextBox txtProduto_id;
        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn clnProduto_id;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnData_Ultimo_Movimento;
        private Button btnInserir;
        private Button btnAlterar;
        private Button btnProduto;
    }
}