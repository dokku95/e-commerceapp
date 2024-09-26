using e_commerce.Models;
using e_commerce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        [HttpGet("supplierbyid")]
        public Supplier GetSupplierById(int id)
        { 
            SupplierService supplierService = new SupplierService();
            Supplier supplier = supplierService.GetSupplierById(id);
            return supplier;
        }
    }
}
