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
    public class UbicacionRepository : Repository<Ubicacion>, IUbicacionRepository
    {

        private readonly ApplicationDbContext _db;

        public UbicacionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaUbicaciones()
        {
            return _db.Ubicacion.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.Id_Ubicacion.ToString()
            }
            );
        }

        public void Update(Ubicacion ubicacion)
        {
            var ObjDesdeDb = _db.Ubicacion.FirstOrDefault(s => s.Id_Ubicacion == ubicacion.Id_Ubicacion);
            ObjDesdeDb.Nombre = ubicacion.Nombre;
            ObjDesdeDb.Contacto = ubicacion.Contacto;
            ObjDesdeDb.Observaciones = ubicacion.Observaciones;

            _db.SaveChanges();
        }
    }
}
