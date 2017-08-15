using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Experimac.Models
{
    [Table("Ordenes")]
    public class Ordenes
    {
        public int pkOrdenes { get; set; }

        [Required(ErrorMessage = "Se requiere el Nombre de la Orden")]
        public String Nomb_Serv { get; set; }


        [Required(ErrorMessage = "Se requiere la Fecha de la Orden")]
        public DateTime Fecha_Orden { get; set; }

        [Required(ErrorMessage = "Se requieren los comentarios acerca de la Orden")]
        public String Comentarios { get; set; }

        public Boolean bStatus { get; set; }


        //  Relaciones  \\
        public ICollection<Usuarios> usuarios { get; set; }
        public ICollection<servicios> servicios { get; set; }
        public ICollection<Clientes> clientes { get; set; }
        public ICollection<Dispositivos> Dispositivos { get; set; }
        

        public Ordenes()
        {
            this.bStatus = true;
        }
    }
}
