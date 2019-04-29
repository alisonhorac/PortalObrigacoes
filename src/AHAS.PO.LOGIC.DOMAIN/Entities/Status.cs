using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Status
    {
        public Status()
        {
            IDStatus = Guid.NewGuid();
        }

        public Guid IDStatus { get; set; }

        public string Descricao { get; set; }

        //RELACIONAMENTO
        public virtual Agendamento Agendamento { get; set; }
    }
}
