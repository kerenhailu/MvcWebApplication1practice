using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApplication1.Controllers
{
    public class MoviesListController : Controller
    {
        // GET: MoviesList
        public ActionResult Index()
        {
            ViewBag.Title = "list";
            //ViewBag.massage = new string[] { "Snow White", "Fast and Furious", "Cinderella", "Spiderman", "Batman" };
            string[] arrayMovies=new string[] { "Snow White", "Fast and Furious", "Cinderella", "Spiderman", "Batman" };
            ViewBag.Massage = arrayMovies;
            return View();
        }
    }
}