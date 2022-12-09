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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            LoginUsuario login = new LoginUsuario();
            login.Show();
            Hide();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrar = new RegistrarUsuario();
            registrar.Show();
            Hide();
        }
    }
}
