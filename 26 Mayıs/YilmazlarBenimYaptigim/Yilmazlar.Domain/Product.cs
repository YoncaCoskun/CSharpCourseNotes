using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yilmazlar.Domain
{
    public class Product
    {
        public int  ProductId { get; set; }
        public string ProductName { get; set; }
        public int  Stock { get; set; }
        public decimal Price { get; set; }
    }
}
