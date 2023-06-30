using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models
{
    public class ModuloGPS
    {


        [Key]
        [Display(Name = "Id Conductor")]
        [Required(ErrorMessage = "Se debe ingresar un Id")]
        public string IdCond { get; set; }

        [Required(ErrorMessage = "Se debe ingresar un nombre")]
        public string Nombre { get; set; }

        [Required]
        public string IdLin { get; set; }

        [Required]
        public string Placas { get; set; }

        [Required]
        public string Temperatura { get; set; }

        [Required]
        public string Fecha { get; set; }

        [Required]
        public string Hora { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Se debe ingresar la latitud")]
        public string Latitud { get; set; }

        [Required(ErrorMessage = "Se debe ingresar la longitud")]
        public string Longitud { get; set; }


    }
}
