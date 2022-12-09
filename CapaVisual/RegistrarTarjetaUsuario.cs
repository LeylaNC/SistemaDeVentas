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
    public partial class RegistrarTarjetaUsuario : Form
    {
        public RegistrarTarjetaUsuario()
        {
            InitializeComponent();
        }

        private void BtnIngresarTarjeta_Click(object sender, EventArgs e)
        {
            ProductosVentas productos = new ProductosVentas();
            productos.IngresarTarjeta();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ComprarUsuario comprar = new ComprarUsuario();
            comprar.Show();
            Close();
        }
    }
}
