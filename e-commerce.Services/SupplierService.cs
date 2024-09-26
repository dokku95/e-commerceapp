using e_commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Services
{
    public class SupplierService
    {
        public Supplier GetSupplierById(int supplierId)
        {
            Supplier s = new Supplier();
            s.SupplierId = supplierId;
            s.SupplierName = "priya";
            s.SupplierEmail = "priya12@gmail.com";
            s.SupplierPhone = "123432123";

            return s;

        }
    }
}
