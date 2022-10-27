using AutoMapper;
using Microsoft.EntityFrameworkCore;
using outbound.DbContexts;
using outbound.Models;
using outbound.Models.Dto;
using outbound.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _db;

        private IMapper _mapper;

        public CustomerRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;

        }

        public async Task<CustomerDto> CreateUpdateCustomer(CustomerDto customerDto)
        {
            Customer customer = _mapper.Map<CustomerDto, Customer>(customerDto);
            if (customer.Id > 0)
            {
                _db.Customers.Update(customer);

            }
            else
            {
                _db.Customers.Add(customer);

            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Customer, CustomerDto>(customer);
        }

        public async Task<bool> DeleteCustomer(int customerId)
        {
            try
            {
               Customer customer = await _db.Customers.FirstOrDefaultAsync(u => u.Id == customerId);
                if (customer == null)
                {
                    return false;
                }
                _db.Remove(customer);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            List<Customer> customerList = await _db.Customers.ToListAsync();
            return _mapper.Map<List<CustomerDto>>(customerList);
        }

        public async Task<CustomerDto> GetCustomerById(int customerId)
        {
            Customer customer = await _db.Customers.Where(x => x.Id == customerId).FirstOrDefaultAsync();
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
