using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;

namespace APIAutenticacion
{
    public class Autenticacion
    {
        public void Verificar(string credenciales)
        {
            string jcredenciales = credenciales;
            ControladorPersonas controladorPersonas = new ControladorPersonas();
            controladorPersonas.VerificarUsuario(jcredenciales);
        }
    }
}
