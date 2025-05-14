using application2.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace application2.data
{
    public class WalksDbContext : DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

        //protected override void OnModelCreating(ModelBuilder ModelBuilder)
        //{
        //    base.OnModelCreating(ModelBuilder);

        //    var difficulty = new List<WalkDifficulty>()
        //   {
        //       new WalkDifficulty()
        //       {
        //           Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
        //           Code = "Easy"
        //       },
        //       new WalkDifficulty()
        //       {
        //           Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
        //           Code = "Medium"
        //       },
        //       new WalkDifficulty()
        //       {
        //           Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
        //           Code = "Hard"
        //       }
        //   };

        //    ModelBuilder.Entity<WalkDifficulty>().HasData(difficulty);

        //    var regions = new List<Region>()
        //   {
        //       new Region()
        //       {
        //           Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
        //           Code = "IN",
        //           Name = "India",
        //           Area = 3287263,
        //           Lat = 20.5937,
        //           Long = 78.9629,
        //           Population = 1393409038
        //       },
        //       new Region()
        //       {
        //           Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
        //           Code = "US",
        //           Name = "United States",
        //           Area = 9833517,
        //           Lat = 37.0902,
        //           Long = -95.7129,
        //           Population = 331893745
        //       }
        //   };

        //    ModelBuilder.Entity<Region>().HasData(regions);
        //}
    }
}
