using AHAS.PO.INFRA.DATA.EntityConfig;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AHAS.PO.INFRA.DATA.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("name=DataBaseConnection")
        {
        }

        public DbSet<Usuario> TbUsuario { get; set; }
        public DbSet<Unidade> TbUnidade { get; set; }
        public DbSet<Documento> TbDocumento { get; set; }
        public DbSet<Feriado> TbFeriado { get; set; }
        public DbSet<Agendamento> TbAgendamento { get; set; }
        public DbSet<Origem> TbOrigem { get; set; }
        public DbSet<Status> TbStatus { get; set; }
        public DbSet<Abrangencia> TbAbrangencia { get; set; }
        public DbSet<Periodicidade> TbPeriodicidade { get; set; }
        public DbSet<ResponsavelDocumento> TbResponsavelDocumento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //CONFIGURAÇÕES PADRÃO
            modelBuilder.Properties()
                .Where(p => p.Name == "ID" + p.ReflectedType.Name)
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("VARCHAR"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new UnidadeConfig());
            modelBuilder.Configurations.Add(new DocumentoConfig());
            modelBuilder.Configurations.Add(new FeriadoConfig());
            modelBuilder.Configurations.Add(new AgendamentoConfig());
            modelBuilder.Configurations.Add(new StatusConfig());
            modelBuilder.Configurations.Add(new AbrangeciaConfig());
            modelBuilder.Configurations.Add(new PeriodicidadeConfig());
            modelBuilder.Configurations.Add(new OrigemConfig());
            modelBuilder.Configurations.Add(new ResponsavelDocumentoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
