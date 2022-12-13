using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
//using MySql
namespace CapaLogica
{
    public class ControladorPersonas
    {
        
        public void VerificarUsuario(string json)
        {
            try
            {
                ModeloPersonas modeloPersonas = new ModeloPersonas();
                modeloPersonas.VerificarUsuario(json);
                Sesiones controladorSesiones = new Sesiones();
                controladorSesiones.IniciarSesion();
            }
            catch (Exception ex)
            {
                
            }
            //ControladorSesion

            //using MySqlDataReader rdr = cmd.ExecuteReader();

            //credenciales = get users email & passwords where email == and passw == 
            //msgbox
            //else ControladorSesion sesionactual = new ControladorSesion (credenciales)
        }

        //VerificarAdministrador(string email, string password)

    }
}
