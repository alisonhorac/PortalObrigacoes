using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using AutoMapper;

namespace AHAS.PO.SERVICE.APPLICATION.AutoMapper.Profiles
{
    public class UnidadeProfile : Profile
    {
        public UnidadeProfile()
        {
            CreateMap<UnidadeViewModel, Unidade>();
            CreateMap<Unidade, UnidadeViewModel>();
        }
    }
}
