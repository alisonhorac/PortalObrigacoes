using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Feriado
    {
        public long IDFeriado { get; set; }

        public string Descricao { get; set; }

        public bool FlagFeriadoFixo { get; set; }

        public DateTime DataDe { get; set; }

        public DateTime DataAte { get; set; }

        public virtual Abrangencia Abrangencia { get; set; }
    }
}
