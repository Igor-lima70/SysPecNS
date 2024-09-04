using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string? Razao_social { get; set; }
        public string? Fantasia { get; set; }
        public string? CNPJ { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        public Fornecedor(int id, string? razao_social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Id = id;
            Razao_social = razao_social;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor(string? razao_social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            Razao_social = razao_social;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor()
        {
            
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;

        }
    }
}
