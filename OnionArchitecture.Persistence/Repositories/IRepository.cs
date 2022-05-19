using OnionArchitecture.Domain.Common;

namespace OnionArchitecture.Persistence.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}
