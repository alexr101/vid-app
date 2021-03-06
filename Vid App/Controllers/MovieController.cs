﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vid_App.Models;
using Vid_App.ViewModels;


namespace Vid_App.Controllers
{
    public class MovieController : Controller
    {

        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return  new List<Movie>
            {
                new Movie { Id = 1, Name = "Interstellar", ReleaseDate = DateTime.Now.Date},
                new Movie { Id = 2, Name = "Lego Movie", ReleaseDate = DateTime.Now.Date},
                new Movie { Id = 3, Name = "Kong: SKull Island", ReleaseDate = DateTime.Now.Date},
                new Movie { Id = 4, Name = "Matrix", ReleaseDate = DateTime.Now.Date},
            };

        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }



        // GET: Movies
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Interstellar" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" },
                new Customer { Name = "Customer 3" },
                new Customer { Name = "Customer 4" },
                new Customer { Name = "Customer 5" },
                new Customer { Name = "More than 5 customer so movie's hot! (CSS class on title)" },


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