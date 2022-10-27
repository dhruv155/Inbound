using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Models.Dto
{
    public class DiscountDto
    {
        public int Id { get; set; }
        public int DiscountRate { get; set; }

        public int CustomerId { get; set; }
        public Customer customer { get; set; }
    }
}
