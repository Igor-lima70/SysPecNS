using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Estoque
    {
        public int Produto_id { get; set; }
        public double Quantidade { get; set; }
        public DateTime Data_Ultimo_Movimento { get; set; }

        public Estoque()
        {
        }
        public Estoque(int produto_id, double quantidade, DateTime data_Ultimo_Movimento)
        {
            Produto_id = produto_id;
            Quantidade = quantidade;
            Data_Ultimo_Movimento = data_Ultimo_Movimento;
        }
        public Estoque(int produto_id, double quantidade)
        {
            Produto_id = produto_id;
            Quantidade = quantidade;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into estoques(produto_id,quantidade) values({Produto_id},{Quantidade})";
            cmd.ExecuteNonQuery();
        }
        public static Estoque ObterPorId(int produto_id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoques where produto_id = {produto_id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    );
            }
            return estoque;
        }
        public static List<Estoque> ObterLista(string produto_id)
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoques";
            var dr = cmd.ExecuteReader(); 
            while (dr.Read())
            {
                lista.Add(new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    ));
            }
            return lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update estoques set quantidade = {Quantidade} where produto_id = {Produto_id}";
            cmd.ExecuteNonQuery();
        }
    }   
}
