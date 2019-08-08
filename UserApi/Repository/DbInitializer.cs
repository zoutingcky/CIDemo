using System;
using System.Linq;

namespace UserApi.Repository
{
    public static class DbInitializer
    {
        public static void Initialize(UserDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;   
            }

            context.Users.Add(new User {

                Id=Guid.Parse("0036BDEA-9E88-4246-9EBB-314680085653"),
                UserName="TestUser",
                Email="test@test.com",
                Password="Password1"
            });
            context.SaveChanges();
        }
    }
}