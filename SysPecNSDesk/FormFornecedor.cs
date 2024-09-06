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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }
        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(txtRazao_social.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtContato.Text,
                txtTelefone.Text,
                txtEmail.Text
                );
            fornecedor.Inserir();
            if (fornecedor.Id > 0)
            {
                MessageBox.Show($"Fornecedor {fornecedor.Razao_social} foi inserido com sucesso com o ID {fornecedor.Id}");
                FormFornecedor_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Inserir Fornecedor");
            }
        }
        private void txtBusca_TextChanged(object sender, EventArgs e)
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
        private void CarregaGrid(string razao_social = "")
        {
            var lista = Fornecedor.ObterLista(razao_social);
            dgvFornecedor.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                dgvFornecedor.Rows.Add();
                dgvFornecedor.Rows[cont].Cells[0].Value = fornecedor.Id;
                dgvFornecedor.Rows[cont].Cells[1].Value = fornecedor.Razao_social;
                dgvFornecedor.Rows[cont].Cells[2].Value = fornecedor.Fantasia;
                dgvFornecedor.Rows[cont].Cells[3].Value = fornecedor.CNPJ;
                dgvFornecedor.Rows[cont].Cells[4].Value = fornecedor.Contato;
                dgvFornecedor.Rows[cont].Cells[5].Value = fornecedor.Telefone;
                dgvFornecedor.Rows[cont].Cells[6].Value = fornecedor.Email;

                cont++;
            }
        }
        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtRazao_social.Clear();
                txtFantasia.Clear();
                txtCnpj.Clear();
                txtContato.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                btnConsultar.Text = "&Obter Por Id";
                txtId.Focus();
                txtId.ReadOnly = false;
            }
        }
    }
}
