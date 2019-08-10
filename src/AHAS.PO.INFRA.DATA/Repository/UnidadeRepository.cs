using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using System;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class UnidadeRepository : Repository<Unidade>, IUnidadeRepository
    {
        public UnidadeRepository(DataBaseContext context) : base(context)
        {
        }

        public bool Desativar(long id)
        {
            DataBase.TbUnidade.Find(id).FlagAtivo = false;
            DataBase.SaveChanges();

            return true;
        }
    }
}
