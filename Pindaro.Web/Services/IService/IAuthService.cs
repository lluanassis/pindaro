using Pindaro.Web.Models;

namespace Pindaro.Web.Services.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsync (LoginRequestDto loginRequest);
        Task<ResponseDto?> RegisterAsync (RegistrationRequestDto registrationRequestDto);
        Task<ResponseDto?> AssingRoleAsync (RegistrationRequestDto registrationRequestDto);
    }
}
