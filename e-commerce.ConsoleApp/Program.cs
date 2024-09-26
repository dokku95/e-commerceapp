

using e_commerce.Services;
using e_commerce.Services.Contracts;

ICustomerService service = new CustomerService();

service.GetCustomerById(10);