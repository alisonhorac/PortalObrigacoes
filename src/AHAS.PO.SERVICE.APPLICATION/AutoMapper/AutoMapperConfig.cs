using AHAS.PO.SERVICE.APPLICATION.AutoMapper.Profiles;
using AutoMapper;

namespace AHAS.PO.SERVICE.APPLICATION.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        public static void RegisterMappings()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<FeriadoProfile>();
            });

            Mapper = config.CreateMapper();
        }
    }
}
