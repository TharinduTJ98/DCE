using DCEWebAPI.Common.Models.Dtos;
using DCEWebAPI.Common.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCEWebAPI.Business.Interface
{
    public interface ICustomerBusiness
    {
        void CreateCustomer(CreateCustomerDto createCustomerDto);
        List<Customer> GetAllCusomers();
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Guid UserId);
    }
}
