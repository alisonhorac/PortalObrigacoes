using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class StatusConfig : EntityTypeConfiguration<Status>
    {
        public StatusConfig()
        {
            ToTable("tbStatus");

            HasKey(x => x.IDStatus);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("VARCHAR");

            //FK - 1 : 1
            HasRequired(x => x.Agendamento)
                .WithRequiredPrincipal(x => x.Status)
                .Map(m => m.MapKey("IDStatus"));
        }
    }
}