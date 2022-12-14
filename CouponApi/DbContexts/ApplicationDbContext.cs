using CouponApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponApi.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public object orders;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon

            {
                Id = 1,
                CouponCode = "10OFF",
                DiscountAmount = 100
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon

            {
                Id = 2,
                CouponCode = "20OFF",
                DiscountAmount = 200
            });
        }

    }
}
