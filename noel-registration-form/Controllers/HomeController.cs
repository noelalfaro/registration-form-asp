using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using noel_registration_form.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace noel_registration_form.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                // Do something with the reservation data, such as save it to a database
                // and redirect to a confirmation page
                var viewModel = new ConfirmationViewModel
                {
                    Reservation = reservation
                };
                return View("Confirmation", viewModel);
            }
            else
            {
                // If the model state is not valid, redisplay the reservation form
                return View("Index", reservation);
            }
        }
    }
}

