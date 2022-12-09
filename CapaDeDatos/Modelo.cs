using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    class Modelo
    {
        string connectionString = @""+
            "server=localhost;" +
            "user id=user;" +
            "password=12345678;" +
            "database=database";
        private void Conectar()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
        }
    }
}
