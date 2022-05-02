using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataConnection_DBfirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly LokeshEntities lokesh;
        public HomeController()
        {
            lokesh = new LokeshEntities();
        }

        public ActionResult Index()
        {
            List<employee> emp = lokesh.employees.ToList();
            return View(emp);
        } 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}