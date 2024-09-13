using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
        
    }
}
