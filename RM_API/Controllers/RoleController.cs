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
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Role List
        /// </summary>
        /// <returns>Role List</returns>
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _context.Role.ToList();
        }

        /// <summary>
        /// Get Role by Id
        /// </summary>
        /// <returns>Role by Id</returns>
        /// <param name="Id">Role Id</param>
        [HttpGet("Id")]
        public Role Get([FromQuery] int Id)
        {
            return _context.Role.Where(role => role.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Create New Role
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public Role Posts([FromQuery] Role Role)
        {
            _context.Role.Add(Role);
            _context.SaveChanges();
            return Role;
        }
    }
}
