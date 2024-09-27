using e_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Services.Contracts
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);

        Customer InsertCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);

        List<Customer> GetAllCustomers(string q);

        //DeleteCustomer(int custId)

    }
}
