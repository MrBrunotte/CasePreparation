using BoatRentalMVC.Models.Entities;
using BoatRentalMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRentalMVC.Controllers
{
    public class Main : Controller
    {
        //private readonly BoatContext _boatContext;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterSkipper()
        {
            return View();
        }

        public IActionResult RentABoat()
        {
            return View();
        }
        // Method to return Skipper Email from database db
        private bool EmailExists(string email)
        {
            return db.Skipper.Any(else => e.Email == Email);
        }

        // Register a new Skipper
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterSkipper(RegisterSkipperViewModel viewModel)
        {
            // if form is ok
            if (ModelState.IsValid)
            {
                var skipper = new Skipper
                {
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Email = viewModel.Email
                };
                if (!EmailExists(viewModel.Email))
                {

                }
            }
        }

    }
}
