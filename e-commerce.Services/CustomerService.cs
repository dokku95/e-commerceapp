using e_commerce.Models;
using e_commerce.Services.Contracts;
using System.Diagnostics.CodeAnalysis;
namespace e_commerce.Services
{
    public class CustomerService : ICustomerService
    {
        List<Customer> _customers = new List<Customer>();
        public CustomerService()
        {
            
            Customer customer1 = new Customer();
            customer1.CustomerId = 101;
            customer1.CustomerName = "TCS";
            customer1.CustomerEmail = "tcs@tcs.com";
            customer1.CustomerPhone = "1234";
            _customers.Add(customer1);

            Customer customer2 = new Customer();
            customer2.CustomerId = 102;
            customer2.CustomerName = "Infy";
            customer2.CustomerEmail = "Info@infy.com";
            customer2.CustomerPhone = "12345";
            _customers.Add(customer2);

            Customer customer3 = new Customer()
            {
                CustomerId = 103,
                CustomerName = "Wipro",
                CustomerEmail = "Info@wipro.com",
                CustomerPhone = "1234556"
            };
            _customers.Add(customer3);
        }

        public Customer GetCustomerById(int customerId)
        {
            var customer = _customers.Find(c => c.CustomerId == customerId);

            return customer ?? new Customer();
        }

        public Customer InsertCustomer(Customer customer)
        {
            _customers.Add(customer);
            return customer;
        }

        public List<Customer> GetAllCustomers(string q)
        {
            //IList<int> ints = new List<int>();
            //IList<string> strings = new List<string>();
            //List<bool> bools = new List<bool>();
            List<Customer> list = new List<Customer>();

            return list;
        }


        private int CustomerId(int id)
        {
            return 10;
        }
    }
}
