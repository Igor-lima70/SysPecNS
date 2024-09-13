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
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into estoques(produto_id,quantidade) values({Produto_id},{Quantidade})";
            cmd.ExecuteNonQuery();
        }

    }
}
