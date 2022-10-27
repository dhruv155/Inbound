using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public string Shipment_Address { get; set; }

        public int DriverId { get; set; }

        public int TruckId { get; set; }

        public Driver Driver { get; set; }

        public Truck truck { get; set; }


    }
}
