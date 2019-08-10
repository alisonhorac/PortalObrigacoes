using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IFeriadoService : IDisposable
    {
        Feriado Inserir(Feriado obj);

        Feriado Alterar(Feriado obj);

        bool Excluir(long id);

        Feriado Consultar(long id);

        IEnumerable<Feriado> Listar();
    }
}
