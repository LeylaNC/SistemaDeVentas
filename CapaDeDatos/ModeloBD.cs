using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

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

        //
        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet dataSet = new DataSet();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "result");
                return dataSet;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        //
        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
