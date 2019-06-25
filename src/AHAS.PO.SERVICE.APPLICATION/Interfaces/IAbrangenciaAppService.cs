using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.SERVICE.APPLICATION.Interfaces
{
    public interface IAbrangenciaAppService : IDisposable
    {
        IEnumerable<AbrangenciaViewModel> Listar();
    }
}
