using System;
using System.Collections.Generic;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;

namespace AHAS.PO.SERVICE.APPLICATION.Interfaces
{
    public interface IFeriadoAppService : IDisposable
    {
        FeriadoViewModel Alterar(FeriadoViewModel feriadoViewModel);
        bool Excluir(int id);
        FeriadoViewModel Inserir(FeriadoViewModel feriadoViewModel);
        IEnumerable<FeriadoViewModel> Listar();
    }
}