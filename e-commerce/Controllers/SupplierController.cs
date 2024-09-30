using e_commerce.Models;
using e_commerce.Services;
using e_commerce.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        [HttpGet("supplierbyid")]
        public Supplier GetSupplierById(int id)
        {

            return _supplierService.GetSupplierById(id);

        }


        [HttpGet("allsupplier")]
        public List<Supplier> GetAllSupplier(string q)
        {
            return _supplierService.GetAllSupplier(q);
        }

        [HttpPost("supplier")]
        public Supplier PostSupplier(Supplier supplier)
        {
            return _supplierService.InsertSupplier(supplier);
        }

        [HttpPut("supplier")]
        public Supplier UpdateSupplier(Supplier supplier)
        {
            return _supplierService.UpdateSupplier(supplier);

        }
        [HttpDelete("supplier")]
        public Supplier DeleteSupplier(Supplier supplier)
        {
            return supplier;

        }
    }
}
