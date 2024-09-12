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
            grbIdentificacao = new GroupBox();
            txtIdCliente = new TextBox();
            lblCliente = new Label();
            btnInserir = new Button();
            textBox3 = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            grbItens = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
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
            txtDescontoItens = new TextBox();
            txtDescontoPedido = new TextBox();
            btnFechar = new Button();
            txtTotal = new TextBox();
            lblSubTotal = new Label();
            label10 = new Label();
            label5 = new Label();
            label6 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(lblCliente);
            grbIdentificacao.Controls.Add(btnInserir);
            grbIdentificacao.Controls.Add(textBox3);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label2);
            grbIdentificacao.Location = new Point(131, 73);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(527, 187);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(123, 111);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(60, 23);
            txtIdCliente.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(62, 114);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(393, 108);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(70, 27);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Abrir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 23);
            textBox3.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(127, 59);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(250, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 59);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Usúario";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(label4);
            grbItens.Controls.Add(textBox1);
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
            grbItens.Location = new Point(100, 288);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(572, 319);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens de Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(430, 64);
            label4.Name = "label4";
            label4.Size = new Size(23, 17);
            label4.TabIndex = 14;
            label4.Tag = "";
            label4.Text = "R$";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(461, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(396, 289);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(68, 21);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total R$";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(424, 20);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 11;
            lblDesconto.Text = "Desconto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(364, 20);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(43, 15);
            lblQuantidade.TabIndex = 10;
            lblQuantidade.Text = "Quant.";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Location = new Point(298, 20);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(58, 15);
            lblValorUnit.TabIndex = 9;
            lblValorUnit.Text = "Valor Unit";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(118, 21);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição";
            // 
            // lblCodbarras
            // 
            lblCodbarras.AutoSize = true;
            lblCodbarras.Location = new Point(15, 20);
            lblCodbarras.Name = "lblCodbarras";
            lblCodbarras.Size = new Size(97, 15);
            lblCodbarras.TabIndex = 7;
            lblCodbarras.Text = "Código de barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(425, 39);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(62, 23);
            txtDescontoItem.TabIndex = 6;
            txtDescontoItem.Text = "0";
            // 
            // txtQuant
            // 
            txtQuant.Location = new Point(364, 39);
            txtQuant.Name = "txtQuant";
            txtQuant.RightToLeft = RightToLeft.Yes;
            txtQuant.Size = new Size(53, 23);
            txtQuant.TabIndex = 5;
            txtQuant.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(302, 39);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(54, 23);
            txtValorUnit.TabIndex = 4;
            // 
            // txtCodbarras
            // 
            txtCodbarras.Location = new Point(15, 39);
            txtCodbarras.Name = "txtCodbarras";
            txtCodbarras.Size = new Size(97, 23);
            txtCodbarras.TabIndex = 3;
            txtCodbarras.Leave += txtCodbarras_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(120, 39);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(174, 23);
            txtDescricao.TabIndex = 2;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(495, 33);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(69, 32);
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
            dgvItensPedido.Location = new Point(15, 84);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(551, 199);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 45;
            // 
            // clnCodbar
            // 
            clnCodbar.Frozen = true;
            clnCodbar.HeaderText = "Cod Barras";
            clnCodbar.Name = "clnCodbar";
            clnCodbar.ReadOnly = true;
            clnCodbar.Width = 94;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 120;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 81;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 80;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 22);
            label1.Name = "label1";
            label1.Size = new Size(164, 35);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(577, 35);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(71, 18);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.Location = new Point(651, 30);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.ReadOnly = true;
            txtIdPedido.Size = new Size(100, 29);
            txtIdPedido.TabIndex = 4;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(688, 356);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 5;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(688, 415);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(100, 23);
            txtDescontoItens.TabIndex = 6;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(688, 464);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 7;
            txtDescontoPedido.TextChanged += txtDescontoPedido_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(700, 562);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 31);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(688, 518);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(688, 338);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(55, 15);
            lblSubTotal.TabIndex = 10;
            lblSubTotal.Text = "Sub Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(688, 397);
            label10.Name = "label10";
            label10.Size = new Size(85, 15);
            label10.TabIndex = 11;
            label10.Text = "Desconto Itens";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(688, 446);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 12;
            label5.Text = "Desconto R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(688, 500);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 13;
            label6.Text = "Total";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 619);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(lblSubTotal);
            Controls.Add(btnFechar);
            Controls.Add(txtTotal);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtSubTotal);
            Controls.Add(txtIdPedido);
            Controls.Add(lblNumero);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Name = "FormPedido";
            Text = "FormPedido";
            Load += FormPedido_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
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
        private TextBox textBox1;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtDescontoItens;
        private TextBox txtDescontoPedido;
        private Button btnFechar;
        private TextBox txtTotal;
        private Label lblSubTotal;
        private Label label10;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodbar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private Label label4;
    }
}