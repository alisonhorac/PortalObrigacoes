using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class FeriadoRepository : Repository<Feriado>, IFeriadoRepository
    {
        public FeriadoRepository(DataBaseContext context) : base(context)
        {
        }
    }
}
