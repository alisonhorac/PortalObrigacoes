using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class PeriodicidadeConfig : EntityTypeConfiguration<Periodicidade>
    {
        public PeriodicidadeConfig()
        {
            ToTable("tbPeriodicidade");

            HasKey(x => x.IDPeriodicidade);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("VARCHAR");

            //FK - 1 : 1
            HasRequired(x => x.Documento)
                .WithRequiredPrincipal(x => x.Periodicidade)
                .Map(m => m.MapKey("IDPeriodicidade"));
        }
    }
}
