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

        public void Conectar()
        {
            MySqlConnection connection = new MySqlConnection( @""+
            "server=localhost;" +
            "user id=root;" +
            "database=sistemaDeVentas");
            connection.Open();
        }
    }
}
