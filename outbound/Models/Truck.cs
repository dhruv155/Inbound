﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Models
{
    public class Truck
    {
        [Key]
        public int Id { get; set; }
        public int wheels_count { get; set; }

    }
}
