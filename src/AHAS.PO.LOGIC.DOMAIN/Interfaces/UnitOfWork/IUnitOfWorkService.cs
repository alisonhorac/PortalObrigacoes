using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.UnitOfWork
{
    public interface IUnitOfWorkService
    {
        void Commit();
    }
}
