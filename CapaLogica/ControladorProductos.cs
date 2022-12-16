using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using System.Text.Json;

namespace CapaLogica
{
    public class ControladorProductos
    {

        public string GetProductos()
        {
            ModeloProductos modeloProducto = new ModeloProductos();
            modeloProducto.GetProductos();
            var ListaProductos = modeloProducto.ListaProductos;


            JsonSerializerOptions opt = new JsonSerializerOptions() { WriteIndented = true };
            string strJson = JsonSerializer.Serialize<IList<ModeloProductos>>(ListaProductos, opt);
            return strJson;
            ;
        }
    }
}
