using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IFeriadoRepository : IRepository<Feriado>
    {
        IEnumerable<Feriado> ListarFeriado();

        Feriado ValidarFeriadoExiste(DateTime dataDe, DateTime dataAte, bool feriadoFixo, int idAbrangencia, int? idEstado);
    }
}
