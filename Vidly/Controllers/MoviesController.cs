using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
            // return Content("bleh");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy= "name"});
        }
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content("Page index: " + pageIndex + ". Sort by: " + sortBy);
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            //if (!year.HasValue)
            //    year = 1;
            //if (!month.HasValue)
            //    month = 1;

            return Content(string.Format("It is movie which relase date was {1}/{0}",year , month));
        }
    }
}