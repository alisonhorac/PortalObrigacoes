using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IFeriadoService : IDisposable
    {
        Feriado Inserir(Feriado obj);

        Feriado Alterar(Feriado obj);

        bool Excluir(Guid id);

        Feriado Consultar(Guid id);

        IEnumerable<Feriado> Listar();
    }
}
