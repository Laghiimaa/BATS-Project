using CtrlUnidades.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace CtrlUnidades.AccesoDatos.Data.Repository
{
    public interface IHerramientaRepository : IRepository<Herramienta>
    {
        IEnumerable<SelectListItem> GetLogo();

        void Update(Herramienta herramienta);
    }
}
