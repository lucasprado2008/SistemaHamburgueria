using System;
using System.Runtime.InteropServices.WindowsRuntime;
using MySql.Data.MySqlClient;

namespace SistemaHamburgueria
{
    class Conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDPizzaria1;user=root;pwd=12345678");

        public static string msg;

        public MySqlConnection ConectarBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception erro)  
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }

        public MySqlConnection DesconectarBD()
        {
            try
            {
                con.Close();
            }
            catch(Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }
    }
}
