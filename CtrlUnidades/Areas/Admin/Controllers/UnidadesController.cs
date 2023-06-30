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

    public class UnidadesController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        public UnidadesController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _context = context;
        }

        public IActionResult Index()
        {
            var unidades = _context.Unidad.AsQueryable();
            return View(unidades);
        }

        [HttpGet]
        //[Authorize(Roles = "Administrador, Creador/Editor, Creador")]
        public IActionResult Create()
        {
            ViewBag.LineaTransportista = _context.LineaTransportista.ToList();
            //ViewBag.TipoUnidades = _context.TipoUnidades.ToList();

            var unidad = new Unidad();
            return View(unidad);
        }
    }
}
