using AutoMapper;
using Pindaro.Services.CouponAPI.Models;
using Pindaro.Services.CouponAPI.Models.Dto;

namespace Pindaro.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
