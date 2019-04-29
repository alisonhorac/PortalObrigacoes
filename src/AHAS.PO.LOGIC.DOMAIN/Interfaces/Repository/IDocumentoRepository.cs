using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IDocumentoRepository : IRepository<Documento>
    {
        bool Desativar(Guid id);
    }
}
