using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;
using CtrlUnidades.Data;
using CtrlUnidades.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CtrlUnidades.Areas.Modulos.Controllers
{

    [Authorize]
    [Area("Modulos")]

    public class ModuloGPSController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        private List<ModuloGPS> datos;

        public ModuloGPSController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _context = context;

            this.datos = new List<ModuloGPS>
            {
                new ModuloGPS{IdCond="1234", IdLin="4231", Placas="AB23HBMEX", Temperatura="30", Fecha="24/04/2023", Hora="10:42:56 PM", Direccion="Querétaro 76803"},
                new ModuloGPS{IdCond="4321", IdLin="4534", Placas="SDAS41NEX", Temperatura="47", Fecha="24/04/2023", Hora="11:25:26 PM", Direccion="Querétaro 76854"},
                new ModuloGPS{IdCond="9876", IdLin="6787", Placas="213SA2QRO", Temperatura="39", Fecha="24/04/2023", Hora="11:22:18 PM", Direccion="Querétaro 76900"},
                new ModuloGPS{IdCond="1234", IdLin="4231", Placas="AB23HBMEX", Temperatura="30", Fecha="24/04/2023", Hora="10:42:56 PM", Direccion="Querétaro 76803"},
                new ModuloGPS{IdCond="4321", IdLin="4534", Placas="SDAS41NEX", Temperatura="47", Fecha="24/04/2023", Hora="11:25:26 PM", Direccion="Querétaro 76854"},
                new ModuloGPS{IdCond="9876", IdLin="6787", Placas="213SA2QRO", Temperatura="39", Fecha="24/04/2023", Hora="11:22:18 PM", Direccion="Querétaro 76900"},
                new ModuloGPS{IdCond="1234", IdLin="4231", Placas="AB23HBMEX", Temperatura="30", Fecha="24/04/2023", Hora="10:42:56 PM", Direccion="Querétaro 76803"},
                new ModuloGPS{IdCond="4321", IdLin="4534", Placas="SDAS41NEX", Temperatura="47", Fecha="24/04/2023", Hora="11:25:26 PM", Direccion="Querétaro 76854"},
                new ModuloGPS{IdCond="9876", IdLin="6787", Placas="213SA2QRO", Temperatura="39", Fecha="24/04/2023", Hora="11:22:18 PM", Direccion="Querétaro 76900"},
                new ModuloGPS{IdCond="1234", IdLin="4231", Placas="AB23HBMEX", Temperatura="30", Fecha="24/04/2023", Hora="10:42:56 PM", Direccion="Querétaro 76803"},
                new ModuloGPS{IdCond="4321", IdLin="4534", Placas="SDAS41NEX", Temperatura="47", Fecha="24/04/2023", Hora="11:25:26 PM", Direccion="Querétaro 76854"},
                new ModuloGPS{IdCond="9876", IdLin="6787", Placas="213SA2QRO", Temperatura="39", Fecha="24/04/2023", Hora="11:22:18 PM", Direccion="Querétaro 76900"},
                new ModuloGPS{IdCond="1234", IdLin="4231", Placas="AB23HBMEX", Temperatura="30", Fecha="24/04/2023", Hora="10:42:56 PM", Direccion="Querétaro 76803"},
                new ModuloGPS{IdCond="4321", IdLin="4534", Placas="SDAS41NEX", Temperatura="47", Fecha="24/04/2023", Hora="11:25:26 PM", Direccion="Querétaro 76854"},
                new ModuloGPS{IdCond="9876", IdLin="6787", Placas="213SA2QRO", Temperatura="39", Fecha="24/04/2023", Hora="11:22:18 PM", Direccion="Querétaro 76900"},
                new ModuloGPS{IdCond="1234", IdLin="4231", Placas="AB23HBMEX", Temperatura="30", Fecha="24/04/2023", Hora="10:42:56 PM", Direccion="Querétaro 76803"},
                new ModuloGPS{IdCond="4321", IdLin="4534", Placas="SDAS41NEX", Temperatura="47", Fecha="24/04/2023", Hora="11:25:26 PM", Direccion="Querétaro 76854"},
                new ModuloGPS{IdCond="9876", IdLin="6787", Placas="213SA2QRO", Temperatura="39", Fecha="24/04/2023", Hora="11:22:18 PM", Direccion="Querétaro 76900"},
            };
        }



        //public ModuloGPSController()
        //{

        //}


        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        #region Llamadas a la API
        [HttpGet]

        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.ModuloGPS.GetAll() });
        }
        #endregion

        public IActionResult _TablaPartial()
        {
            return PartialView("_TablaPartial", this.datos);
        }

        [HttpGet]
        public IActionResult _ChartPartial()
        {
            return PartialView("_ChartPartial", this.datos);
        }

        public IActionResult _MapPartial()
        {
            return PartialView("_MapPartial", this.datos);
        }

    }
}
