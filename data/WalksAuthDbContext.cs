using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace application2.data
{
    public class WalksAuthDbContext : IdentityDbContext
    {
        //by adding new db context, application starts to fail, basically if we have more
        //than one db context, we need to specify which db context to use in the startup.cs file
        //had to use <WalksAuthDbContext>
        public WalksAuthDbContext(DbContextOptions<WalksAuthDbContext> options) : base(options)
        {
        }
        // You can add DbSet properties for your entities here if needed
        // For example:
        // public DbSet<YourEntity> YourEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional model configurations can go here
            var readerRoleId = "3fba8f5e-41a2-4e04-a9ff-6a45f2345fc6";
            var writerRoleId = "b19c9a2d-61f6-4b1b-95fd-312a4eae1088";


            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    Name = "Reader",
                    ConcurrencyStamp = readerRoleId,
                    NormalizedName = "READER".ToUpper(),
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    Name = "Writer",
                    ConcurrencyStamp = readerRoleId,
                    NormalizedName = "WRITER".ToUpper()
                }
            };

            // Seed the roles into the database, this will only run once when the database is created

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
