using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.PO.SERVICE.APPLICATION.AutoMapper;
using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModel;
using System;
using System.Collections.Generic;

namespace AHAS.PO.SERVICE.APPLICATION.Services
{
    public class FeriadoAppService : IFeriadoAppService
    {
        private readonly IFeriadoService _feriadoService;

        public FeriadoAppService(IFeriadoService feriadoService)
        {
            _feriadoService = feriadoService;
        }

        public FeriadoViewModel Alterar(FeriadoViewModel feriadoViewModel)
        {
            var feriado = AutoMapperConfig.Mapper.Map<FeriadoViewModel, Feriado>(feriadoViewModel);
            return AutoMapperConfig.Mapper.Map<Feriado, FeriadoViewModel>(_feriadoService.Alterar(feriado));
        }

        public bool Excluir(Guid id)
        {
            return _feriadoService.Excluir(id);
        }

        public FeriadoViewModel Inserir(FeriadoViewModel feriadoViewModel)
        {
            var feriado = AutoMapperConfig.Mapper.Map<FeriadoViewModel, Feriado>(feriadoViewModel);
            return AutoMapperConfig.Mapper.Map<Feriado, FeriadoViewModel>(_feriadoService.Inserir(feriado));
        }

        public IEnumerable<FeriadoViewModel> Listar()
        {
            return AutoMapperConfig.Mapper.Map<IEnumerable<Feriado>, IEnumerable<FeriadoViewModel>>(_feriadoService.Listar());
        }

        public void Dispose()
        {
            _feriadoService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
