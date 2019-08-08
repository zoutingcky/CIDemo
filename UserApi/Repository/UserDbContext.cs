using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace UserApi.Repository
{
    public class UserDbContext : DbContext
    {

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
