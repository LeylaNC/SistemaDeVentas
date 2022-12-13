using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaLogica
{
    public class Sesiones
    {

        public void IniciarSesion(ModeloPersonas modeloPersona)
        {
            ControladorUsuarios controladorUsuario = new ControladorUsuarios(modeloPersona);
        }

    }
}
