using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Models.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }

        public string couponcode;

        public double price;
    }
}
