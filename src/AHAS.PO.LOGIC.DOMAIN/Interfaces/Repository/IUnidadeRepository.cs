using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IUnidadeRepository : IRepository<Unidade>
    {
        bool Desativar(Guid id);
    }
}
