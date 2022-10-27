using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class LicensePlateNumber
    {
        public new long Id { get; set; }
        public int NodeId { get; set; }

        public Node Node { get; set; }
    }
}
