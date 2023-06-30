using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models
{
    public class LineaTransportista
    {

        [Key]
        [Display(Name = "Id Linea")]
        [Required(ErrorMessage = "Se debe ingresar un Id")]
        public string IdLin { get; set; }

        [Required(ErrorMessage = "Se debe ingresar un nombre")]
        public string Nombre { get; set; }

        [Required]
        public string Contacto { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Correo { get; set; }

        [Required]
        public string Ubicacion { get; set; }

    }
}
