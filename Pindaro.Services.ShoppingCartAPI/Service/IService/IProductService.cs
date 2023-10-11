using Pindaro.Services.ShoppingCartAPI.Models.Dto;

namespace Pindaro.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
