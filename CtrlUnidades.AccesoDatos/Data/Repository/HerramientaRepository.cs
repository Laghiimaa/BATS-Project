using CtrlUnidades.AccesoDatos.Data;
using CtrlUnidades.AccesoDatos.Data.Repository;
using CtrlUnidades.Data;
using CtrlUnidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace CtrlUnidades.AccesoDatos.Data
{
   public  class HerramientaRepository : Repository<Herramienta>, IHerramientaRepository
    {
        private readonly ApplicationDbContext _db;

        public HerramientaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetLogo()
        {
            return _db.Herramienta.Select(i => new SelectListItem()
            {
                Text = i.Id_Herr,
                Value = i.Id_Herr.ToString()
            });
        }

        public void Update(Herramienta herramientas)
        {
            var ObjDesdeDb = _db.Herramienta.FirstOrDefault(s => s.Id_Herr == herramientas.Id_Herr);
            ObjDesdeDb.Nombre = herramientas.Nombre;

            _db.SaveChanges();
        }
        //Listado de herramientas
        public IEnumerable<SelectListItem> GetLogoUrl()
        {
            return _db.Herramienta.Select(i => new SelectListItem() 
            {
                Text=i.Id_Herr,
                Value =i.Nombre.ToString()
            }
            );
        }
    }
}
