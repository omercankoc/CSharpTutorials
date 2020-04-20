using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFrameworkSample
{
    class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Species { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
