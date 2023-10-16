using Microsoft.EntityFrameworkCore;
using Pindaro.Services.RewardAPI.Data;
using Pindaro.Services.RewardAPI.Message;
using Pindaro.Services.RewardAPI.Models;
using System.Text;

namespace Pindaro.Services.RewardAPI.Services
{
    public class RewardService : IRewardService
    {
        private DbContextOptions<AppDbContext> _dbOptions;

        public RewardService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task UpdateRewards(RewardsMessage rewardsMessage)
        {
            try
            {
                Rewards rewards = new()
                {
                    OrderId = rewardsMessage.OrderId,
                    RewardsActivity = rewardsMessage.RewardsActivity,
                    UserId = rewardsMessage.UserId,
                    RewardsDate = DateTime.Now
                };

                await using var _db = new AppDbContext(_dbOptions);
                await _db.Rewards.AddAsync(rewards);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
