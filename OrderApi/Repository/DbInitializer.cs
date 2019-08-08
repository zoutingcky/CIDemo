using System;
using System.Linq;

namespace OrderApi.Repository
{
    public static class DbInitializer
    {
        public static void Initialize(OrderDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Orders.Any())
            {
                return;
            }

            context.Orders.Add(new Order
            {

                Id=Guid.NewGuid(),
                UserId=Guid.Parse("0036BDEA-9E88-4246-9EBB-314680085653"),
                ProductName="Product 1"

            });
            context.Orders.Add(new Order
            {

                Id=Guid.NewGuid(),
                UserId=Guid.Parse("0036BDEA-9E88-4246-9EBB-314680085653"),
                ProductName="Product 2"

            });
            context.SaveChanges();
        }
    }
}