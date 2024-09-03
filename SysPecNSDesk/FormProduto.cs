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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            var categorias = Categoria.ObterLista();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            CarregaGrid();
        }
        private void CarregaGrid(string nome = "")
        {
            //preenchendo o datagrid com os usuários
            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.Cod_barras;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.Valor_unit;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.Unidade_vendas;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Categoria;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.Estoque_minimo;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.Classe_desconto;
                dgvProdutos.Rows[cont].Cells[8].Value = produto.Data_cad;

                cont++;

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodbar.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)nudEstoqMin.Value,double.Parse(txtDescricao.Text)
                
                );
            produto.Inserir();
            if (produto.Id>0)
            {
                MessageBox.Show($"Produto gravado com sucesso com o ID {produto.Id}");
                FormProduto_Load(sender, e);
            }
        }
    }
}
