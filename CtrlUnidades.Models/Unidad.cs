using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models
{
    public class Unidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IdLin {get; set;}
        public string Placas { get; set;}
        public string Tipo { get; set;}
        public string Capacidad { get; set;}
        public string Nombre { get; set;}
        public string Observaciones { get; set;}
    }
}
