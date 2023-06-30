using CtrlUnidades.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CtrlUnidades.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]

    public class ProveedoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProveedoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var proveedores = _context.Proveedor.AsQueryable();
            return View(proveedores);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrador, Creador/Editor, Creador")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
