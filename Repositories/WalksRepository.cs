using application2.data;
using application2.Models.Domain;

namespace application2.Repositories
{
    public class WalksRepository : IWalksRepository
    {
        private readonly WalksDbContext dbContext;
        public WalksRepository(WalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }

        public Task<Walk> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Walk>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Walk> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Walk> UpdateAsync(Guid id, Walk walk)
        {
            throw new NotImplementedException();
        }
    }
}
