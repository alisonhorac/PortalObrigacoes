namespace AHAS.PO.INFRA.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Catalog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    FlagAtivo = c.Boolean(nullable: false),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.tbAbrangencia",
                c => new
                    {
                        IDAbrangencia = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.IDAbrangencia);
            
            CreateTable(
                "dbo.tbFeriado",
                c => new
                    {
                        IDFeriado = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 200, unicode: false),
                        FlagFeriadoFixo = c.Boolean(nullable: false),
                        DataDe = c.DateTime(nullable: false),
                        DataAte = c.DateTime(nullable: false),
                        IDAbrangencia = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IDFeriado)
                .ForeignKey("dbo.tbAbrangencia", t => t.IDAbrangencia)
                .Index(t => t.IDAbrangencia);
            
            CreateTable(
                "dbo.tbAgendamento",
                c => new
                    {
                        IDAgendamento = c.Guid(nullable: false),
                        DataAgendada = c.DateTime(nullable: false),
                        DataReferencia = c.DateTime(nullable: false),
                        IDDocumento = c.Guid(nullable: false),
                        IDUnidade = c.Guid(nullable: false),
                        Id = c.String(nullable: false, maxLength: 128),
                        IDStatus = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IDAgendamento)
                .ForeignKey("dbo.tbDocumento", t => t.IDDocumento)
                .ForeignKey("dbo.tbUnidade", t => t.IDUnidade)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .ForeignKey("dbo.tbStatus", t => t.IDStatus)
                .Index(t => t.IDDocumento)
                .Index(t => t.IDUnidade)
                .Index(t => t.Id)
                .Index(t => t.IDStatus);
            
            CreateTable(
                "dbo.tbDocumento",
                c => new
                    {
                        IDDocumento = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        PrazoDiasVencimento = c.Int(nullable: false),
                        PrazoMesVencimento = c.Int(),
                        FlagDiasUteisVencimento = c.Boolean(nullable: false),
                        PrazoDiasAlerta = c.Int(nullable: false),
                        DataReferencia = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        FlagAtivo = c.Boolean(nullable: false),
                        IDOrigem = c.Guid(nullable: false),
                        IDPeriodicidade = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.IDDocumento)
                .ForeignKey("dbo.tbOrigem", t => t.IDOrigem)
                .ForeignKey("dbo.tbPeriodicidade", t => t.IDPeriodicidade)
                .Index(t => t.IDOrigem)
                .Index(t => t.IDPeriodicidade);
            
            CreateTable(
                "dbo.tbOrigem",
                c => new
                    {
                        IDOrigem = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.IDOrigem);
            
            CreateTable(
                "dbo.tbPeriodicidade",
                c => new
                    {
                        IDPeriodicidade = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.IDPeriodicidade);
            
            CreateTable(
                "dbo.tbResponsavelDocumento",
                c => new
                    {
                        IDUnidade = c.Guid(nullable: false),
                        IDDocumento = c.Guid(nullable: false),
                        PrazoDiasVencimento = c.Int(nullable: false),
                        PrazoMesVencimento = c.Int(nullable: false),
                        FlagDiasUteisVencimento = c.Boolean(nullable: false),
                        DataReferencia = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(nullable: false),
                        Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.IDUnidade, t.IDDocumento })
                .ForeignKey("dbo.tbDocumento", t => t.IDDocumento)
                .ForeignKey("dbo.tbUnidade", t => t.IDUnidade)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.IDUnidade)
                .Index(t => t.IDDocumento)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.tbUnidade",
                c => new
                    {
                        IDUnidade = c.Guid(nullable: false),
                        CNPJ = c.String(nullable: false, maxLength: 14, unicode: false),
                        InscricaoEstadual = c.String(maxLength: 14, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        DataAtualizacao = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        FlagAtivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IDUnidade);
            
            CreateTable(
                "dbo.tbStatus",
                c => new
                    {
                        IDStatus = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IDStatus);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropForeignKey("dbo.tbAgendamento", "IDStatus", "dbo.tbStatus");
            DropForeignKey("dbo.tbResponsavelDocumento", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.tbAgendamento", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.tbResponsavelDocumento", "IDUnidade", "dbo.tbUnidade");
            DropForeignKey("dbo.tbAgendamento", "IDUnidade", "dbo.tbUnidade");
            DropForeignKey("dbo.tbResponsavelDocumento", "IDDocumento", "dbo.tbDocumento");
            DropForeignKey("dbo.tbDocumento", "IDPeriodicidade", "dbo.tbPeriodicidade");
            DropForeignKey("dbo.tbDocumento", "IDOrigem", "dbo.tbOrigem");
            DropForeignKey("dbo.tbAgendamento", "IDDocumento", "dbo.tbDocumento");
            DropForeignKey("dbo.tbFeriado", "IDAbrangencia", "dbo.tbAbrangencia");
            DropIndex("dbo.tbResponsavelDocumento", new[] { "Id" });
            DropIndex("dbo.tbResponsavelDocumento", new[] { "IDDocumento" });
            DropIndex("dbo.tbResponsavelDocumento", new[] { "IDUnidade" });
            DropIndex("dbo.tbDocumento", new[] { "IDPeriodicidade" });
            DropIndex("dbo.tbDocumento", new[] { "IDOrigem" });
            DropIndex("dbo.tbAgendamento", new[] { "IDStatus" });
            DropIndex("dbo.tbAgendamento", new[] { "Id" });
            DropIndex("dbo.tbAgendamento", new[] { "IDUnidade" });
            DropIndex("dbo.tbAgendamento", new[] { "IDDocumento" });
            DropIndex("dbo.tbFeriado", new[] { "IDAbrangencia" });
            DropTable("dbo.tbStatus");
            DropTable("dbo.tbUnidade");
            DropTable("dbo.tbResponsavelDocumento");
            DropTable("dbo.tbPeriodicidade");
            DropTable("dbo.tbOrigem");
            DropTable("dbo.tbDocumento");
            DropTable("dbo.tbAgendamento");
            DropTable("dbo.tbFeriado");
            DropTable("dbo.tbAbrangencia");
        }
    }
}
