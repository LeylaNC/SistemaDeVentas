using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ModeloProductos
    {
        int IdProducto { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        int Precio { get; set; }
        int Cantidad { get; set; }
        public List<ModeloProductos> ListaProductos {get; set;}

        public ModeloProductos(int idProducto, string nombre, string descripcion, int precio, int cantidad)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }

        public ModeloProductos()
        {
            IdProducto = -1;
            Nombre = "default";
            Descripcion = "default";
            Precio = -1;
            Cantidad = -1;
        }


        public void GetProductos()
        {
            try
            {
                ModeloBD modeloBD = new ModeloBD();
                modeloBD.Open();

                MySqlCommand command = new MySqlCommand();
                command.CommandText = "SELECT * FROM Productos WHERE Cantidad > 0";
                //string query = "SELECT * FROM Productos WHERE Cantidad > 0";

                MySqlDataReader reader;
                reader = command.ExecuteReader();
                //reader = command.ExecuteReader(query);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        IdProducto = reader.GetInt32(0);
                        Nombre = reader.GetString(1);
                        Descripcion = reader.GetString(2);
                        Precio = reader.GetInt32(3);
                        Cantidad = reader.GetInt32(4);

                        ModeloProductos modeloProducto = new ModeloProductos(IdProducto, Nombre, Descripcion, Precio, Cantidad);

                        ListaProductos.Add(modeloProducto);

                    }
                }
                else
                {
                    Console.WriteLine("Data not found");
                }

                modeloBD.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
           
        }

    }
}
