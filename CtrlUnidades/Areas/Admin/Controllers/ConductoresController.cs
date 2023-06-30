using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;
using CtrlUnidades.Data;
using CtrlUnidades.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CtrlUnidades.Areas.Admin.Controllers
{

    [Authorize]
    [Area("Admin")]

    public class ConductoresController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        public ConductoresController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _context = context;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var conductor = _context.Conductor.AsQueryable();
            return View(conductor);
        }

        //Agregar nueva tarjeta Catalogo
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Conductor conductor)
        {
            var Exist = _contenedorTrabajo.Conductor.Get(conductor.IdCond);
            if (Exist == null)
            {

                if (ModelState.IsValid)
                {
                    _contenedorTrabajo.Conductor.add(conductor);
                    _contenedorTrabajo.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(conductor);
            }
            //Mensaje de que ya existe el id
            return View();
        }


        #region Llamadas a la API
        [HttpGet]

        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Conductor.GetAll() });
        }
        #endregion
    }
}
