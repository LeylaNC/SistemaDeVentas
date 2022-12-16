using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class ModeloProductos
    {
        int IdProducto { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        int Precio { get; set; }
        int Cantidad { get; set; }
        //public List<ModeloProductos> ListaProductos {get; set;}
        public DataTable tablaProductos = new DataTable();


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

                MySqlDataReader reader;
                reader = command.ExecuteReader();

                tablaProductos.Load(reader);


                

                //if (reader.HasRows)
                //{
                    //while (reader.Read())
                    //{
                        //IdProducto = reader.GetInt32(0);
                        //Nombre = reader.GetString(1);
                        //Descripcion = reader.GetString(2);
                        //Precio = reader.GetInt32(3);
                        //Cantidad = reader.GetInt32(4);

                        //List<string> ListaNombre = new List<string>();
                        //List<string> ListaDescripcion = new List<string>();
                        //List<int> ListaPrecio= new List<int>();
                        //List<int> ListaCantidad = new List<int>();

                        //ModeloProductos modeloProducto = new ModeloProductos(IdProducto, Nombre, Descripcion, Precio, Cantidad);

                        //ListaProductos.Add(modeloProducto);

                    //}
                //}
                //else
                //{
                    //Console.WriteLine("Error");
                //}

                modeloBD.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
           
        }

    }
}
