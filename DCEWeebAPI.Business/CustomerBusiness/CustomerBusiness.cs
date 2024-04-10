using DCEWebAPI.Business.Interface;
using DCEWebAPI.Common.Models.Dtos;
using DCEWebAPI.Common.Models.Entities;
using DCEWebAPI.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCEWebAPI.Business.CustomerBusiness
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerDataAccess _customerDataAccess;

        public CustomerBusiness(ICustomerDataAccess customerDataAccess)
        {
            _customerDataAccess = customerDataAccess;
        }

        public void CreateCustomer(CreateCustomerDto createCustomerDto)
        {
            Customer customer = new Customer()
            {
                UserId = Guid.NewGuid(),
                IsActive = true,
                CreatedOn = DateTime.Now,
                Username = createCustomerDto.Username,
                FirstName = createCustomerDto.FirstName,
                LastName = createCustomerDto.LastName,
                Email = createCustomerDto.Email,
            };

            _customerDataAccess.CreateCustomer(customer);
        }

        public void DeleteCustomer(Guid UserId)
        {
            _customerDataAccess.DeleteCustomer(UserId);
        }

        public List<Customer> GetAllCusomers()
        {
            return _customerDataAccess.GetAllCustomer();
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerDataAccess.UpdateCustomer(customer);
        }
    }
}
