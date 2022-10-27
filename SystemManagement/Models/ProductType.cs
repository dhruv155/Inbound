using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models
{
    public class ProductType
    {
        public new long Id { get; set; }

        public string Name { get; set; }

        public Guid ReferenceId { get; set; }

    }
}
