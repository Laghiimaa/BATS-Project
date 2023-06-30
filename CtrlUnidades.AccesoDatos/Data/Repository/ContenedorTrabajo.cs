using CtrlUnidades.AccesoDatos.Data.Repository;
using CtrlUnidades.AccesoDatos.Data.Repository.IRepository;
using CtrlUnidades.Data;
using CtrlUnidades.Data.Migrations;
using CtrlUnidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtrlUnidades.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db) 
        {
            _db = db;
            Ubicacion = new UbicacionRepository(_db);
            Herramienta = new HerramientaRepository(_db);
            LineaTransportista = new LineaTransportistaRepository(_db);
            Conductor = new ConductorRepository(_db);

            ModuloGPS = new ModuloGPSRepository(_db);
        }

        public IUbicacionRepository Ubicacion { get; private set; }
        public IHerramientaRepository Herramienta { get; private set; }
        public ILineaTransportistaRepository LineaTransportista { get; private set; }
        public IConductorRepository Conductor { get; private set; }

        public IModuloGPSRepository ModuloGPS { get; private set; }

        public void Dispose()
        {
            _db.Dispose(); 
        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
