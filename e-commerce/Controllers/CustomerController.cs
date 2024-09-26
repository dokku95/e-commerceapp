using e_commerce.Models;
using e_commerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("customerbyid")]
        public Customer GetCustomerById(int id)
        {
            CustomerService customerService = new CustomerService();
            Customer customer = customerService.GetCustomerById(id);
            return customer;
        }
    }
}
