using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class AgendamentoConfig : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoConfig()
        {
            ToTable("tbAgendamento");

            HasKey(x => x.IDAgendamento);

            Property(x => x.DataAgendada)
                .IsRequired();

            Property(x => x.DataReferencia)
                .IsRequired();
        }
    }
}