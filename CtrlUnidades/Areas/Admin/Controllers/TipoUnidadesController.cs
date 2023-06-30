using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;
using CtrlUnidades.Data;
using CtrlUnidades.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixLabors.Fonts.Tables.AdvancedTypographic;

namespace CtrlUnidades.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]

    public class TipoUnidadesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public TipoUnidadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tipoUnidades = _context.TipoUnidad.AsQueryable();
            return View(tipoUnidades);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrador, Creador/Editor, Creador")]
        public IActionResult Create()
        {
             return View();
        }
    }
}
