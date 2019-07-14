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
                    .ForMember(dest => dest.DescricaoFlagFeriadoFixo, origem => origem.MapFrom(src => src.FlagFeriadoFixo == true ? SimNao.Sim : SimNao.Nao))
                    .ForMember(dest => dest.HabilitaEstado, origem => origem.MapFrom(src => src.IDEstado != null))
                    .ForMember(dest => dest.DescricaoEstado, origem => origem.MapFrom(src => src.Estado.Descricao))
                    .ForMember(dest => dest.PeriodoDeAte, origem => origem.MapFrom(src => string.Format("{0} - {1}",src.DataDe.ToString("dd/MM/yyyy"), src.DataAte.ToString("dd/MM/yyyy"))));
        }
    }
}
