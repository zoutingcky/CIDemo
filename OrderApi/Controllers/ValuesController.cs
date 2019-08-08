using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Repository;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderDbContext _orderDbContext;

        public OrdersController(OrderDbContext orderDbContext)
        {
            this._orderDbContext=orderDbContext;
        }

        [HttpGet("{userId}")]
        public ActionResult<IEnumerable<Order>> GetOrdersByUserId(Guid userId)
        {
            var orders= _orderDbContext.Orders.Where(a=>a.UserId==userId).ToList();
            return orders;
        }

     
    }
}
