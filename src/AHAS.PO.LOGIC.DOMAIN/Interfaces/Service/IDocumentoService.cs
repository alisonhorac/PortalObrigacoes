using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IDocumentoService : IDisposable
    {
        Documento Inserir(Documento obj);

        Documento Alterar(Documento obj);

        bool Desativar(Guid id);

        Documento Consultar(Guid id);

        IEnumerable<Documento> Listar();
    }
}
