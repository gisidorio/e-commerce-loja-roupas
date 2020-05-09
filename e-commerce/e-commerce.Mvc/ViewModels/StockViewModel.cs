using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce.Mvc.ViewModels
{
    public class StockViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public float UnitPrice { get; set; }
        public string ProductName { get; set; }
    }
}