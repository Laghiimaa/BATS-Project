﻿using CtrlUnidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CtrlUnidades.AccesoDatos.Data.Repository.IRepository
{
    public interface IModuloGPSRepository : IRepository<ModuloGPS>
    {

        IEnumerable<SelectListItem> GetListaModuloGPS();

        void Update(ModuloGPS moduloGPS);

    }
}
