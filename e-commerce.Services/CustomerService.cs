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
            customer2.CustomerName = "Infytc";
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

        public List<Customer> GetAllCustomers(string q)
        {
            var customers = _customers.Where(x => x.CustomerName.ToLower().Contains(q.ToLower())
                            || x.CustomerCity.Contains(q));

            return customers.ToList();
        }

        public Customer InsertCustomer(Customer customer)
        {
            _customers.Add(customer);
            return customer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            //Validations
            //Validate Customer Id
            //mappings
            //Saving
            return customer;
        }
    }
}
