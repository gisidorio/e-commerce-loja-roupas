using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce.Mvc.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public bool Activated { get; set; }
        public StockViewModel StockId { get; set; }
    }
}