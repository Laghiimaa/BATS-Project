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
    public class ConductorRepository : Repository<Conductor>, IConductorRepository
    {
        private readonly ApplicationDbContext _db;

        public ConductorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaConductores()
        {
            return _db.Conductor.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.IdCond.ToString()
            }
            );
        }

        public void Update(Conductor conductor)
        {
            var ObjDesdeDb = _db.Conductor.FirstOrDefault(s => s.IdCond == conductor.IdCond);
            ObjDesdeDb.Nombre = conductor.Nombre;
            ObjDesdeDb.IdLin = conductor.IdLin;
            ObjDesdeDb.Telefono = conductor.Telefono;
            ObjDesdeDb.INE = conductor.INE;
            ObjDesdeDb.Licencia = conductor.Licencia;

            _db.SaveChanges();
        }
    }
}
