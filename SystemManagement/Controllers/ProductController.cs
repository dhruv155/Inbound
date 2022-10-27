using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagement.Models;
using SystemManagement.Models.Dto;
using SystemManagement.Services;

namespace SystemManagement.Controllers
{
    public class ProductController : ControllerBase
    {
        protected ResponseDto _reponse;
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            this._reponse = new ResponseDto();
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> Get()
        {
            IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
          return productDtos;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Object> Get(int id)
        {
            try
            {
                ProductDto productDtos = await _productRepository.GetProductsById(id);
                _reponse.Result = productDtos;
            }
            catch (Exception ex)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessage = new List<String>()
                {
                    ex.ToString()
                };
            }
            return _reponse;
        }

        [HttpPost]
        public async Task<ProductDto> Post([FromBody] ProductDto productDto)
        {
            ProductDto model = await _productRepository.CreateUpdateProduct(productDto);
     
            return model;


        }

        [HttpPut]
        public async Task<Object> Put([FromBody] ProductDto productDto)
        {
            try
            {
                ProductDto model = await _productRepository.CreateUpdateProduct(productDto);
                _reponse.Result = model;
            }
            catch (Exception ex)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessage = new List<String>()
                {
                    ex.ToString()
                };
            }
            return _reponse;
        }

        [HttpDelete]
        public async Task<Object> Delete(int id)
        {
            try
            {
                Boolean isSuccess = await _productRepository.DeleteProduct(id);
                _reponse.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _reponse.IsSuccess = false;
                _reponse.ErrorMessage = new List<String>()
                {
                    ex.ToString()
                };
            }
            return _reponse;
        }
    }
}
