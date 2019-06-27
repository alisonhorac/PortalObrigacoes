using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository repository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            repository = estadoRepository;
        }

        public Estado Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public IEnumerable<Estado> Consultar(Expression<Func<Estado, bool>> query)
        {
            return repository.Consultar(query);
        }

        public IEnumerable<Estado> Listar()
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
