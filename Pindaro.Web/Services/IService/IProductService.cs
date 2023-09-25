using Pindaro.Web.Models;

namespace Pindaro.Web.Services.IService
{
    public interface IProductService
    {
        Task<ResponseDto?> GetProduct(string couponCode);
        Task<ResponseDto?> GetAllProductsAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> UpdateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> DeleteProductsAsync(int id);
    }
}
