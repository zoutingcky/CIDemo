using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using UserApi.Repository;
using UserApi.ViewModel;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public UsersController(UserDbContext dbContext,IConfiguration configuration)
        {
            this._dbContext=dbContext;
            this._configuration=configuration;
        }

        [HttpGet]
        public async Task<IEnumerable<ViewModel.User>> Get()
        {
           var orderApi= _configuration.GetSection("Settings")["OrderApi"];
            var users = _dbContext.Users.ToList();
            var resultUses = new List<ViewModel.User>();
            using (var client = new HttpClient())
            {
                foreach (var user in users)
                {
                    var response = await client.GetAsync(string.Format(orderApi, user.Id));
                    var orders = await response.Content.ReadAsAsync<List<Order>>();
                    resultUses.Add(new ViewModel.User
                    {
                        Id=user.Id,
                        UserName=user.UserName,
                        Email=user.Email,
                        Password=user.Password,
                        Orders=orders
                    });
                }
            }
            return resultUses;

        }

    }
}
