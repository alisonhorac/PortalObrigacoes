using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository repository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            repository = agendamentoRepository;
        }

        public Agendamento Inserir(Agendamento obj)
        {
            return repository.Inserir(obj);
        }

        public Agendamento Alterar(Agendamento obj)
        {
            return repository.Alterar(obj);
        }

        public Agendamento Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public bool Excluir(Guid id)
        {
            return repository.Excluir(id);
        }

        public IEnumerable<Agendamento> Listar()
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
