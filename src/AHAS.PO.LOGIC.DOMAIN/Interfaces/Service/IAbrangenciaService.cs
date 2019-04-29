using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IAbrangenciaService : IDisposable
    {
        Abrangencia Consultar(Guid id);

        IEnumerable<Abrangencia> Listar();

        IEnumerable<Abrangencia> Consultar(Expression<Func<Abrangencia, bool>> query);
    }
}
