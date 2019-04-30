using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using System;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class DocumentoRepository : Repository<Documento>, IDocumentoRepository
    {
        public DocumentoRepository(DataBaseContext context) : base(context)
        {
        }

        public bool Desativar(Guid id)
        {
            DataBase.TbDocumento.Find(id).FlagAtivo = false;
            DataBase.SaveChanges();

            return true;
        }
    }
}
