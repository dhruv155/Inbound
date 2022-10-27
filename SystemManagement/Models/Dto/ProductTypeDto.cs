using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagement.Models.Dto
{
    public class ProductTypeDto
    {
        public new long Id { get; set; }

        public string Name { get; set; }

        public Guid ReferenceId { get; set; }

    }
}
