using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class FeriadoRepository : Repository<Feriado>, IFeriadoRepository
    {
        public FeriadoRepository(DataBaseContext context) : base(context)
        {
        }

        public IEnumerable<Feriado> ListarFeriado()
        {
            return DataBase.TbFeriado.Include("Abrangencia").ToList();
        }
    }
}
