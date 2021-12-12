using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.UserName = "keren";
            return View();
        }

        public ActionResult showName()
        {
            ViewBag.UserName = "keren";
            return View();
        }

        public ActionResult showUser()
        {
            ViewBag.UserFirstName = "keren";
            ViewBag.UserLastName = "hailu";
            ViewBag.UserAge = 22;
            ViewBag.UserFull = new {firstName="keren",lastName="hailu",age=22};


            return View();
        }

        public ActionResult showNamesOfUsers()
        {
            ViewBag.ArrayUser = new string[] { "keren", "tikva", "eden", "yafit", "hodaya" };
            return View();
        }
        public ActionResult showNamesArrayOfUsers()
        {
            object user1 = new { firstName = "keren", lastName = "hailu", age = 22 };
            object user2 = new { firstName = "keren", lastName = "hailu", age = 22 };
            ViewBag.ArrayUser = new string[] { (string)user1, (string)user2 };
            return View();
        }
    }
}