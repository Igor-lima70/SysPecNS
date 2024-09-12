namespace SysPecNSDesk
{
    partial class FormPedido
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
            grbIdentificação = new GroupBox();
            txtIdCliente = new TextBox();
            lblCliente = new Label();
            btnInserir = new Button();
            textBox3 = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            grbItens = new GroupBox();
            textBox9 = new TextBox();
            lblTotal = new Label();
            lblDesconto = new Label();
            lblQuantidade = new Label();
            lblValorUnit = new Label();
            lblDescricao = new Label();
            lblCodbarras = new Label();
            txtDescontoItem = new TextBox();
            txtQuant = new TextBox();
            txtValorUnit = new TextBox();
            txtCodbarras = new TextBox();
            txtDescricao = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodbar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblNumero = new Label();
            txtIdPedido = new TextBox();
            txtSubTotal = new TextBox();
            txtDescontoPedido = new TextBox();
            txtDescontoItens = new TextBox();
            btnFechar = new Button();
            txtTotal = new TextBox();
            lblSubTotal = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            grbIdentificação.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificação
            // 
            grbIdentificação.Controls.Add(txtIdCliente);
            grbIdentificação.Controls.Add(lblCliente);
            grbIdentificação.Controls.Add(btnInserir);
            grbIdentificação.Controls.Add(textBox3);
            grbIdentificação.Controls.Add(txtUsuario);
            grbIdentificação.Controls.Add(label2);
            grbIdentificação.Location = new Point(150, 97);
            grbIdentificação.Margin = new Padding(3, 4, 3, 4);
            grbIdentificação.Name = "grbIdentificação";
            grbIdentificação.Padding = new Padding(3, 4, 3, 4);
            grbIdentificação.Size = new Size(602, 249);
            grbIdentificação.TabIndex = 0;
            grbIdentificação.TabStop = false;
            grbIdentificação.Text = "Identificação";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(141, 148);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(68, 27);
            txtIdCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(71, 152);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(71, 25);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(449, 144);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 36);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Abrir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 148);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 27);
            textBox3.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(145, 79);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(285, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 79);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 0;
            label2.Text = "Usúario";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(textBox9);
            grbItens.Controls.Add(lblTotal);
            grbItens.Controls.Add(lblDesconto);
            grbItens.Controls.Add(lblQuantidade);
            grbItens.Controls.Add(lblValorUnit);
            grbItens.Controls.Add(lblDescricao);
            grbItens.Controls.Add(lblCodbarras);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuant);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodbarras);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(114, 384);
            grbItens.Margin = new Padding(3, 4, 3, 4);
            grbItens.Name = "grbItens";
            grbItens.Padding = new Padding(3, 4, 3, 4);
            grbItens.Size = new Size(654, 425);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens de Pedido";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(534, 389);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(114, 27);
            textBox9.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(453, 385);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 28);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total R$";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(485, 27);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(72, 20);
            lblDesconto.TabIndex = 11;
            lblDesconto.Text = "Desconto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(416, 27);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(52, 20);
            lblQuantidade.TabIndex = 10;
            lblQuantidade.Text = "Quant.";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Location = new Point(341, 27);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(74, 20);
            lblValorUnit.TabIndex = 9;
            lblValorUnit.Text = "Valor Unit";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(137, 28);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição";
            // 
            // lblCodbarras
            // 
            lblCodbarras.AutoSize = true;
            lblCodbarras.Location = new Point(17, 28);
            lblCodbarras.Name = "lblCodbarras";
            lblCodbarras.Size = new Size(103, 20);
            lblCodbarras.TabIndex = 7;
            lblCodbarras.Text = "Código barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(486, 52);
            txtDescontoItem.Margin = new Padding(3, 4, 3, 4);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(70, 27);
            txtDescontoItem.TabIndex = 6;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextChanged += txtDescontoItem_TextChanged;
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(416, 52);
            txtQuant.Margin = new Padding(3, 4, 3, 4);
            txtQuant.Name = "txtQuant";
            txtQuant.RightToLeft = RightToLeft.Yes;
            txtQuant.Size = new Size(60, 27);
            txtQuant.TabIndex = 5;
            txtQuant.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(345, 52);
            txtValorUnit.Margin = new Padding(3, 4, 3, 4);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(61, 27);
            txtValorUnit.TabIndex = 4;
            // 
            // txtCodbarras
            // 
            txtCodbarras.Location = new Point(17, 52);
            txtCodbarras.Margin = new Padding(3, 4, 3, 4);
            txtCodbarras.Name = "txtCodbarras";
            txtCodbarras.Size = new Size(110, 27);
            txtCodbarras.TabIndex = 3;
           
            txtCodbarras.Leave += txtCodBar_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(137, 52);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(198, 27);
            txtDescricao.TabIndex = 2;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(566, 44);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(79, 43);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "&Adicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodbar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(17, 112);
            dgvItensPedido.Margin = new Padding(3, 4, 3, 4);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.RowHeadersWidth = 51;
            dgvItensPedido.Size = new Size(630, 265);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.MinimumWidth = 6;
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 45;
            // 
            // clnCodbar
            // 
            clnCodbar.Frozen = true;
            clnCodbar.HeaderText = "Cod Barras";
            clnCodbar.MinimumWidth = 6;
            clnCodbar.Name = "clnCodbar";
            clnCodbar.ReadOnly = true;
            clnCodbar.Width = 94;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.MinimumWidth = 6;
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 120;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.MinimumWidth = 6;
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 81;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.MinimumWidth = 6;
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.MinimumWidth = 6;
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 80;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.MinimumWidth = 6;
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 29);
            label1.Name = "label1";
            label1.Size = new Size(233, 42);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(659, 47);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(88, 23);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(744, 40);
            txtIdPedido.Margin = new Padding(3, 4, 3, 4);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(114, 27);
            txtIdPedido.TabIndex = 4;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(786, 475);
            txtSubTotal.Margin = new Padding(3, 4, 3, 4);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(114, 27);
            txtSubTotal.TabIndex = 5;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(786, 553);
            txtDescontoPedido.Margin = new Padding(3, 4, 3, 4);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.ReadOnly = true;
            txtDescontoPedido.Size = new Size(114, 27);
            txtDescontoPedido.TabIndex = 6;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(786, 619);
            txtDescontoItens.Margin = new Padding(3, 4, 3, 4);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.Size = new Size(114, 27);
            txtDescontoItens.TabIndex = 7;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(800, 749);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(86, 41);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(786, 691);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(114, 27);
            txtTotal.TabIndex = 8;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(786, 451);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(71, 20);
            lblSubTotal.TabIndex = 10;
            lblSubTotal.Text = "Sub Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(786, 529);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 11;
            label4.Text = "Desconto Itens";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(786, 595);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 12;
            label5.Text = "Desconto R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(786, 667);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 13;
            label6.Text = "Total";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 825);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSubTotal);
            Controls.Add(btnFechar);
            Controls.Add(txtTotal);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtSubTotal);
            Controls.Add(txtIdPedido);
            Controls.Add(lblNumero);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificação);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPedido";
            Text = "FormPedido";
            Load += FormPedido_Load;
            grbIdentificação.ResumeLayout(false);
            grbIdentificação.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificação;
        private GroupBox grbItens;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private Label lblNumero;
        private TextBox txtIdPedido;
        private TextBox textBox3;
        private TextBox txtIdCliente;
        private Label lblCliente;
        private Button btnInserir;
        private TextBox txtDescontoItem;
        private TextBox txtQuant;
        private TextBox txtValorUnit;
        private TextBox txtCodbarras;
        private TextBox txtDescricao;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private Label lblDesconto;
        private Label lblQuantidade;
        private Label lblValorUnit;
        private Label lblDescricao;
        private Label lblCodbarras;
        private TextBox textBox9;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtTotal;
        private Label lblSubTotal;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodbar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}