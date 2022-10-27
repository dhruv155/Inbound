using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Models.Dto
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;

        public object  Result { get; set; }

        public string DisplayMessage { get; set; }

        public List<String> ErrorMessage { get; set; }
        public List<string> ErrorMessages { get; internal set; }
    }
}
