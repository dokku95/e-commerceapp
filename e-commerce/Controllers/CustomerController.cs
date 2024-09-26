﻿using e_commerce.Models;
using e_commerce.Services;
using e_commerce.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //private readonly ICustomerService _customerService;

        //public CustomerController()
        //{
        //    _customerService = new CustomerService();
        //}

        [HttpGet("customerbyid")]
        public Customer GetCustomerById(int id)
        {
            //CustomerService customerService = new CustomerService();
            //Customer customer = customerService.GetCustomerById(id);
            //return customer;

            return _customerService.GetCustomerById(id);
        }

        [HttpPost]
        public Customer PostCustomer(Customer customer)
        {
            return _customerService.InsertCustomer(customer);
        }
    }
}
