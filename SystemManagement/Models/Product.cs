using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public int price { get; set; }
        public int Quantity { get; set; }
    }
}
