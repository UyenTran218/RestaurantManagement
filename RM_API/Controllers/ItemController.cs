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
    public class ItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Item List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _context.Item.ToList();
        }

        /// <summary>
        /// Get Item by Id
        /// </summary>
        /// <returns>Item by Id</returns>
        /// <param name="Id">Item Id</param>
        [HttpGet("Id")]
        public Item Get([FromQuery] int Id)
        {
            return _context.Item.Where(item => item.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Add New Item
        /// </summary>
        /// <returns>Item</returns>
        [HttpPost]
        public Item Posts([FromQuery] Item Item)
        {
            _context.Item.Add(Item);
            _context.SaveChanges();
            return Item;
        }
    }
}
