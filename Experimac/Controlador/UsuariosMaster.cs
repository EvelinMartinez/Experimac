using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experimac.Models;


namespace Experimac.Controlador
{
    
    class UsuariosMaster
    {
        public static Usuarios validarLogin(string nombre, string pasword)
        {
            try
            {
                var contex = new DataModel();
                return contex.usuarios.Where(r => r.sNombre == nombre && r.sPassword == pasword && r.bStatus == true).FirstOrDefault();
             
            }
            catch(Exception)
            {
                return null;
            }
        }
        
    }
}
