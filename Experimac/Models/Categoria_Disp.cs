using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Experimac.Models
{
    [Table("Categoria_disp")]
   public class Categoria_Disp
    {
        [Key]
        public int pkCategoria_Disp { get; set; }

        [Required(ErrorMessage = "Se requiere el Nombre de la Categoría del Dispositivo")]
        public String Nomb_Categ_Disp { get; set; }

        public Boolean bStatus { get; set; }


        //  Relaciones  \\
        public ICollection<Dispositivos> Dispositivos { get; set; }

        public Categoria_Disp()
        {
            this.bStatus = true;
        }
    }
}
