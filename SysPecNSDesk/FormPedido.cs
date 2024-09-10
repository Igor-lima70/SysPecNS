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
    public partial class FormPedido : Form
    {
        Produto produto;
        public FormPedido()
        {
            InitializeComponent();
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIdCliente.Text)), 0
                );
            pedido.Inserir();
        }

        private void txtCodbarras_Leave(object sender, EventArgs e)
        {
            if (txtCodbarras.TextLength > 0)
            {
                var produto = Produto.ObterPorId(txtCodbarras.Text);
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.Valor_unit.ToString();
                txtValorUnit.ReadOnly = true;
                txtQuant.Focus();

            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.Valor_unit,
                double.Parse(txtQuant.Text),
                double.Parse(txtDescontoItem.Text)
                );
            produto = new();
            txtDescontoItem.Text = "0";
            txtDescricao.Clear();
            txtValorUnit.Text = "0";
            txtQuant.Text = "1";
            txtCodbarras.Clear();
            txtCodbarras.Focus();

            PreencherGridItens();

        }
        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = item.Id;
                dgvItensPedido.Rows[linha].Cells[0].Value = item.Produto.Cod_barras;
                dgvItensPedido.Rows[linha].Cells[0].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[0].Value = item.ValorUnit;
                dgvItensPedido.Rows[linha].Cells[0].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[0].Value = item.Desconto;
                dgvItensPedido.Rows[linha].Cells[0].Value = item.ValorUnit * item.Quantidade - item.Desconto;
                linha++;
                 

            }
        } 
    }
}
