using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntity
{
    public class ProductEntity
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return this.ProductName;
        }

        public object CategoryId { get; set; }
    }
}
