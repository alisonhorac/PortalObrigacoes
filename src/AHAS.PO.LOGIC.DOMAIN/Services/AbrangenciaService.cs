using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class AbrangenciaService : IAbrangenciaService
    {
        private readonly IAbrangenciaRepository repository;

        public AbrangenciaService(IAbrangenciaRepository abrangenciaRepository)
        {
            repository = abrangenciaRepository;
        }

        public Abrangencia Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public IEnumerable<Abrangencia> Consultar(Expression<Func<Abrangencia, bool>> query)
        {
            return repository.Consultar(query);
        }

        public IEnumerable<Abrangencia> Listar()
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
