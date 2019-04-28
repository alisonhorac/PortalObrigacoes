using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Agendamento
    {
        public Agendamento()
        {
            IDAgendamento = Guid.NewGuid();
        }

        public Guid IDAgendamento { get; set; }

        public virtual Unidade Unidade { get; set; }

        public virtual Documento Documento { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Status Status { get; set; }

        public DateTime DataAgendada { get; set; }

        public DateTime DataReferencia { get; set; }
    }
}
