using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntity
{
    public class CategoryEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
