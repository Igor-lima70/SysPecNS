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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            if (double.Parse(txtQuantidade.Text) <= 0)
            {
                MessageBox.Show("Não é possível inserir essa quatidade");
            }
            else if(double.Parse(txtQuantidade.Text) > 0)
            {
                Estoque estoque = new(
                    int.Parse(txtProduto_id.Text),
                    double.Parse(txtQuantidade.Text)
                    );
                estoque.Atualizar();
                MessageBox.Show("Estoque gravado com sucesso");
                FormEstoque_Load(sender, e);
            }
        }
        private void CarregaGrid(string produto_id = "")
        {
            var lista = Estoque.ObterLista(produto_id);
            dgvEstoque.Rows.Clear();
            int cont = 0;
            foreach (var estoque in lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[cont].Cells[0].Value = estoque.Produto_id;
                dgvEstoque.Rows[cont].Cells[1].Value = estoque.Quantidade;
                dgvEstoque.Rows[cont].Cells[2].Value = estoque.Data_Ultimo_Movimento;
                cont++;
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            if (double.Parse(txtQuantidade.Text) <= 0)
            {
                MessageBox.Show("Não é possível inserir essa quatidade");
            }
            else if (double.Parse(txtQuantidade.Text) > 0)
            {
                Estoque estoque = new(
                    int.Parse(txtProduto_id.Text),
                    double.Parse(txtQuantidade.Text)
                    );
                estoque.Atualizar();
                MessageBox.Show("Estoque gravado com sucesso");
                FormEstoque_Load(sender, e);
            }
        }
        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormEstoqProd formEstoqProd = new();
            formEstoqProd.ShowDialog();
        }
    }
}
