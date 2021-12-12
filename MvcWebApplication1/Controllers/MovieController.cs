using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            ViewBag.Title = "keren";
            return View();
        }
        public ActionResult Movie()
        {
            ViewBag.Title = "list";
            //ViewBag.massage = new string[] { "Snow White", "Fast and Furious", "Cinderella", "Spiderman", "Batman" };
            string[] arrayMovies = new string[] { "Snow White", "Fast and Furious", "Cinderella", "Spiderman", "Batman" };
            ViewBag.Massage = arrayMovies;
            return View();
        }
    }
}