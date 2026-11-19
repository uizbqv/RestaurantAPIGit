using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Entities;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private static readonly List<Order> _orders = new List<Order>
        {
            new Order{Id = 1, TableId = 2, CreatedAt = DateTime.Now, GuestCount = 2, Status = "open", PaidAt = DateTime.Now.Date, TotalPrice = 2.54 }
        };


    }
}
