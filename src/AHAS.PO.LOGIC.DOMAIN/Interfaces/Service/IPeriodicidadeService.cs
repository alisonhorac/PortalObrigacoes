using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IPeriodicidadeService : IDisposable
    {
        Periodicidade Consultar(Guid id);

        IEnumerable<Periodicidade> Listar();

        IEnumerable<Periodicidade> Consultar(Expression<Func<Periodicidade, bool>> query);
    }
}
