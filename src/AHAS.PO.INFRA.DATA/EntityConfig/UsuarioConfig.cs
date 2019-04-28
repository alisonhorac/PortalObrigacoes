using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            //FK - 1 : 1
            HasRequired(x => x.Agendamento)
                .WithRequiredPrincipal(x => x.Usuario)
                .Map(m => m.MapKey("Id"));

            ToTable("AspNetUsers");
        }
    }
}