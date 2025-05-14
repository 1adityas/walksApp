namespace application2.Repositories
{
    public interface IWalksRepository
    {
        Task<IEnumerable<Models.Domain.Walk>> GetAllAsync();
        Task<Models.Domain.Walk> GetAsync(Guid id);
        Task<Models.Domain.Walk> CreateAsync(Models.Domain.Walk walk);
        Task<Models.Domain.Walk> DeleteAsync(Guid id);
        Task<Models.Domain.Walk> UpdateAsync(Guid id, Models.Domain.Walk walk);

    }
}
