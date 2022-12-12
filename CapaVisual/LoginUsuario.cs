using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
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
            string[] credenciales = new string[2] { TxtBoxEmail.Text, TxtBoxPassword.Text };
            string json = JsonSerializer.Serialize<Array>(credenciales);
            
            try
            {
                Autenticacion autenticacion = new Autenticacion();
                autenticacion.Verificar(json);
                ProductosUsuario productos = new ProductosUsuario();
                productos.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                Console.WriteLine(ex.Message);
            }


        }
    }
}
