using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public int price { get; set; }
        public int Quantity { get; set; }
    }
}
