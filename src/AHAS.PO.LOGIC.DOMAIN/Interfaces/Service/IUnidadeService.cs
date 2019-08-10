using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IUnidadeService : IDisposable
    {
        Unidade Inserir(Unidade obj);

        Unidade Alterar(Unidade obj);

        bool Desativar(long id);

        Unidade Consultar(long id);

        IEnumerable<Unidade> Listar();
    }
}
