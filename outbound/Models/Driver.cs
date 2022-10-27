using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        

    }
}
