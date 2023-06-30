using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models
{
    public class TipoUnidad
    {

        [Key]
        public string IdTUni { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }

    }
}
