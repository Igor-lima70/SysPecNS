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
    public partial class FormEndereco : Form
    {
        public FormEndereco()
        {
            InitializeComponent();
        }
        private void FormEndereco_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
               int.Parse(txtClienteID.Text),
               txtTipoEndereco.Text,
               txtCep.Text,
               txtLogradouro.Text,
               txtNumero.Text,
               txtComplemento.Text,
               txtBairro.Text,
               txtCidade.Text,
               txtUF.Text
               );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                MessageBox.Show($"Endereço foi inserido com sucesso");
                FormEndereco_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao Inserir Endereco");
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
        private void CarregaGrid(string cliente_id = "")
        {
            var lista = Endereco.ObterLista(cliente_id);
            dgvEndereco.Rows.Clear();
            int cont = 0;
            foreach (var endereco in lista)
            {
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[cont].Cells[0].Value = endereco.Id;
                dgvEndereco.Rows[cont].Cells[1].Value = endereco.Cliente_id;
                dgvEndereco.Rows[cont].Cells[2].Value = endereco.Tipo_endereco;
                dgvEndereco.Rows[cont].Cells[3].Value = endereco.Cep;
                dgvEndereco.Rows[cont].Cells[4].Value = endereco.Logradouro;
                dgvEndereco.Rows[cont].Cells[5].Value = endereco.Numero;
                dgvEndereco.Rows[cont].Cells[6].Value = endereco.Complemento;
                dgvEndereco.Rows[cont].Cells[7].Value = endereco.Bairro;
                dgvEndereco.Rows[cont].Cells[8].Value = endereco.Cidade;
                dgvEndereco.Rows[cont].Cells[9].Value = endereco.UF;
                

                cont++;
            }
        }
    }
}