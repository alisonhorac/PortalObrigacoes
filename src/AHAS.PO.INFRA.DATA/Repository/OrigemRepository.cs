using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class OrigemRepository : Repository<Origem>, IOrigemRepository
    {
        public OrigemRepository(DataBaseContext context) : base (context)
        {

        }
    }
}
