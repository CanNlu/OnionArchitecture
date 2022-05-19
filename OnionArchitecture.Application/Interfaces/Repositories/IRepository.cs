using OnionArchitecture.Domain.Common;

namespace OnionArchitecture.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
