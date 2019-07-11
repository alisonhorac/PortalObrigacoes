using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Enum;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using AutoMapper;
using System.Linq;

namespace AHAS.PO.SERVICE.APPLICATION.AutoMapper.Profiles
{
    public class FeriadoProfile : Profile
    {
        public FeriadoProfile()
        {
            CreateMap<FeriadoViewModel, Feriado>()
                    .ForMember(dest => dest.DataDe, origem => origem.MapFrom(src => src.PeriodoDeAte.Split('-').Skip(0).First().Trim()))
                    .ForMember(dest => dest.DataAte, origem => origem.MapFrom(src => src.PeriodoDeAte.Split('-').Skip(1).First().Trim()));

            CreateMap<Feriado, FeriadoViewModel>()
                    .ForMember(dest => dest.DescricaoAbrangencia, origem => origem.MapFrom(src => src.Abrangencia.Descricao))
                    .ForMember(dest => dest.DescricaoFlagFeriadoFixo, origem => origem.MapFrom(src => src.FlagFeriadoFixo == true ? SimNao.Sim : SimNao.Nao));
        }
    }
}
