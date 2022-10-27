using AutoMapper;
using outbound.Models;
using outbound.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CustomerDto, Customer>().ReverseMap();
                config.CreateMap<DiscountDto, Discount>().ReverseMap();
                config.CreateMap<DriverDto, Driver>().ReverseMap();
                config.CreateMap<OrderDto, Order>().ReverseMap();
                config.CreateMap<ShipmentDto, Shipment>().ReverseMap();
                config.CreateMap<TruckDto, Truck>().ReverseMap();

            });
            return mappingConfig;
        }
    }
}
