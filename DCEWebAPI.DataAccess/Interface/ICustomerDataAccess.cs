using DCEWebAPI.Common.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCEWebAPI.DataAccess.Interface
{
    public interface ICustomerDataAccess
    {
        void CreateCustomer(Customer customer);
        List<Customer> GetAllCustomer();
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Guid userId);
        List<Order> GetActiveOrderByCustomer(Guid customerId);
    }
}
