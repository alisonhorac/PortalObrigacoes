using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.SERVICE.APPLICATION.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.SERVICE.APPLICATION.AutoMapper.Profiles
{
    public class FeriadoProfile : Profile
    {
        public FeriadoProfile()
        {
            CreateMap<FeriadoViewModel, Feriado>();
            CreateMap<Feriado, FeriadoViewModel>();
        }
    }
}
