using outbound.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Services
{
  public  interface IOrderRepository
    {
        Task<OrderDto> CreateOrder(OrderDto orderDto);

    }
}
