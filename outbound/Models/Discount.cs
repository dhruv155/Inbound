using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        public int DiscountRate { get; set; }

        public int CustomerId { get; set; }
        public Customer customer { get; set; }

        //public int CustomerId { get; set; }

    }
}
