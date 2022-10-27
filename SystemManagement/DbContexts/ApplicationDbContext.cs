using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagement.Models.Dto;

namespace SystemManagement.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //public DbSet<Order> Orders { get; set; }
        public DbSet<ProductDto> Products { get; set; }

        public DbSet<Pallet> Pallets { get; set; }

    }
}
