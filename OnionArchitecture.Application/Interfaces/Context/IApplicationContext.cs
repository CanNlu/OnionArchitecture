using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Interfaces.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
    }
}
