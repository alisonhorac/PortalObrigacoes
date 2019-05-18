using AHAS.PO.LOGIC.DOMAIN.Interfaces.UnitOfWork;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWorkRepository _unitOfWorkRepository;

        public UnitOfWorkService(IUnitOfWorkRepository unitOfWorkRepository)
        {
            _unitOfWorkRepository = unitOfWorkRepository;
        }

        public void Commit()
        {
            _unitOfWorkRepository.Commit();
        }
    }
}
