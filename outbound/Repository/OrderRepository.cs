using AutoMapper;
using CouponApi.DbContexts;
using CouponApi.Models.Dto;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using outbound.Models;
using outbound.Models.Dto;
using outbound.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace outbound.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<OrderRepository> _logger;
        private IMapper _mapper;
        private readonly HttpClient client;
        public OrderRepository(ApplicationDbContext db, IMapper mapper,HttpClient client, ILogger<OrderRepository> logger)
        {
            _db = db;
            _mapper = mapper;
            this.client = client;
            _logger =logger;

        }
        public async Task<OrderDto> CreateOrder(OrderDto orderDto)
        {
            Order order = _mapper.Map<OrderDto, Order>(orderDto);
            _logger.LogInformation("done");
            _logger.LogInformation("{0}",orderDto);
            var response = await client.GetAsync($"/coupon/{order.couponcode}");
            CouponDto resp = JsonConvert.DeserializeObject<CouponDto>(response.Content.ReadAsStringAsync().Result);
            double discountprice = resp.DiscountAmount;

            orderDto.price = orderDto.price - discountprice;
            //_db.Orders.Add(order);
            await _db.SaveChangesAsync();
            return _mapper.Map<Order, OrderDto>(order);
        }
    }
}
