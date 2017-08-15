using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Experimac.Models
{
    [Table("servicios")]
    public class servicios
    {
        [Key]
        public int pkServicio { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del Servicio")]
        public String Nomb_Serv { get; set; }


        [Required(ErrorMessage = "Se requiere el Costo del Servicio")]
        public String Costo_serv { get; set; }

        [Required(ErrorMessage = "Se requiere Descripcion del Servicio")]
        public String sDescripcion { get; set; }

        public Boolean bStatus { get; set; }


        //  Relaciones  \\
        public ICollection<Ordenes> Ordenes { get; set; }

        public servicios()
        {
            this.bStatus = true;
        }
    }
}
