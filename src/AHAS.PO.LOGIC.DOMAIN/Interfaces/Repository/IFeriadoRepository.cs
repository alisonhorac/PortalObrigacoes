using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IFeriadoRepository : IRepository<Feriado>
    {
        IEnumerable<Feriado> ListarFeriado();
    }
}
