using CtrlUnidades.AccesoDatos.Data.Repository;
using CtrlUnidades.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;

namespace CtrlUnidades.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class EmpresaController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        public EmpresaController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }
        //Editar
        [HttpGet]
        public IActionResult Edit(string id) //Cambie Int por String
        {
            id = "8";
            Herramienta empresa = new Herramienta();
            empresa = _contenedorTrabajo.Herramienta.Get(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return View(empresa);
        }
        //Editar información
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Herramienta empresa)
        {
            if (ModelState.IsValid)
            {
                _contenedorTrabajo.Herramienta.Update(empresa);
                _contenedorTrabajo.Save();
                return RedirectToAction(nameof(Edit));
            }

            return View(empresa);
        }

    }
}
