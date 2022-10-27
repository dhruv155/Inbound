using AutoMapper;
using CouponApi.Models;
using CouponApi.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto,Coupon>().ReverseMap();
                

            });
            return mappingConfig;
        }
    }
}
