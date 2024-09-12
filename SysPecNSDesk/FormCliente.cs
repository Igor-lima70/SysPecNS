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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        private void FormCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void CarregaGrid(string nome = "")
        {
            var lista = Cliente.ObterLista(nome);
            dgvCliente.Rows.Clear();
            int cont = 0;
            foreach (var cliente in lista)
            {
                dgvCliente.Rows.Add();
                dgvCliente.Rows[cont].Cells[0].Value = cliente.Id;
                dgvCliente.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvCliente.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvCliente.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgvCliente.Rows[cont].Cells[4].Value = cliente.Email;
                dgvCliente.Rows[cont].Cells[5].Value = cliente.Data_nasc;
                cont++;

            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtEmail.Text,
                dtpDataNasc.Value
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                MessageBox.Show($"Cliente {cliente.Nome} foi inserido com sucesso com o ID {cliente.Id}");

                txtId.Clear();
                txtNome.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                FormCliente_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Grava Cliente!");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            FormEndereco formendereco = new();
            formendereco.MdiParent = this;
            formendereco.Show();
        }
    }
}