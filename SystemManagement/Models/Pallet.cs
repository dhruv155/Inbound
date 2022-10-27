using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class Pallet
    {
        public new long Id { get; set; }
        public string Name { get; set; }
        public long ProductTypeId { get; set; }

        public long Quantity { get; set; }

        public ProductType ProductType { get; set; }
    }
}
