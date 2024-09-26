using e_commerce.Models;
namespace e_commerce.Services
{
    public class CustomerService
    {
        public Customer GetCustomerById(int customerId)
        {
            Customer c= new Customer();
            c.CustomerId = customerId;
            c.CustomerName = "Hema";
            c.CustomerPhone = "123456789";

            return c;
        }
    }
}
