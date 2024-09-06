using SysPecNSLib;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            { 
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo)
                    {
                        Program.UsuarioLogado = usuario;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usuário esta inativo. \n Procure a gerência");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Inválidos, ou Inexistentes. \n Procure a gêrencia");
                }
            }
            else
            {
                MessageBox.Show("Você deve preencher todos os campos");
                txtEmail.Focus();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
