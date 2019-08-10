using System;
using System.Collections.Generic;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;

namespace AHAS.PO.SERVICE.APPLICATION.Interfaces
{
    public interface IFeriadoAppService : IDisposable
    {
        FeriadoViewModel Alterar(FeriadoViewModel obj);
        bool Excluir(long id);
        FeriadoViewModel Inserir(FeriadoViewModel obj);
        FeriadoViewModel Consultar(long id);
        IEnumerable<FeriadoViewModel> Listar();
    }
}