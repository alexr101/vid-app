using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vid_App.Models;

namespace Vid_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Interstellar" };

            return View(movie);
            // Diffent Action Results
            
            //return Content('Hello World');
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
            // alternative: return new ViewResult(movie);
        }
    }
}