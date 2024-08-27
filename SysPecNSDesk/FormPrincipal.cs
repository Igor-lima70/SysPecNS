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
    }
}
