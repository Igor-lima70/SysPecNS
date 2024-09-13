using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    public static class Banco //Classe de conexão de banco de dados 
    {
        /// <summary>
        /// Método abrir da classe Banco é utilizado para representar comandos SQL
        /// no servidor, cujos os dados foram informados na string de conexão (strconn)
        /// </summary>
        /// <returns>Entrega um objeto no SQL, que serão executados na conexão informada</returns>
        public static MySqlCommand Abrir() //método de conexão
        {
            // dados de conexão
            //string strconn = @"server=10.91.45.21;database=syspecdb;user=root;password=root";
            string strconn = @"server=127.0.0.1;database=syspecdb;user=root;password=";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand();
            try // Tratamento de excessão
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {

                throw;
            }
            return cmd;
        }
    }
}
