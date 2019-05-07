
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace amicroservice.Models.Factory
{
    public interface IDbContext
    {
        int SaveChanges();
        EntityEntry Entry(object entity);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        DbSet<Pizza> PizzaOrders { get; set; }
    }
}