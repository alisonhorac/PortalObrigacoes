using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.PO.SERVICE.APPLICATION.AutoMapper;
using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.SERVICE.APPLICATION.Services
{
    public class AbrangenciaAppService : IAbrangenciaAppService
    {
        private readonly IAbrangenciaService _AbrangenciaService;

        public AbrangenciaAppService(IAbrangenciaService abrangenciaService)
        {
            _AbrangenciaService = abrangenciaService;
        }

        public IEnumerable<AbrangenciaViewModel> Listar()
        {
            return AutoMapperConfig.Mapper.Map<IEnumerable<Abrangencia>, IEnumerable<AbrangenciaViewModel>>(_AbrangenciaService.Listar());
        }

        public void Dispose()
        {
            _AbrangenciaService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
