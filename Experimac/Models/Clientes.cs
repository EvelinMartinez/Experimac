using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Experimac.Models
{
    [Table("clientes")]
    public class Clientes
    {
        [Key]
        public int pkcliente { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del Cliente")]
        public String Nomb_Cliente { get; set; }


        [Required(ErrorMessage = "Se requiere el correo del Cliente")]
        public String sCorreo { get; set; }

        [Required(ErrorMessage = "Se requiere número telefonico del cliente")]
        public String sTelefono { get; set; }

        public Boolean bStatus { get; set; }


        //  Relaciones  \\
        public Ordenes Ordenes { get; set; }

        public Clientes()
        {
            this.bStatus = true;
        }
    }
}
