using AHAS.PO.INFRA.CROSS.IDENTITY.Configuration;
using AHAS.PO.INFRA.CROSS.IDENTITY.Context;
using AHAS.PO.INFRA.CROSS.IDENTITY.External.SendGridEmail;
using AHAS.PO.INFRA.CROSS.IDENTITY.External.TwilioSms;
using AHAS.PO.INFRA.CROSS.IDENTITY.Intefaces.Service;
using AHAS.PO.INFRA.CROSS.IDENTITY.Model;
using AHAS.PO.INFRA.CROSS.IDENTITY.Services;
using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.INFRA.DATA.Repository;
using AHAS.PO.INFRA.DATA.UnitOfWork;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.UnitOfWork;
using AHAS.PO.LOGIC.DOMAIN.Services;
using AHAS.PO.SERVICE.APPLICATION.Services;
using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;

namespace AHAS.PO.INFRA.CROSS.DIPCFG
{
    public static class BootStrapper
    {
        public static void RegistrarServicos(Container container)
        {
            //IDENTITY
            container.Register<DataBaseIdentityContext>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(container.GetInstance<DataBaseIdentityContext>()), Lifestyle.Scoped);
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(), Lifestyle.Scoped);
            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);

            //APPLICATION
            container.Register<IFeriadoAppService, FeriadoAppService>(Lifestyle.Scoped);
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);

            //DOMAIN
            container.Register<IUnidadeService, UnidadeService>(Lifestyle.Scoped);
            container.Register<IStatusService, StatusService>(Lifestyle.Scoped);
            container.Register<IResponsavelDocumentoService, ResponsavelDocumentoService>(Lifestyle.Scoped);
            container.Register<IPeriodicidadeService, PeriodicidadeService>(Lifestyle.Scoped);
            container.Register<IOrigemService, OrigemService>(Lifestyle.Scoped);
            container.Register<IFeriadoService, FeriadoService>(Lifestyle.Scoped);
            container.Register<IDocumentoService, DocumentoService>(Lifestyle.Scoped);
            container.Register<IAgendamentoService, AgendamentoService>(Lifestyle.Scoped);
            container.Register<IAbrangenciaService, AbrangenciaService>(Lifestyle.Scoped);
            container.Register<IUnitOfWorkService, UnitOfWorkService>(Lifestyle.Scoped);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);

            //DADOS
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IUnidadeRepository, UnidadeRepository>(Lifestyle.Scoped);
            container.Register<IStatusRepository, StatusRepository>(Lifestyle.Scoped);
            container.Register<IResponsavelDocumentoRepository, ResponsavelDocumentoRepository>(Lifestyle.Scoped);
            container.Register<IPeriodicidadeRepository, PeriodicidadeRepository>(Lifestyle.Scoped);
            container.Register<IOrigemRepository, OrigemRepository>(Lifestyle.Scoped);
            container.Register<IFeriadoRepository, FeriadoRepository>(Lifestyle.Scoped);
            container.Register<IDocumentoRepository, DocumentoRepository>(Lifestyle.Scoped);
            container.Register<IAgendamentoRepository, AgendamentoRepository>(Lifestyle.Scoped);
            container.Register<IAbrangenciaRepository, AbrangenciaRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWorkRepository, UnitOfWork>(Lifestyle.Scoped);

            //Context
            container.Register<DataBaseContext>(Lifestyle.Scoped);

            //MailService/SmsService
            container.Register<IEmailService, EmailService>(Lifestyle.Scoped);
            container.Register<ISmsService, SmsService>(Lifestyle.Scoped);

            //SendGrid
            container.Register<ISendGridEmail, SendGridEmail>(Lifestyle.Scoped);

            //Twilio
            container.Register<ITwilioSms, TwilioSms>(Lifestyle.Scoped);
        }
    }
}
