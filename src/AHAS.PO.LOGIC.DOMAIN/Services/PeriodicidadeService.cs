﻿using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class PeriodicidadeService : IPeriodicidadeService
    {
        private readonly IPeriodicidadeRepository repository;

        public PeriodicidadeService(IPeriodicidadeRepository periodicidadeRepository)
        {
            repository = periodicidadeRepository;
        }

        public Periodicidade Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public IEnumerable<Periodicidade> Consultar(Expression<Func<Periodicidade, bool>> query)
        {
            return repository.Consultar(query);
        }

        public IEnumerable<Periodicidade> Listar()
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
