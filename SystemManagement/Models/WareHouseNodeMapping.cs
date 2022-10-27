using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class WareHouseNodeMApping
    {
        public int NodeId { get; set; }

        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }

        public Node node { get; set; }
    }
}
