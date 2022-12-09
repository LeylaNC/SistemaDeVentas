using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIProductosVentas;

namespace CapaVisual
{
    public partial class ComprarUsuario : Form
    {
        public ComprarUsuario()
        {
            InitializeComponent();
        }

        private void BtnIngresarNuevaTarjeta_Click(object sender, EventArgs e)
        {
            RegistrarTarjetaUsuario registrarTarjeta = new RegistrarTarjetaUsuario();
            registrarTarjeta.Show();
            Hide();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            Comprar();

        }

        private void Comprar()
        {
            try
            {
                ProductosVentas productosVentas = new ProductosVentas();
                productosVentas.SeleccionarTarjeta();
                productosVentas.SeleccionarProductos();
                productosVentas.Comprar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
