using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace cokKatmanli.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SuplierId { get; set; }
        public int KategoriId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
