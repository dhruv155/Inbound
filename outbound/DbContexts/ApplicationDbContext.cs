using Microsoft.EntityFrameworkCore;
using outbound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Truck> Trucks { get; set; }

        //public DbSet<Order> Orders { get; set; }

    }
}
