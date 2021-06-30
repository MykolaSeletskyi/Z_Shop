using Microsoft.EntityFrameworkCore;
using Z_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z_Shop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}