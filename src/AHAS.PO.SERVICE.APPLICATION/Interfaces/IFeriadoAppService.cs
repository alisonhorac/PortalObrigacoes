﻿using System;
using System.Collections.Generic;
using AHAS.PO.SERVICE.APPLICATION.ViewModel;

namespace AHAS.PO.SERVICE.APPLICATION.Interfaces
{
    public interface IFeriadoAppService : IDisposable
    {
        FeriadoViewModel Alterar(FeriadoViewModel feriadoViewModel);
        bool Excluir(Guid id);
        FeriadoViewModel Inserir(FeriadoViewModel feriadoViewModel);
        IEnumerable<FeriadoViewModel> Listar();
    }
}