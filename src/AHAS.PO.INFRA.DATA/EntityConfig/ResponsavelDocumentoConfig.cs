using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class ResponsavelDocumentoConfig : EntityTypeConfiguration<ResponsavelDocumento>
    {
        public ResponsavelDocumentoConfig()
        {
            ToTable("tbResponsavelDocumento");

            //PK CHAVE COMPOSTA
            HasKey(x => new { x.IDUnidade, x.IDDocumento });

            Property(x => x.FlagDiasUteisVencimento)
                .IsRequired();

            Property(x => x.PrazoDiasVencimento)
                .IsRequired();

            Property(x => x.PrazoMesVencimento);

            Property(x => x.DataReferencia)
                .IsRequired();

            Property(x => x.DataAtualizacao)
                .IsRequired();

            Property(x => x.DataCadastro)
                .IsRequired();

            //FK - GERADA DEVIDO UM RELACIONAMENTO N : M E A TABELA POSSUIR OUTROS CAMPOS
            HasRequired(x => x.Documento)
                .WithMany(x => x.ResponsaveisDocumentos)
                .HasForeignKey(x => x.IDDocumento)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Unidade)
                .WithMany(x => x.ResponsaveisDocumentos)
                .HasForeignKey(x => x.IDUnidade)
                .WillCascadeOnDelete(false);
        }
    }
}
