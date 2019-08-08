using System;

namespace OrderApi.Repository
{
    public class Order
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Guid UserId { get; set; }
    }
}