using AutoMapper;
using Pindaro.Services.ProductAPI.Models;
using Pindaro.Services.ProductAPI.Models.Dto;

namespace Pindaro.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
