using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using System;
using System.Collections.Generic;

namespace AHAS.PO.SERVICE.APPLICATION.Interfaces
{
    public interface IEstadoAppService : IDisposable
    {
        IEnumerable<EstadoViewModel> Listar();
    }
}
