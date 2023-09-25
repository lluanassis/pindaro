using Pindaro.Web.Models;

namespace Pindaro.Web.Services.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requesDto, bool withBearer = true);
    }
}
