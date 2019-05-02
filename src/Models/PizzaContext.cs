
using Microsoft.EntityFrameworkCore;

namespace amicroservice.Models
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
        : base(options)
        {
        }
        public DbSet<Pizza> PizzaOrders { get; set; }
    }
}