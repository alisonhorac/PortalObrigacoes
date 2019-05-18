using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataBaseContext context) : base(context)
        {
        }

        public Usuario ObterPorId(string id)
        {
            return DataBase.TbUsuario.Find(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return DataBase.TbUsuario.ToList();
        }

        public void DesativarLock(string id)
        {
            DataBase.TbUsuario.Find(id).LockoutEnabled = false;
            DataBase.SaveChanges();
        }

        public bool Desativar(Guid id)
        {
            DataBase.TbUsuario.Find(id).FlagAtivo = false;
            DataBase.SaveChanges();

            return true;
        }
    }
}
