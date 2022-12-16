using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVisual
{
    public partial class LoginBackoffice : Form
    {
        public LoginBackoffice()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            ControladorPersonas controladorPersonas = new ControladorPersonas();
            controladorPersonas.VerificarAdministrador(TxtBoxEmail.Text, TxtBoxPassword.Text);

            MenuBackoffice menuBackoffice = new MenuBackoffice();
            menuBackoffice.Show();
            Hide();
        }
    }
}
