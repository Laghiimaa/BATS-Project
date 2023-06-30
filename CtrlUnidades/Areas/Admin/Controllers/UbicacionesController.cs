using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;
using CtrlUnidades.Data;
using CtrlUnidades.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CtrlUnidades.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]

    public class UbicacionesController : Controller
    {
            private readonly IContenedorTrabajo _contenedorTrabajo;
            private readonly ApplicationDbContext _context;

            public UbicacionesController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
            {
                _contenedorTrabajo = contenedorTrabajo;    
                _context = context; 
            }

            [HttpGet]

            public IActionResult Index()
            {
            var ubicaciones = _context.Ubicacion.AsQueryable();
            return View(ubicaciones);
            }

            //Agregar nueva tarjeta Catalogo
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [AutoValidateAntiforgeryToken]
            public IActionResult Create(Ubicacion ubicacion)
            {
                var Exist = _contenedorTrabajo.Ubicacion.Get(ubicacion.Id_Ubicacion);
                if (Exist == null)
                {

                    if (ModelState.IsValid)
                    {
                        _contenedorTrabajo.Ubicacion.add(ubicacion);
                        _contenedorTrabajo.Save();
                        return RedirectToAction(nameof(Index));
                    }
                    return View(ubicacion);
                }
                //Mensaje de que ya existe el id
                return View();
            }


            #region Llamadas a la API
            [HttpGet]

            public IActionResult GetAll()
            {
                return Json(new { data = _contenedorTrabajo.Ubicacion.GetAll() });
            }


            #endregion
    }
}
