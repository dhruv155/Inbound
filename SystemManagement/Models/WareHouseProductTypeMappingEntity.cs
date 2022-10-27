using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class WareHouseProductTypeMappingEntity
    {
        public int Id;
        public long ProductTypeId { get; set; }

        public int WareHouseId { get; set; }

        public ProductType ProductType { get; set; }

        public Warehouse WareHouse { get; set; }
    }
}
