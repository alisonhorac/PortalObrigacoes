using System;
using System.Collections.Generic;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.UnitOfWork;
using AHAS.PO.SERVICE.APPLICATION.AutoMapper;
using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;

namespace AHAS.PO.SERVICE.APPLICATION.Services
{
    public class UnidadeAppService : AppService, IUnidadeAppService
    {
        private readonly IUnidadeService _UnidadeService;

        public UnidadeAppService(IUnidadeService UnidadeService, IUnitOfWorkService uow) : base(uow)
        {
            _UnidadeService = UnidadeService;
        }

        public UnidadeViewModel Alterar(UnidadeViewModel obj)
        {
            var unidade = AutoMapperConfig.Mapper.Map<UnidadeViewModel, Unidade>(obj);
            return AutoMapperConfig.Mapper.Map<Unidade, UnidadeViewModel>(_UnidadeService.Alterar(unidade));
        }

        public UnidadeViewModel Consultar(long id)
        {
            return AutoMapperConfig.Mapper.Map<Unidade, UnidadeViewModel>(_UnidadeService.Consultar(id));
        }

        public bool Excluir(long id)
        {
            throw new System.NotImplementedException();
        }

        public UnidadeViewModel Inserir(UnidadeViewModel obj)
        {
            var unidade = AutoMapperConfig.Mapper.Map<UnidadeViewModel, Unidade>(obj);
            return AutoMapperConfig.Mapper.Map<Unidade, UnidadeViewModel>(_UnidadeService.Inserir(unidade));
        }

        public IEnumerable<UnidadeViewModel> Listar()
        {
            return AutoMapperConfig.Mapper.Map<IEnumerable<Unidade>, IEnumerable<UnidadeViewModel>>(_UnidadeService.Listar());
        }

        public void Dispose()
        {
            _UnidadeService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
