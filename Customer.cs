using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public string CustomerID { get; set; }
        public List<Order> Orders { get; set; }
    }
}
