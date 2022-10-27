using CouponApi.Models.Dto;
using CouponApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouponApi.Controllers
{
    [ApiController]
    [Route("api/coupon")]
    public class CouponController : Controller
    {
        private readonly ICouponRepository _couponRepository;
        protected CouponDto _response; 

        public CouponController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
            this._response = new CouponDto();
        }
        [HttpGet]
        [Route("{code}")]
        public async Task<CouponDto> GetDiscountForCode(string code)
        {
            
                var coupon = await _couponRepository.GetCouponByCode(code);
                _response = coupon;
            
        
            return _response;
        }



    }
}
