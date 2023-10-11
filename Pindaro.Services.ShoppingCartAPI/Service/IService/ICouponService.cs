using Pindaro.Services.ShoppingCartAPI.Models.Dto;

namespace Pindaro.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
