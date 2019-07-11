﻿using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.UnitOfWork;
using AHAS.PO.SERVICE.APPLICATION.AutoMapper;
using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AHAS.PO.SERVICE.APPLICATION.Services
{
    public class FeriadoAppService : AppService, IFeriadoAppService
    {
        private readonly IFeriadoService _FeriadoService;

        public FeriadoAppService(IFeriadoService feriadoService, IUnitOfWorkService uow) : base(uow)
        {
            _FeriadoService = feriadoService;
        }

        public FeriadoViewModel Alterar(FeriadoViewModel feriadoViewModel)
        {
            var feriado = AutoMapperConfig.Mapper.Map<FeriadoViewModel, Feriado>(feriadoViewModel);
            return AutoMapperConfig.Mapper.Map<Feriado, FeriadoViewModel>(_FeriadoService.Alterar(feriado));
        }

        public bool Excluir(Guid id)
        {
            return _FeriadoService.Excluir(id);
        }

        public FeriadoViewModel Inserir(FeriadoViewModel feriadoViewModel)
        {
            var feriado = AutoMapperConfig.Mapper.Map<FeriadoViewModel, Feriado>(feriadoViewModel);
            var result = AutoMapperConfig.Mapper.Map<Feriado, FeriadoViewModel>(_FeriadoService.Inserir(feriado));
            Commit();

            return result;
        }

        public IEnumerable<FeriadoViewModel> Listar()
        {
            return AutoMapperConfig.Mapper.Map<IEnumerable<Feriado>, IEnumerable<FeriadoViewModel>>(_FeriadoService.Listar());
        }

        public void Dispose()
        {
            _FeriadoService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
