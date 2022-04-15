using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RM_API.Data;
using RM_API.Models;

namespace RM_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrderItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<OrderItem> Get()
        {
            return _context.OrderItem.ToList();
        }
    }
}
