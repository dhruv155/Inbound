using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models.Dto
{
    public class WareHouseProductTypeDto
    {
        public int Id;
        public WareHouseDto WareHouse { get; set; }

        public ProductTypeDto ProductType { get; set; }
    }
}
