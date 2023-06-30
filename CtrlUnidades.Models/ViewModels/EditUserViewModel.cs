using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.Models.ViewModels
{
    public class EditUserViewModel
    {
        public ApplicationUser User { get; set; }
        public IList<string> Roles { get; set; }
        public IList<string> AvailableRoles { get; set; }
    }
}
