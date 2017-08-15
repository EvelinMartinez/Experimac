using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Experimac.Models
{
     public class Solicita
    {
        [Table ("solicita")]
        public class solicita
        {
            [Key]
            public int pkSolicita { get; set; }

            [Required(ErrorMessage = "Se requiere la Fecha")]
            public String Fecha { get; set; }

            [Required(ErrorMessage = "Se requiere la Hora")]
            public String Hora { get; set; }


            public Boolean bStatus { get; set; }


            //  Relaciones  \\
            public Ordenes Ordenes { get; set; }

            public solicita()
            {
                this.bStatus = true;
            }
        }
    }
}
