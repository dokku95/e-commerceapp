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

        //GetCustomerbyId(int id)
        //GetAllCustomers(string q)
        //Insert/Update Customer (Customer custObj)
        //DeleteCustomer(int custId)

    }
}
