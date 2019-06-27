using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class EstadoConfig : EntityTypeConfiguration<Estado>
    {
        public EstadoConfig()
        {
            ToTable("tbEstado");

            HasKey(x => x.IDEstado);

            //AUTOINCREMENTO
            HasKey(x => x.IDEstado)
                .Property(x => x.IDEstado)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("VARCHAR");

            Property(x => x.Sigla)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnType("VARCHAR");

            //FK - 1 : N
            HasMany(c => c.Feriados)
                .WithOptional(c => c.Estado)
                .HasForeignKey(c => c.IDEstado);
        }
    }
}
