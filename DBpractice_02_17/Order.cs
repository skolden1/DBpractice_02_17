﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBpractice_02_17
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

    }
}
