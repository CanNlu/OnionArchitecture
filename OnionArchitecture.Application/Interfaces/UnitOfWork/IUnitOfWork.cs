using Microsoft.EntityFrameworkCore.Storage;
using OnionArchitecture.Application.Interfaces.Repositories;

namespace OnionArchitecture.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IProductRepository ProductRepository { get; }
    }
}
