using Pindaro.Services.OrderAPI.Models.Dto;

namespace Pindaro.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
