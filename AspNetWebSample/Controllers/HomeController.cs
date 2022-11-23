using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetWebSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string version = ConfigurationManager.AppSettings["version"];
            this.ViewBag.version = version;
            return View();
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