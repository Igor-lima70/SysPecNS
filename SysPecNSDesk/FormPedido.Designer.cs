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
            gbIdentificação = new GroupBox();
            gbItens = new GroupBox();
            label1 = new Label();
            lblNumero = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            textBox3 = new TextBox();
            gbIdentificação.SuspendLayout();
            SuspendLayout();
            // 
            // gbIdentificação
            // 
            gbIdentificação.Controls.Add(textBox3);
            gbIdentificação.Controls.Add(txtUsuario);
            gbIdentificação.Controls.Add(label2);
            gbIdentificação.Location = new Point(92, 73);
            gbIdentificação.Name = "gbIdentificação";
            gbIdentificação.Size = new Size(610, 260);
            gbIdentificação.TabIndex = 0;
            gbIdentificação.TabStop = false;
            gbIdentificação.Text = "Identificação";
            // 
            // gbItens
            // 
            gbItens.Location = new Point(92, 354);
            gbItens.Name = "gbItens";
            gbItens.Size = new Size(610, 253);
            gbItens.TabIndex = 1;
            gbItens.TabStop = false;
            gbItens.Text = "Itens de Pedido";
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
            lblNumero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(590, 32);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(654, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 66);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Usúario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(126, 66);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(214, 23);
            txtUsuario.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 2;
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 619);
            Controls.Add(textBox1);
            Controls.Add(lblNumero);
            Controls.Add(label1);
            Controls.Add(gbItens);
            Controls.Add(gbIdentificação);
            Name = "FormPedido";
            Text = "FormPedido";
            Load += FormPedido_Load;
            gbIdentificação.ResumeLayout(false);
            gbIdentificação.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbIdentificação;
        private GroupBox gbItens;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private Label lblNumero;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}