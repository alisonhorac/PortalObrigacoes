using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class AbrangeciaConfig : EntityTypeConfiguration<Abrangencia>
    {
        public AbrangeciaConfig()
        {
            ToTable("tbAbrangencia");

            //AUTOINCREMENTO
            HasKey(x => x.IDAbrangencia)
                .Property(x => x.IDAbrangencia)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("VARCHAR");

            //FK - 1 : 1
            HasRequired(x => x.Feriado)
                .WithRequiredPrincipal(x => x.Abrangencia)
                .Map(m => m.MapKey("IDAbrangencia"));
        }
    }
}