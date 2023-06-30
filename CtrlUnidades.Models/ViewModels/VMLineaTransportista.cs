using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models.ViewModels
{
    public class VMLineaTransportista
    {

        public string IdLin { get; set; }
        public string Nombre { get; set; }      
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Ubicacion { get; set; }

    }
}
