using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Experimac.Models
{
    [Table("Dispositivos")]
   public class Dispositivos
    {
        [Key]
        public int pkDispositivos { get; set; }

       // [Required(ErrorMessage = "Se requiere el No. del Modelo del dispositivo")]
        public String No_Modelo { get; set; }

        //[Required(ErrorMessage = "Se requiere el Modelo del dispositivo")]
        public String Modelo { get; set; }

        //[Required(ErrorMessage = "Se requiere el No. Serie del Dispositivo")]
        public String No_Serie { get; set; }

       // [Required(ErrorMessage = "Se requiere Id del Modelo del dispositivo")]
        public String Id_Modelo { get; set; }

       // [Required(ErrorMessage = "Se requiere el tamaño del dispositivo")]
        public String Medida { get; set; }

        //[Required(ErrorMessage = "Se requiere el Estado de la Bateria")]
        public String Estado_Bateria { get; set; }

        //[Required(ErrorMessage = "Se requieren los Ciclos de la Bateria")]
        public String Ciclos_Bateria { get; set; }

       // [Required(ErrorMessage = "Se requieren el Almacenamiento del dispositivo")]
        public String Almacenamiento { get; set; }

        //[Required(ErrorMessage = "Se requiere el IMEI del dispositivo")]
        public String IMEI { get; set; }

        //[Required(ErrorMessage = "Se requiere el Código / Pass del dispositivo")]
        public String Codigo_Pass { get; set; }

        //[Required(ErrorMessage = "Se requiere el procesador del dispositivo")]
        public String Procesador { get; set; }

        //[Required(ErrorMessage = "Se requiere el Pass_Id del dispositivo")]
        public String Pass_Id { get; set; }

        //[Required(ErrorMessage = "Se requieren los Núcleos del dispositivo")]
        public String Nucleos { get; set; }

        //[Required(ErrorMessage = "Se requiere Memoria Video del dispositivo")]
        public String Mem_Video { get; set; }

        //[Required(ErrorMessage = "Se requiere Pass Apple Id del dispositivo")]
        public String  Apple_Id  { get; set; }

        //[Required(ErrorMessage = "Se requiere Almacenamiento_Dos del dispositivo")]
        public String Almacenamiento_Dos { get; set; }

        //[Required(ErrorMessage = "Se requiere Memoria_Ram del dispositivo")]
        public String Memoria_Ram { get; set; }



        public Boolean bStatus { get; set; }


        //  Relaciones  \\
        public ICollection<Categoria_Disp> Categ_Dispositivos { get; set; }

        public Dispositivos()
        {
            this.bStatus = true;
        }
    }
}
