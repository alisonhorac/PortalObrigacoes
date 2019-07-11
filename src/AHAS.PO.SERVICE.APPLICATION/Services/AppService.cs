using AHAS.PO.LOGIC.DOMAIN.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.SERVICE.APPLICATION.Services
{
    public class AppService
    {
        private readonly IUnitOfWorkService _unitOfWork;

        public AppService(IUnitOfWorkService uow)
        {
            _unitOfWork = uow;
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }
    }
}
