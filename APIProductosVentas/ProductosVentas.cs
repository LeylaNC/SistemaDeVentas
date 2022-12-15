using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;

namespace APIProductosVentas
{
    public class ProductosVentas
    {
        public void IngresarTarjeta()
        {
            //Json ig => UpdateUsuariosTarjetas
        }

        public void SeleccionarTarjeta()
        {
            //ComboBoxTarjeta.Text to Json ig
        }

        public void CargarTablaProductos()
        {  
            
            ControladorProductos controladorProducto = new ControladorProductos();
            string jProductos = controladorProducto.;
            //
            //return jProductos;
        }
        public void Comprar()
        {
            try
            {
                IngresarVenta();
                QuitarProductos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        void IngresarVenta()
        {
            //Json to capa logica ig => InsertVentas
        }
        void QuitarProductos()
        {
            //Json to capa logica ig => UpdateProductos
        }

    }
}
