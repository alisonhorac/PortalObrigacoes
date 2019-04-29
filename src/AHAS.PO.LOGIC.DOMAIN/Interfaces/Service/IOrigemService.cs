using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IOrigemService : IDisposable
    {
        Origem Consultar(Guid id);

        IEnumerable<Origem> Listar();

        IEnumerable<Origem> Consultar(Expression<Func<Origem, bool>> query);
    }
}
