using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBpractice_02_17
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? Name { get; set; }  //"?" gör att denna kan vara null(inget värde)
        public decimal Price { get; set; }
        public int OrderId { get; set; }
    }
}
