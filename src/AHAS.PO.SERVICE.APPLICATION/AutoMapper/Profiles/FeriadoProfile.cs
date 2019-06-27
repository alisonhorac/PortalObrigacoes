using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Enum;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using AutoMapper;

namespace AHAS.PO.SERVICE.APPLICATION.AutoMapper.Profiles
{
    public class FeriadoProfile : Profile
    {
        public FeriadoProfile()
        {
            CreateMap<FeriadoViewModel, Feriado>();
            CreateMap<Feriado, FeriadoViewModel>().ForMember(dest => dest.DescricaoAbrangencia, origem => origem.MapFrom(src => src.Abrangencia.Descricao))
                .ForMember(dest => dest.DescricaoFlagFeriadoFixo, origem => origem.MapFrom(src => src.FlagFeriadoFixo == true ? SimNao.Sim : SimNao.Nao));
        }
    }
}
