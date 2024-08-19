
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
            SuspendLayout();
            // 
            // btnconfirma
            // 
            btnconfirma.Enabled = false;
            btnconfirma.Location = new Point(410, 96);
            btnconfirma.Name = "btnconfirma";
            btnconfirma.Size = new Size(75, 25);
            btnconfirma.TabIndex = 0;
            btnconfirma.Text = "&Confirma";
            btnconfirma.UseVisualStyleBackColor = true;
            btnconfirma.Click += button1_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(338, 97);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(66, 23);
            txtNumero2.TabIndex = 1;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(212, 136);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(192, 244);
            lstResultado.TabIndex = 2;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiação", "Logaritmos" });
            cmbOperacao.Location = new Point(157, 97);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(103, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(266, 98);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(66, 23);
            txtNumero1.TabIndex = 4;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 79);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 5;
            label1.Text = "Operação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 79);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Valor 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 79);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero1);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(txtNumero2);
            Controls.Add(btnconfirma);
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

        private Button btnconfirma;
        private TextBox txtNumero2;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
