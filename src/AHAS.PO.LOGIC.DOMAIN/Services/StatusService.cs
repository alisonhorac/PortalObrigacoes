using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository repository;

        public StatusService(IStatusRepository statusRepository)
        {
            repository = statusRepository;
        }

        public Status Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public IEnumerable<Status> Consultar(Expression<Func<Status, bool>> query)
        {
            return repository.Consultar(query);
        }

        public IEnumerable<Status> Listar()
        {
            return repository.Listar();
        }

        public void Dispose()
        {
            repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
