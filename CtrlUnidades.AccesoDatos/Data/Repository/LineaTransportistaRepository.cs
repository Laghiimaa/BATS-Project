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
    public class LineaTransportistaRepository : Repository<LineaTransportista>, ILineaTransportistaRepository
    {
        private readonly ApplicationDbContext _db;

        public LineaTransportistaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public IEnumerable<SelectListItem> GetListaLineaTransportista()
        {
            return _db.LineaTransportista.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.IdLin.ToString()
            }
            );
        }

        public void Update(LineaTransportista lineatransportista)
        {
            var ObjDesdeDb = _db.LineaTransportista.FirstOrDefault(s => s.IdLin == lineatransportista.IdLin);
            ObjDesdeDb.Nombre = lineatransportista.Nombre;
            ObjDesdeDb.Contacto = lineatransportista.Contacto;
            ObjDesdeDb.Telefono = lineatransportista.Telefono;
            ObjDesdeDb.Correo = lineatransportista.Correo;
            ObjDesdeDb.Ubicacion = lineatransportista.Ubicacion;

            _db.SaveChanges();
        }


    }
}
