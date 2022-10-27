using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponApi.Models.Dto
{
    public class ResponseDto<T>
    {
        public bool IsSuccess { get; set; } = true;
        public T Result { get; set; }

        public string DisplayMessage { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
