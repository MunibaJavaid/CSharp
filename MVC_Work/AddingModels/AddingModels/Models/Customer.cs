using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddingModels.Models
{
    public class Customer
    {
        public int CustID { get; set; }

        public string CustName { get; set; }

        public decimal Amount { get; set; }
    }
}