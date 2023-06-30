using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models
{
    public class Conductor
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
        public string Telefono { get; set; }

        [Required]
        public string INE { get; set; }

        [Required]
        public string Licencia { get; set; }



    }
}
