using Microsoft.AspNetCore.Mvc;
using outbound.Models.Dto;
using outbound.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Controllers
{
    [Route("api/customers")]
    public class CustomerController : Controller
    {
        protected ResponseDto _response;

        private ICustomerRepository _customerRepository;

        public CustomerController (ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            this._response = new ResponseDto();

        }
        [HttpGet]
        public async Task<Object> Get()
        {
            try
            {
                IEnumerable<CustomerDto> customerDtos = await _customerRepository.GetAllCustomers();
                _response.Result = customerDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
               CustomerDto customerDto = (CustomerDto)await _customerRepository.GetCustomerById(id);
                _response.Result = customerDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [HttpPost]

        public async Task<object> Post([FromBody] CustomerDto customerDto)
        {
            try
            {
                CustomerDto model = await _customerRepository.CreateUpdateCustomer(customerDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] CustomerDto customerDto)
        {
            try
            {
                CustomerDto model = await _customerRepository.CreateUpdateCustomer(customerDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
        [HttpDelete]

        public async Task<object> Delete(int id)
        {
            try
            {
                Boolean isSuccess = await _customerRepository.DeleteCustomer(id);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

    }
}
