using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddingModels.Models;

namespace AddingModels.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer()
        {
            Customer c = new Customer()
            {
                CustID = 1,
                CustName = "Xyz",
                Amount = 5000
           
            };

            return View(c);
        }
        public ActionResult Product()
        {
            List<Product> products = new List<Product> {

                new Product() {ProductId = 01,ProductName = "C# Book",OrderId = 03,Quantity = 2},
                new Product() {ProductId = 02,ProductName = "ASp.Net Book",OrderId = 04,Quantity = 5},
                new Product() {ProductId = 03,ProductName = "ASP.Net Core",OrderId = 06,Quantity = 5},
                new Product() {ProductId = 04,ProductName = "C Book",OrderId = 08,Quantity = 10},
            };

            
            return View(products);
        }


    }
}