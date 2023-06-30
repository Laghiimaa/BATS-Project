using CtrlUnidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CtrlUnidades.AccesoDatos.Data.Repository.IRepository
{
    public interface ILineaTransportistaRepository : IRepository<LineaTransportista>
    {

        IEnumerable<SelectListItem> GetListaLineaTransportista();

        void Update(LineaTransportista lineatransportista);


    }
}
