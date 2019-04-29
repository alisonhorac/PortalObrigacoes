using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class UnidadeService : IUnidadeService
    {
        private readonly IUnidadeRepository repository;

        public UnidadeService(IUnidadeRepository unidadeRepository)
        {
            repository = unidadeRepository;
        }

        public Unidade Inserir(Unidade obj)
        {
            return repository.Inserir(obj);
        }

        public Unidade Alterar(Unidade obj)
        {
            return repository.Alterar(obj);
        }

        public Unidade Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public bool Desativar(Guid id)
        {
            return repository.Desativar(id);
        }

        public IEnumerable<Unidade> Listar()
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
