using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        bool Desativar(Guid id);
    }
}
