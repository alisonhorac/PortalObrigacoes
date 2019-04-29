using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Origem
    {
        public Origem()
        {
            IDOrigem = Guid.NewGuid();
        }

        public Guid IDOrigem { get; set; }

        public string Descricao { get; set; }

        //RELACIONAMENTO
        public virtual Documento Documento { get; set; }
    }
}
