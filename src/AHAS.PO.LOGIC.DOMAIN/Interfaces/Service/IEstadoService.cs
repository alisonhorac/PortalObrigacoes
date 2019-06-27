using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IEstadoService : IDisposable
    {
        Estado Consultar(Guid id);

        IEnumerable<Estado> Listar();

        IEnumerable<Estado> Consultar(Expression<Func<Estado, bool>> query);
    }
}
