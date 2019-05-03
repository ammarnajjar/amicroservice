
using Microsoft.EntityFrameworkCore;
using amicroservice.Models;

namespace amicroservice.Models
{
    public class PizzaContext : DbContext, IDbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
        : base(options)
        {
        }
        public DbSet<Pizza> PizzaOrders { get; set; }
    }
}