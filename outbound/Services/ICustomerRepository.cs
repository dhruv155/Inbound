using outbound.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outbound.Services
{
   public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomers();

        Task<CustomerDto> GetCustomerById(int customerId);

        Task<CustomerDto> CreateUpdateCustomer(CustomerDto customerDto);

        Task<bool> DeleteCustomer(int customerId);

    }
}
