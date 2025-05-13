using application2.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace application2.data
{
    public class WalksDbContext: DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
