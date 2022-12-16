using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//hash;
namespace CapaDeDatos
{
    public class ModeloPersonas
    {
        public int Ci;
        public string Email;
        public string HPassword;
        public string Nombre;
        public string Apellido;
        public int IdTelefono;
        public int IdDireccion;
        public string FechaNacimiento;
        public bool EsAdmin;

        public void VerificarUsuario(string json)
        {
            string[] credenciales = JsonSerializer. <Array>(json);

            //string json to Email, HPassword en controlador

            ModeloBD modeloBD = new ModeloBD();
            modeloBD.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText =
                "SELECT * FROM Personas " +
                "WHERE EXIST (SELECT Nombre FROM Personas WHERE Email ==" +
                Email + " AND Password ==" + HPassword + " AND EsAdmin == false)";

            MySqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Ci = reader.GetInt32(0);
                Email = reader.GetString(1);
                HPassword = reader.GetString(2);
                Nombre = reader.GetString(3);
                Apellido = reader.GetString(4);
                IdTelefono = reader.GetInt32(5);
                IdDireccion = reader.GetInt32(6);
                FechaNacimiento = reader.GetString(7);
                EsAdmin = reader.GetBoolean(8);

            }
        }
    }
}
