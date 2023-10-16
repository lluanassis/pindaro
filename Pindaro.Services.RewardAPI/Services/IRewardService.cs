using Pindaro.Services.RewardAPI.Message;

namespace Pindaro.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
