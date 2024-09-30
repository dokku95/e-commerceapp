using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; } 

        public string SupplierName { get; set; } = string.Empty;

         public string SupplierEmail { get; set; } = string.Empty;

        public string SupplierPhone { get; set; } = string.Empty ;


        public string SupplierAddress { get; set; } = string.Empty;

      

    }
}
