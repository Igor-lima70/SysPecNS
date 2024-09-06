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
          //  frmlogin.MdiParent = this;
            frmlogin.ShowDialog();
            Text += $" ({Program.UsuarioLogado.Email})";
            toolStripStatusLabel1.Text = $"{Program.UsuarioLogado.Nome} - {Program.UsuarioLogado.Nivel.Nome}";
        }
    }
}
