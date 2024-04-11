using DCEWebAPI.Business.CustomerBusiness;
using DCEWebAPI.Business.Interface;
using DCEWebAPI.Common.Models.Dtos;
using DCEWebAPI.Common.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DCEWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBusiness _customerBusiness;

        public CustomerController(ICustomerBusiness customerBusiness)
        {
            _customerBusiness = customerBusiness;
        }

        [HttpPost("CreateCustomer")]
        public IActionResult CreateCustomer(CustomerDto customerDto)
        {
            _customerBusiness.CreateCustomer(customerDto);
            return Ok(customerDto);
        }

        [HttpGet("GetAllCustomer")]
        public IActionResult GetAllCustomer()
        {
            var customers = _customerBusiness.GetAllCusomers();
            return Ok(customers);
        }

        [HttpDelete("DeleteCustomer/{userId}")]
        public IActionResult DeleteCustomer(Guid userId)
        {
            _customerBusiness.DeleteCustomer(userId);
            var customers = _customerBusiness.GetAllCusomers();

            return Ok(customers);
        }

        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer(Guid id, Customer customer)
        {
            _customerBusiness.UpdateCustomer(customer);
            return Ok(customer);
        }

        [HttpGet("ActiveOrders/{userId}")]
        public ActionResult<List<Order>> GetCustomer(Guid userId)
        {
            return _customerBusiness.GetActiveOrderByCustomer(userId);
        }
    }
}
