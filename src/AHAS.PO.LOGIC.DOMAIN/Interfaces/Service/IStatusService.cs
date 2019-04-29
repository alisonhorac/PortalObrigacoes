using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IStatusService : IDisposable
    {
        Status Consultar(Guid id);

        IEnumerable<Status> Listar();

        IEnumerable<Status> Consultar(Expression<Func<Status, bool>> query);
    }
}
