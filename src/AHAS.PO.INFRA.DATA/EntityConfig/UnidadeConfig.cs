using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class UnidadeConfig : EntityTypeConfiguration<Unidade>
    {
        public UnidadeConfig()
        {
            ToTable("tbUnidade");

            HasKey(x => x.IDUnidade);

            Property(x => x.CNPJ)
                .IsRequired()
                .HasMaxLength(14);

            Property(x => x.InscricaoEstadual)
                .IsOptional()
                .HasMaxLength(14);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("VARCHAR");

            Property(x => x.DataAtualizacao)
                .IsRequired();

            Property(x => x.DataCadastro)
                .IsRequired();

            Property(x => x.FlagAtivo)
                .IsRequired();

            //FK - 1 : 1
            HasRequired(x => x.Agendamento)
                .WithRequiredPrincipal(x => x.Unidade)
                .Map(m => m.MapKey("IDUnidade"));
        }
    }
}
