using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vid_App.Models;

namespace Vid_App.ViewModels
{
    public class RandomMovieViewModel
    {
        // Basically these are Models...composed of models
        // Why? Because the Views can only take ONE model at a time
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}