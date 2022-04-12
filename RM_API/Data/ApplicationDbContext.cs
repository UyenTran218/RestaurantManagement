using Microsoft.EntityFrameworkCore;
using RM_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RM_API.Data
{
    
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Item> Item { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void  OnModelCreating(ModelBuilder modelBuiler)
        {
            base.OnModelCreating(modelBuiler);
        }
    }

    
}
