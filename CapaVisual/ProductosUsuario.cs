using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class ProductosUsuario : Form
    {
        public ProductosUsuario()
        {
            InitializeComponent();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar seleccion probablemente
                ComprarUsuario comprar = new ComprarUsuario();
                comprar.Show();
                Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
