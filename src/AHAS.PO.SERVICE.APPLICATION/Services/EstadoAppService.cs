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
    public class EstadoAppService : IEstadoAppService
    {
        private readonly IEstadoService _EstadoService;

        public EstadoAppService(IEstadoService estadoService)
        {
            _EstadoService = estadoService;
        }

        public IEnumerable<EstadoViewModel> Listar()
        {
            return AutoMapperConfig.Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoViewModel>>(_EstadoService.Listar());
        }

        public void Dispose()
        {
            _EstadoService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
