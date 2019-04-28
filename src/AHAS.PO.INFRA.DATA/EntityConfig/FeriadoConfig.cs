using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class FeriadoConfig : EntityTypeConfiguration<Feriado>
    {
        public FeriadoConfig()
        {
            ToTable("tbFeriado");

            HasKey(x => x.IDFeriado);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("VARCHAR");

            Property(x => x.DataDe)
                .IsRequired();

            Property(x => x.DataAte)
                .IsRequired();

            Property(x => x.FlagFeriadoFixo)
                .IsRequired();
        }
    }
}