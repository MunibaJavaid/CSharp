using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Form.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Category()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Category(string txtname,string txtpwd,string txtemail,string gen) //view controller, controller to view
        {
            ViewBag.name = txtname;
            ViewBag.Pass = txtpwd;
            ViewBag.Email = txtemail;
            ViewBag.gender = gen;
            return View();
        }
    }
}