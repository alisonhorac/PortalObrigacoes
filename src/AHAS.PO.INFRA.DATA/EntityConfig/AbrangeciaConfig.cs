﻿using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AHAS.PO.INFRA.DATA.EntityConfig
{
    internal sealed class AbrangeciaConfig : EntityTypeConfiguration<Abrangencia>
    {
        public AbrangeciaConfig()
        {
            ToTable("tbAbrangencia");

            HasKey(x => x.IDAbrangencia);

            //AUTOINCREMENTO
            HasKey(x => x.IDAbrangencia)
                .Property(x => x.IDAbrangencia)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("VARCHAR");

            Property(x => x.HabilitaEstado)
                .IsRequired();

            //FK - 1 : N
            HasMany(c => c.Feriados)
                .WithRequired(c => c.Abrangencia)
                .HasForeignKey(c => c.IDAbrangencia);
        }
    }
}