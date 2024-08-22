using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Crypto.Parameters;
using System.Runtime;

namespace SysPecNSLib
{
    public class Nivel
    {
        // atributos ()

        // private int id;
        // private string nome
        //private string sigla;
        //public string sigla {get {return sigla;} set {sigla = value;} }

        //
        /// metodos de acesso (get e set)
        // public int id { get => id; set => id = value;}

        // propriedades
        public int Id {  get; set; }
        public string? Nome { get; set; }

        public string? Sigla { get; set; }

        // metodos construtores
        public Nivel() { }

        public Nivel(string nome, string sigla) // sobrecarga de metodos
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        
        // metodos (requisitos)
        /// <summary>
        /// Metodos para inserir registro de nivel na base de dados
        /// </summary>
        public void Inserir()
        {
            // conectando com banco de dados
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis(nome,sigla) values ('{Nome}','{Sigla}')";
            cmd.ExecuteNonQuery();
        }

        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new Nivel();   
            // consulta no banco e retornar o nivel
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM niveis where id = {id};";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            return nivel;
        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new List<Nivel>();
            // consulta para retornar a lista de niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(dr.GetInt32(0),dr.GetString(1),dr.GetString(2)));
            }
            return lista;
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update niveis" + $"set nome = '{Nome}',sigla = '{Sigla}' where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public void Excluir()
        {
            // em geral nada se exclui de uma tabela
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from niveis where id = {Id}";
            cmd.ExecuteNonQuery();
            
        }

    }
}
