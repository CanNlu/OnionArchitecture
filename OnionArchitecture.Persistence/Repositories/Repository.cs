using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Interfaces.Repositories;
using OnionArchitecture.Domain.Common;
using OnionArchitecture.Persistence.Context;

namespace OnionArchitecture.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        private DbSet<T> Table { get => _context.Set<T>(); }
        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            Table.Update(entity);
            await _context.SaveChangesAsync();
            return 1;
        }
        public async Task DeleteAsync(T entity)
        {
            Table.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync() => await Table.ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await Table.FindAsync(id);

    }
}

