using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IAgendamentoService : IDisposable
    {
        Agendamento Inserir(Agendamento obj);

        Agendamento Alterar(Agendamento obj);

        bool Excluir(Guid id);

        Agendamento Consultar(Guid id);

        IEnumerable<Agendamento> Listar();
    }
}
