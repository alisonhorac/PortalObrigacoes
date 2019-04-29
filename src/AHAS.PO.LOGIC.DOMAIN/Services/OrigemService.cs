using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class OrigemService : IOrigemService
    {
        private readonly IOrigemRepository repository;

        public OrigemService(IOrigemRepository origemRepository)
        {
            repository = origemRepository;
        }

        public Origem Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public IEnumerable<Origem> Consultar(Expression<Func<Origem, bool>> query)
        {
            return repository.Consultar(query);
        }

        public IEnumerable<Origem> Listar()
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
