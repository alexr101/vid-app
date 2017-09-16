using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vid_App.Models;
using Vid_App.ViewModels;


namespace Vid_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Interstellar" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            // Diffent Action Results
            
            //return Content('Hello World');
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
            // alternative: return new ViewResult(movie);
        }

        [Route("movies/released/{year:regex(\\d{4}):min(1900)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("year: {0} month: {1}", year, month));
        }

        public ActionResult ParameterTest(int id)
        {
            return Content(String.Format( "id in url parameter is: {0}", id ));
        }
           
        // reference types (strings) are nullable by default
        public ActionResult OptionalParameters(int? pageIndex, string sortBy)
        {
            pageIndex = (pageIndex.HasValue) ? pageIndex : 1;
            sortBy = (!String.IsNullOrWhiteSpace(sortBy)) ? sortBy : "Name";

            return Content(String.Format("PageIndex = {0} and SortBy = {1}", pageIndex, sortBy));        
        }
    }

}