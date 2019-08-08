using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApi.ViewModel
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Order> Orders { get; set; }
    }
    public class Order
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Guid UserId { get; set; }
    }
}
