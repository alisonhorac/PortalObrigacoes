using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IUnidadeService : IDisposable
    {
        Unidade Inserir(Unidade obj);

        Unidade Alterar(Unidade obj);

        bool Desativar(Guid id);

        Unidade Consultar(Guid id);

        IEnumerable<Unidade> Listar();
    }
}
