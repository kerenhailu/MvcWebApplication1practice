using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class SdarotController : Controller
    {
        // GET: Sdarot
        public ActionResult Index()
        {
            ViewBag.Title = "sdarot";
            return View();
        }
    }
}