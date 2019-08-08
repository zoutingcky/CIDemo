using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace OrderApi.Repository
{
    public class OrderDbContext : DbContext
    {

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
    }
}
