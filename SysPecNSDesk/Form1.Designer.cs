
namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnconfirma = new Button();
            txtNumero2 = new TextBox();
            lstResultado = new ListBox();
            cmbOperacao = new ComboBox();
            txtNumero1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnconfirma
            // 
            btnconfirma.Enabled = false;
            btnconfirma.Location = new Point(467, 131);
            btnconfirma.Margin = new Padding(3, 4, 3, 4);
            btnconfirma.Name = "btnconfirma";
            btnconfirma.Size = new Size(86, 27);
            btnconfirma.TabIndex = 0;
            btnconfirma.Text = "&Confirma";
            btnconfirma.UseVisualStyleBackColor = true;
            btnconfirma.Click += button1_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(386, 131);
            txtNumero2.Margin = new Padding(3, 4, 3, 4);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(75, 27);
            txtNumero2.TabIndex = 1;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(242, 181);
            lstResultado.Margin = new Padding(3, 4, 3, 4);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(219, 324);
            lstResultado.TabIndex = 2;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiação", "Logaritmos" });
            cmbOperacao.Location = new Point(179, 129);
            cmbOperacao.Margin = new Padding(3, 4, 3, 4);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(117, 28);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(304, 131);
            txtNumero1.Margin = new Padding(3, 4, 3, 4);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(75, 27);
            txtNumero1.TabIndex = 4;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 105);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 5;
            label1.Text = "Operação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 105);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Valor 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 105);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "Valor 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(542, 399);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(677, 399);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(600, 449);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 31);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero1);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero2);
            Controls.Add(btnconfirma);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private Button btnconfirma;
        private TextBox txtNumero2;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
