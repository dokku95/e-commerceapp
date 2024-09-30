using e_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Services
{
    public interface ISupplierService
    {
        List<Supplier> GetAllSupplier(string q);
        Supplier GetSupplierById(int id);

        Supplier InsertSupplier(Supplier supplier);
        Supplier UpdateSupplier(Supplier supplier);

       Supplier  DeleteSupplier(Supplier supplier);



    }
}
