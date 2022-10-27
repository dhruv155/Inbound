using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagement.DbContexts;
using SystemManagement.Models;
using SystemManagement.Models.Dto;

namespace SystemManagement.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbcontext = dbContext;
            _mapper = mapper;

        }


        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            ProductDto product = _mapper.Map<ProductDto, ProductDto>(productDto);
            if (product.Id > 0)
            {
                _dbcontext.Products.Update(product);

            }
            else
            {
                _dbcontext.Products.Add(product);
            }
            await _dbcontext.SaveChangesAsync();
            return _mapper.Map<ProductDto, ProductDto>(product);
        }


        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                ProductDto product = await _dbcontext.Products.FirstOrDefaultAsync(u => u.Id == productId);
                if (product == null)
                {
                    return false;
                }
                _dbcontext.Remove(product);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<ProductDto> productList = await _dbcontext.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }

        public async Task<ProductDto> GetProductsById(int productId)
        {
            ProductDto product = await _dbcontext.Products.Where(x => x.Id == productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);

        }
    }
}
