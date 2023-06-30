using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CtrlUnidades.AccesoDatos.Data;

namespace CtrlUnidades.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        IUbicacionRepository Ubicacion { get; }
        IHerramientaRepository Herramienta { get; }

        ILineaTransportistaRepository LineaTransportista { get; }
        IConductorRepository Conductor { get; }

        IModuloGPSRepository ModuloGPS { get; }

        void Save();
    }
}
