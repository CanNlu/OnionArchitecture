using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Persistence.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
    }
}
