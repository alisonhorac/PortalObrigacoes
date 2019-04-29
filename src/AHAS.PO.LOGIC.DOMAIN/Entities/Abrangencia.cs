using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Abrangencia
    {
        public Abrangencia()
        {
            IDAbrangencia = Guid.NewGuid();
        }

        public Guid IDAbrangencia { get; set; }

        public string Descricao { get; set; }

        //RELACIONAMENTO
        public virtual Feriado Feriado { get; set; }
    }
}
