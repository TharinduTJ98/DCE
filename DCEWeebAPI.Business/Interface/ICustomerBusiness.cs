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
        void CreateCustomer(CustomerDto customerDto);
        List<Customer> GetAllCusomers();
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Guid UserId);
        List<Order> GetActiveOrderByCustomer(Guid OrderId);

    }
}
