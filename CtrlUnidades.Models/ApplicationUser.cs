using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

            Conductor_Id = null;
        }

        public string? Nombre { get; set; }
        public string? Contrasena { get; set; }
        public string? UsuarioTipo { get; set; }
        public string? Conductor_Id { get; set; }
        public string? Estado { get; set; } //Activo / Inactivo
        public string? PushToken { get; set; }
    }
}
