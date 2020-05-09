using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Domain.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public float UnitPrice { get; set; }
        public string ProductName { get; set; }
    }
}
