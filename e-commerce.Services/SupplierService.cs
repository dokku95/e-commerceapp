using e_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Services
{
    public class SupplierService : ISupplierService
    {

        List<Supplier> _supplier = new List<Supplier>();
        public SupplierService()
        {
            Supplier supplier = new Supplier();
            supplier.SupplierId = 11;
            supplier.SupplierName = "divya";
            supplier.SupplierEmail = "divya@123.com";
            supplier.SupplierPhone = "1234567890";
            _supplier.Add(supplier);

            Supplier supplier1 = new Supplier();
            supplier1.SupplierId = 12;
            supplier1.SupplierName = "priya";
            supplier1.SupplierEmail = "priyaa@123.com";
            supplier1.SupplierPhone = "1234560";
            _supplier.Add(supplier1);

            Supplier supplier2 = new Supplier();
            supplier2.SupplierId = 13;
            supplier2.SupplierName = "hema";
            supplier2.SupplierEmail = "hemaa@123.com";
            supplier2.SupplierPhone = "167890";
            _supplier.Add(supplier2);
        }

        public Supplier GetSupplierById(int supplierId)
        {
            var supplier = _supplier.Find(c => c.SupplierId == supplierId);
            return supplier ?? new Supplier();
        }

        public List<Supplier> GetAllSupplier(string q)
        {
            var customers = _supplier.Where(x => x.SupplierName.ToLower().Contains(q.ToLower())
                            || x.SupplierPhone.Contains(q));

            return customers.ToList();
        }

        public Supplier InsertSupplier(Supplier supplier)
        {
            _supplier.Add(supplier);
            return supplier;
        }

        public Supplier UpdateSupplier(Supplier supplier)
        {

            return supplier;

        }
        public Supplier DeleteSupplier(Supplier supplier)
        {
            _supplier.Remove(supplier);
           return new Supplier();
        }
    }
}






