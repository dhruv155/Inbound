using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponApi.Models.Dto
{
    public class CouponDto
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }

    }
}
