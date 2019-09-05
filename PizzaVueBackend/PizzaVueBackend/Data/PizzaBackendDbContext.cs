using Microsoft.EntityFrameworkCore;
using PizzaVueBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaVueBackend.Data
{
    public class PizzaBackendDbContext : DbContext
    {
        public PizzaBackendDbContext(DbContextOptions<PizzaBackendDbContext>options) : base (options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
