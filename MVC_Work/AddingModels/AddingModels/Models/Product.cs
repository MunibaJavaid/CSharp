using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddingModels.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int OrderId { get; set; }

        public int Quantity { get; set; }
    }
}