using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CtrlUnidades.Models
{
    public class Ubicacion
    {
        [Key]
        [Display(Name = "Id ubicacion")]
        [Required(ErrorMessage = "Se debe ingresar un Id")]
        public string Id_Ubicacion { get; set; }

        [Required(ErrorMessage = "Se debe ingresar un nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Se debe ingresar un contacto")]
        public string Contacto { get; set; }

        public string? Observaciones { get; set; }

    }
}
