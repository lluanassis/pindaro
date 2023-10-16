using Pindaro.Services.EmailAPI.Message;
using Pindaro.Services.EmailAPI.Models.Dto;

namespace Pindaro.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisteredUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
