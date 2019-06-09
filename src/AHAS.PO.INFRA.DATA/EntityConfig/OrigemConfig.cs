using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class OrigemConfig : EntityTypeConfiguration<Origem>
    {
        public OrigemConfig()
        {
            ToTable("tbOrigem");

            HasKey(x => x.IDOrigem);

            //AUTOINCREMENTO
            HasKey(x => x.IDOrigem)
                .Property(x => x.IDOrigem)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("VARCHAR");

            //FK - 1 : 1
            HasRequired(x => x.Documento)
                .WithRequiredPrincipal(x => x.Origem)
                .Map(m => m.MapKey("IDOrigem"));
        }
    }
}