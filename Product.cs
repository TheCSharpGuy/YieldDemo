using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldDemo
{
    public class Product
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string MfgName { get; set; }
        public double Cost { get; set; }
        public bool IsPerishable { get; set; }
    }
}
