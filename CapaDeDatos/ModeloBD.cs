using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    class ModeloBD
    {
        MySqlConnection connection = new MySqlConnection();
        string myConnectionString;
        static string server = "localhost";
        static string database = "sistemaDeVentas";
        static string userId= "root";
        public static string strProvider = "server=" + server + ";Database=" + database + ";User ID=" + userId;

        public bool Open()
        {
            try
            {
                strProvider = "server=" + server + ";Database=" + database + ";User ID=" + userId;
                connection = new MySqlConnection(strProvider);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error ! " + ex.Message, "Information");
            }
            return false;
        }

        public void Close()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
