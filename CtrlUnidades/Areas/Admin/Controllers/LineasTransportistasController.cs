using Microsoft.AspNetCore.Mvc;

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using CtrlUnidades.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;
using CtrlUnidades.AccesoDatos.Data.Repository;
using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Authorization;
using CtrlUnidades.Data;
using CtrlUnidades.Models.ViewModels;
using Org.BouncyCastle.Asn1.X509;
using Microsoft.CodeAnalysis.Differencing;

namespace CtrlUnidades.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]

    public class LineasTransportistasController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly ApplicationDbContext _context;

        public LineasTransportistasController(IContenedorTrabajo contenedorTrabajo, ApplicationDbContext context)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _context = context;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var lineas = _context.LineaTransportista.AsQueryable();
            return View(lineas);
        }

        //Agregar nueva tarjeta Catalogo
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(LineaTransportista lineatransportista)
        {
            var Exist = _contenedorTrabajo.LineaTransportista.Get(lineatransportista.IdLin);
            if (Exist == null)
            {

                if (ModelState.IsValid)
                {
                    _contenedorTrabajo.LineaTransportista.add(lineatransportista);
                    _contenedorTrabajo.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(lineatransportista);
            }
            //Mensaje de que ya existe el id
            return View();
        }


        //Borrar
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var objFromDb = _contenedorTrabajo.LineaTransportista.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error al borrar" });
            }

            _contenedorTrabajo.LineaTransportista.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Registro eliminado correctamente" });

        }


        //Editar
        [HttpGet]
        public IActionResult Edit(string id) //Cambie Int por String
        {
            Models.LineaTransportista lineatransportista = new Models.LineaTransportista();
            lineatransportista = _contenedorTrabajo.LineaTransportista.Get(id);
            if (lineatransportista == null)
            {
                return NotFound();
            }
            return View(lineatransportista);
        }


        //Editar información
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task <IActionResult> Edit(Models.LineaTransportista lineatransportista)
        {
            if (ModelState.IsValid)
            {
                _contenedorTrabajo.LineaTransportista.Update(lineatransportista);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(lineatransportista);
        }

        //Agregar al catálogo
        [HttpGet]
        public IActionResult AddWithExcel()
        {
            return View();
        }

        #region Llamadas a la API
        [HttpGet]

        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.LineaTransportista.GetAll() });
        }


        #endregion


        [HttpPost]
        public IActionResult MostrarDatos([FromForm] IFormFile ArchivoExcel)
        {
            Stream stream = ArchivoExcel.OpenReadStream();

            IWorkbook MiExcel = null;

            if (Path.GetExtension(ArchivoExcel.FileName) == ".xlsx")
            {
                MiExcel = new XSSFWorkbook(stream);
            }
            else
            {
                MiExcel = new HSSFWorkbook(stream);
            }

            ISheet HojaExcel = MiExcel.GetSheetAt(0);

            int cantidadFilas = HojaExcel.LastRowNum;

            List<VMLineaTransportista> lista = new List<VMLineaTransportista>();

            for (int i = 1; i <= cantidadFilas; i++)
            {

                IRow fila = HojaExcel.GetRow(i);

                lista.Add(new VMLineaTransportista
                {
                    IdLin = fila.GetCell(0).ToString(),
                    Nombre = fila.GetCell(1).ToString(),
                    Contacto = fila.GetCell(2).ToString(),
                    Telefono = fila.GetCell(3).ToString(),
                    Correo = fila.GetCell(4).ToString(),
                    Ubicacion = fila.GetCell(5).ToString(),

                });
            }

            return StatusCode(StatusCodes.Status200OK, lista);
        }


        [HttpPost]
        public IActionResult EnviarDatos([FromForm] IFormFile ArchivoExcel)
        {
            Stream stream = ArchivoExcel.OpenReadStream();

            IWorkbook MiExcel = null;

            if (Path.GetExtension(ArchivoExcel.FileName) == ".xlsx")
            {
                MiExcel = new XSSFWorkbook(stream);
            }
            else
            {
                MiExcel = new HSSFWorkbook(stream);
            }

            ISheet HojaExcel = MiExcel.GetSheetAt(0);
            int cantidadFilas = HojaExcel.LastRowNum;

            List<LineaTransportista> lista = new List<LineaTransportista>();

            for (int i = 1; i <= cantidadFilas; i++)
            {

                IRow fila = HojaExcel.GetRow(i);

                lista.Add(new LineaTransportista
                {
                    IdLin = fila.GetCell(0).ToString(),
                    Nombre = fila.GetCell(1).ToString(),
                    Contacto = fila.GetCell(2).ToString(),
                    Telefono = fila.GetCell(3).ToString(),
                    Correo = fila.GetCell(4).ToString(),
                    Ubicacion = fila.GetCell(5).ToString(),
                });
            }

            _context.BulkInsert(lista);

            return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
        }
    }
}
