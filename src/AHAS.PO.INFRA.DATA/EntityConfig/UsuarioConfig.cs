using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(256);

            Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(256);

            //FK - 1 : 1
            HasRequired(x => x.Agendamento)
                .WithRequiredPrincipal(x => x.Usuario)
                .Map(m => m.MapKey("Id"));

            //FK - 1 : 1
            HasOptional(x => x.ResponsavelDocumento)
                .WithOptionalPrincipal(x => x.Usuario)
                .Map(m => m.MapKey("Id"));

            ToTable("AspNetUsers");
        }
    }
}