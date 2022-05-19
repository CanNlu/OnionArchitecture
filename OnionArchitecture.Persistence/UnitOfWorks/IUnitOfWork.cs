using Microsoft.EntityFrameworkCore.Storage;
using OnionArchitecture.Persistence.Repositories;

namespace OnionArchitecture.Persistence.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IProductRepository ProductRepository { get; }
    }
}
