using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vid_App.Models;

namespace Vid_App.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }        

        public ActionResult Details(int id)
        {
            // Get the customer whose id matches the id given in the url parameter
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Alex", Age = 27 },
                new Customer { Id = 2, Name = "Rocky", Age = 43 },
                new Customer { Id = 3, Name = "Thomas", Age = 14 },
                new Customer { Id = 4, Name = "jensen", Age = 22 }
            };
        }
    }
}