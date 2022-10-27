using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class PalletLpnMapping
    {

        public long PalletId { get; set; }

        public long LicensePlateNumberId { get; set; }

        public Pallet Pallet { get; set; }
        public LicensePlateNumber LicensePlateNumber { get; set; }
    }
}
