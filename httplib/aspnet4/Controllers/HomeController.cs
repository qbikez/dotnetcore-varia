using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var lib = new MyLib.MyClass();
            var msg = lib.GetUserAgent(System.Web.HttpContext.Current);
            lib.WriteToResponse(System.Web.HttpContext.Current, "user agent is: " + msg);
            return new HttpStatusCodeResult(200);
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