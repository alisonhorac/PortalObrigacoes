using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.SERVICE.APPLICATION.AutoMapper.Profiles
{
    public class AbrangenciaProfile : Profile
    {
        public AbrangenciaProfile()
        {
            CreateMap<AbrangenciaViewModel, Abrangencia>();

            CreateMap<Abrangencia, AbrangenciaViewModel>();
        }
    }
}
