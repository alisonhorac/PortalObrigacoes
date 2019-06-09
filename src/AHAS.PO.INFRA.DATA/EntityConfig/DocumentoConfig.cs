using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class DocumentoConfig : EntityTypeConfiguration<Documento>
    {
        public DocumentoConfig()
        {
            ToTable("tbDocumento");

            HasKey(x => x.IDDocumento);

            //AUTOINCREMENTO
            HasKey(x => x.IDDocumento)
                .Property(x => x.IDDocumento)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("VARCHAR");

            Property(x => x.FlagDiasUteisVencimento)
                .IsRequired();

            Property(x => x.PrazoDiasVencimento)
                .IsRequired();

            Property(x => x.PrazoMesVencimento)
                .IsOptional();

            Property(x => x.DataReferencia)
                .IsRequired();

            Property(x => x.DataAtualizacao)
                .IsRequired();

            Property(x => x.DataCadastro)
                .IsRequired();

            Property(x => x.FlagAtivo)
                .IsRequired();

            //FK - 1 : 1
            HasRequired(x => x.Agendamento)
                .WithRequiredPrincipal(x => x.Documento)
                .Map(m => m.MapKey("IDDocumento"));

            //FK - GERAÇÃO DE UMA TABELA N:M QUANDO A TABELA GERADA NÃO POSSUI OUTROS CAMPOS
            //HasMany(x => x.Unidades)
            //.WithMany(x => x.Documentos)
            //.Map(x =>
            //{
            //    x.ToTable("ResponsavelDocumento");
            //    x.MapLeftKey("IDDocumento");
            //    x.MapRightKey("IDUnidade");
            //});
        }
    }
}
