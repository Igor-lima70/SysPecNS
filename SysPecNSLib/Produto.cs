using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace SysPecNSLib
{
    public class Produto
    {

        public int Id { get; set; }
        public string? Cod_barras { get; set; }
        public string? Descricao { get; set; }
        public double Valor_unit { get; set; }
        public string? Unidade_vendas { get; set; }
        public Categoria? Categoria { get; set; }
        public double Estoque_minimo { get; set; }
        public double Classe_desconto { get; set; }
        public byte[]? Imagem { get; set; }
        public DateTime Data_cad { get; set; }

        public Produto(string? cod_barras, string? descricao, double valor_unit, string? unidade_vendas, Categoria? categoria, double estoque_minimo, double classe_desconto)
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_vendas = unidade_vendas;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            
        }
        public Produto(string? cod_barras, string? descricao, double valor_unit, string? unidade_vendas, Categoria? categoria, double estoque_minimo, double classe_desconto, byte[]? imagem)
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_vendas = unidade_vendas;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Imagem = imagem;
         
        }
        public Produto( string? cod_barras, string? descricao, double valor_unit, string? unidade_vendas, Categoria? categoria, double estoque_minimo, double classe_desconto, byte[]? imagem, DateTime data_cad)
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_vendas = unidade_vendas;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Imagem = imagem;
            Data_cad = data_cad;
        }
        public Produto(int id, string? cod_barras, string? descricao, double valor_unit, string? unidade_vendas, Categoria? categoria, double estoque_minimo, double classe_desconto, byte[]? imagem, DateTime data_cad)
        {
            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_vendas = unidade_vendas;
            Categoria = categoria;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Imagem = imagem;
            Data_cad = data_cad;
        }
        public Produto()
        {
           
        }
        public void Inserir ()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit",Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_vendas);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());    
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_vendas);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
            cmd.ExecuteNonQuery();
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id ={id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    (byte[])dr.GetValue(8),
                    dr.GetDateTime(9)                 
                    
                    );
            }
            return produto;
        }
        public static List<Produto> ObterLista()
        {
            List<Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from produtos descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(dr.GetInt32(5)),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    (null),
                    dr.GetDateTime(9)
                    ));
            }
            return produtos;
        }
    }
}
