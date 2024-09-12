using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new();
            formUsuario.MdiParent = this;
            formUsuario.Show();

            //formUsuario.ShowDialog(); esse comando deixa o formulario como "principal"
        }

        private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) Application.Exit();

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new();
            formProduto.MdiParent = this;
            formProduto.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormLogin frmlogin = new();
            frmlogin.ShowDialog();
            Text += $" ({Program.UsuarioLogado.Email})";
            toolStripStatusLabel1.Text = $"{Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}";
        }
        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormPedido formpedido = new();
            formpedido.MdiParent = this;
            formpedido.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formcliente = new();
            formcliente.MdiParent = this;
            formcliente.Show();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEndereco formendereco = new();
            formendereco.MdiParent = this;
            formendereco.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFornecedor formfornecedor = new();
            formfornecedor.MdiParent = this;
            formfornecedor.Show();
        }
    }
}
