using CtrlUnidades.AccesoDatos.Data.Repository;
using CtrlUnidades.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CtrlUnidades.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class HerramientasController : Controller
    {
       
    }
}
