using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IResponsavelDocumentoService : IDisposable
    {
        ResponsavelDocumento Inserir(ResponsavelDocumento obj);

        ResponsavelDocumento Alterar(ResponsavelDocumento obj);

        bool Excluir(Guid id);

        ResponsavelDocumento Consultar(Guid id);

        IEnumerable<ResponsavelDocumento> Listar();
    }
}
