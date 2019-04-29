using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Periodicidade
    {
        public Periodicidade()
        {
            IDPeriodicidade = Guid.NewGuid();
        }

        public Guid IDPeriodicidade { get; set; }

        public string Descricao { get; set; }

        //RELACIONAMENTO
        public virtual Documento Documento { get; set; }
    }
}
