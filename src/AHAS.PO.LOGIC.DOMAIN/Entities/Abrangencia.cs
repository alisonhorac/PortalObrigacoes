using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Abrangencia
    {
        public int IDAbrangencia { get; set; }

        public string Descricao { get; set; }

        //RELACIONAMENTO
        public virtual Feriado Feriado { get; set; }
    }
}
