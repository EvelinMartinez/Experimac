using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Experimac.Models
{
    [Table("usuarios")]
     public class Usuarios
    {
        [Key]
        public int pkUsuarios { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del Usuario")]
        public String sNombre { get; set; }

        [Required(ErrorMessage = "Se requiere Password")]
        public String sPassword { get; set; }

        [Required(ErrorMessage = "Se requiere el correo del Usuario")]
        public String sCorreo { get; set; }

        public Boolean bStatus { get; set; }


        //  Relaciones  \\

        public Ordenes ordenes{ get; set; }

        public Usuarios()
        {
            this.bStatus = true;
        }
    }
}
