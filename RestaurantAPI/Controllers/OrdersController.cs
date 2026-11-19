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
            new Order{Id = 1, TableId = 2, CreatedAt = new DateTime(2026, 11, 19, 12, 42, 0), GuestCount = 2, Status = "open", PaidAt = null, TotalPrice = 2.54 },
            new Order{Id = 2, TableId = 5, CreatedAt = new DateTime(2026, 11, 19, 13, 2, 0), GuestCount = 6, Status = "open", PaidAt = null, TotalPrice = 2.54 }
        };
        [HttpGet]
        public ActionResult<List<Order>> GetAll()
        {
            return Ok(_orders);
        }
        [HttpGet("{id}")]
        public ActionResult<Order> GetById(int id)
        {
            foreach (var a in _orders)
            {
                if (a.Id == id)
                {
                    return Ok(a);
                }
            }
            return NotFound();
        }

    }
}
