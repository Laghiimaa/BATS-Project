using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CtrlUnidades.Models
{
    public class Herramienta
    {
        [Key]
        public string Id_Herr { get; set; }
        public string Nombre { get; set; }
    }
}
