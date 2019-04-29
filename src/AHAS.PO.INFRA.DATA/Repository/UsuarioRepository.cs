using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using System;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataBaseContext context) : base(context)
        {
        }

        public bool Desativar(Guid id)
        {
            var obj = base.Consultar(id);
            obj.FlagAtivo = false;
            base.Alterar(obj);

            return !obj.FlagAtivo;
        }
    }
}
