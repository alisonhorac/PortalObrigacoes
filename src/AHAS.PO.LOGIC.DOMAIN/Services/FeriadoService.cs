using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class FeriadoService : IFeriadoService
    {
        private readonly IFeriadoRepository repository;

        public FeriadoService(IFeriadoRepository feriadoRepository)
        {
            repository = feriadoRepository;
        }

        public Feriado Alterar(Feriado obj)
        {
            return repository.Alterar(obj);
        }

        public Feriado Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public bool Excluir(Guid id)
        {
            return repository.Excluir(id);
        }

        public Feriado Inserir(Feriado obj)
        {
            return repository.Inserir(obj);
        }

        public IEnumerable<Feriado> Listar()
        {
            return repository.ListarFeriado();
        }

        public void Dispose()
        {
            repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
