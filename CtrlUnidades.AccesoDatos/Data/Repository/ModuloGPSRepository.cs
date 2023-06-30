using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;
using CtrlUnidades.Data;
using CtrlUnidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CtrlUnidades.AccesoDatos.Data.Repository
{

    public class ModuloGPSRepository : Repository<ModuloGPS>, IModuloGPSRepository
    {

        private readonly ApplicationDbContext _db;

        public ModuloGPSRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaModuloGPS()
        {
            return _db.ModuloGPS.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.IdCond.ToString()
            }
            );
        }

        public void Update(ModuloGPS moduloGPS)
        {
            var ObjDesdeDb = _db.ModuloGPS.FirstOrDefault(s => s.IdCond == moduloGPS.IdCond);
            ObjDesdeDb.Nombre = moduloGPS.Nombre;
            ObjDesdeDb.IdLin = moduloGPS.IdLin;
            ObjDesdeDb.Placas = moduloGPS.Placas;
            ObjDesdeDb.Latitud = moduloGPS.Latitud;
            ObjDesdeDb.Longitud = moduloGPS.Longitud;

            _db.SaveChanges();
        }

    }
}
