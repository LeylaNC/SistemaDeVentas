using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIAutenticacion;

namespace CapaVisual
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                Autenticacion autenticacion = new Autenticacion();
                autenticacion.Verificar(TxtBoxEmail.Text, TxtBoxPassword.Text);
                ProductosUsuario productos = new ProductosUsuario();
                productos.Show();
                Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
