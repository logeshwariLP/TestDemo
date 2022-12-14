using AutoMapper;
using SearchCifApi.Models;
using SearchCifApi.Models.Dto;

namespace SearchCifApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {

            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CifUserDto, CifUser>();
                config.CreateMap<CifUser, CifUserDto>();
            });
            return mappingConfig;
        }
    }
}
