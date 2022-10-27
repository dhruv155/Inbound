using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CouponApi.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }

    }
}
