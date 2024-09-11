using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Tipo_endereco { get; set; }
        public Endereco()
        {

        }
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo_endereco)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_endereco = tipo_endereco;

        }
        public Endereco(int cliente_id, string cep ,  string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo_endereco)
        {
            Cliente_id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_endereco = tipo_endereco;

        }
        public Endereco(int id, int cliente_id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo_endereco)
        {
            Id = id;
            Cliente_id = cliente_id; 
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_endereco = tipo_endereco;

        }
        //inserir endereço do cliente
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from enderecos where id {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                    );
            }
            return endereco;
        }
        public static List<Endereco> ObterLista(string cliente_id = "")
        {
            List<Endereco> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from enderecos order by cliente_id";

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(6),
                        dr.GetString(8),
                        dr.GetString(9)
                        )
                    );
            }
            return lista;
        }

    }
}