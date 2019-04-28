using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Periodicidade
    {
        public int IDPeriodicidade { get; set; }

        public string Descricao { get; set; }

        //RELACIONAMENTO
        public virtual Documento Documento { get; set; }
    }
}
