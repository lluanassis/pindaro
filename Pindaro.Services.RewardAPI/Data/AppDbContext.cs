using Microsoft.EntityFrameworkCore;
using Pindaro.Services.RewardAPI.Models;

namespace Pindaro.Services.RewardAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Rewards> Rewards { get; set; }
    }
}
